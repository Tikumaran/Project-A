using DeliveryBookingProject.Models;
using DeliveryBookingProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingProject.Controllers
{
    public class ExecutiveController : Controller
    {
        private IRepo<DeliveryExecutive> _repoExecutive;
        private IRepo<DeliveryBooking> _repoBooking;
        private IRepo<Customer> _repoCustomer;
        private ILogger<ExecutiveController> _logger;
        public ExecutiveController(IRepo<DeliveryExecutive> repoExecutive, IRepo<Customer> repoCustomer, IRepo<DeliveryBooking> repoBooking, ILogger<ExecutiveController> logger)
        {
            _repoExecutive = repoExecutive;
            _repoBooking = repoBooking;
            _repoCustomer = repoCustomer;
            _logger = logger;
        }
        [HttpGet]
        //GET: CustomerController/Register
        public ActionResult Register()
        {
            DeliveryExecutive executive = new DeliveryExecutive();
            return View(executive);
        }
        [HttpPost]
        public ActionResult Register(DeliveryExecutive executive)
        {
            if (ModelState.IsValid)
            {
                var record = _repoExecutive.GetByUserName(executive.UserName);
                if (record == null)
                {
                    executive.IsVerified = "Requested";
                    executive.City=executive.City.ToLower();
                    _repoExecutive.AddInfo(executive);
                    TempData["UserName"] = executive.UserName;
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    return RedirectToAction("Error");
                }
            }
            else
            {
                return View(executive);
            }
        }
       
        public IActionResult ExecutiveLogin(User user)
        {
            string UserName = user.UserName;
            DeliveryExecutive Records = _repoExecutive.GetByUserName(UserName);
            if (Records != null && Records.Password == user.Password)
            {
                if (Records.IsVerified == "Verified")
                {
                    TempData["ExeID"] = Records.ExecutiveId;
                    //TempData["City"] = Records.City;
                    TempData["Exec_Name"] = Records.ExecutiveName;
                    return RedirectToAction("Home");
                }
                else
                {
                    TempData["ErrMsg"] = "Your Account was Not Verified";
                    return RedirectToAction("Error", "User");
                }
            }
            else
            {
                //alert Incorrect UserName Or Password
                TempData["ErrMsg"] = "Incorrect UserName or Password";
                return RedirectToAction("Error", "User");
            }
        }
        public ActionResult Home()
        {
            int id = Convert.ToInt32(TempData.Peek("ExeID"));
            return View();
        }
        public ActionResult Profile()
        {
            try
            {
                int id = Convert.ToInt32(TempData.Peek("ExeID"));
                DeliveryExecutive executive = _repoExecutive.GetById(id);
                if (executive != null)
                    return View(executive);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return View();
        }
        // GET: ExecutiveController/Edit/5
        public ActionResult EditExecutiveInfo()
        {
            try
            {
                int id = Convert.ToInt32(TempData.Peek("ExeID"));
                DeliveryExecutive executive = _repoExecutive.GetById(id);
                if (executive != null)
                    return View(executive);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return View();
        }

        // POST: ExecutiveController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditExecutiveInfo(DeliveryExecutive executive)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repoExecutive.EditInfo(executive);
                    return RedirectToAction("Profile");
                }
                else
                {
                    return View(executive);
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return View();
        }
        public ActionResult BookingRequests()
        {
            try
            {
                int Exec_id = Convert.ToInt32(TempData.Peek("ExeID"));
                List<DeliveryBooking> bookings = _repoBooking.GetAllInfo().Where(a => a.ExecutiveId == Exec_id && a.BookingStatus == "CustomerRequest").ToList();
                foreach (var item in bookings)
                {
                    if (item.PickUpDateTime < DateTime.Now && item.BookingStatus == "CustomerRequest")//Need analyse
                    {
                        item.BookingStatus = "ExecutiveReject";
                        item.ResMessage = "No Not Available";
                        _repoBooking.EditInfo(item);
                    }
                }
                bookings = _repoBooking.GetAllInfo().Where(a => a.ExecutiveId == Exec_id && a.BookingStatus == "CustomerRequest").ToList();
                if (bookings.Count() != 0)
                {
                    return View(bookings);
                }
                else
                {
                    //nodata
                    return View();
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return View();
        }
        public ActionResult BookingDetailById(int Id)
        {
            try
            {
                DeliveryBooking delivery = _repoBooking.GetById(Id);
                if (delivery != null && delivery.BookingStatus== "CustomerRequest")
                {
                    if (TempData.Peek("ExeID").Equals(delivery.ExecutiveId))
                    {
                        Customer customer = _repoCustomer.GetById(delivery.CustomerId);
                        TempData["Address"] = customer.Address.ToString();
                        TempData["City"] = customer.City.ToString();//.Concat(customer.City);
                        return View(delivery);
                    }
                    else
                    {
                        TempData["Msg"] = "Not Eligible";
                        return RedirectToAction("Error", "Customer");
                    }
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return View();
        }
        [HttpPost]
        public ActionResult EditRequests(DeliveryBooking booking,string accept,string reject)
        {
            try
            {
                int order_id = Convert.ToInt32(TempData.Peek("Id"));
                //string Res_message = TempData.Peek("Msg").ToString();
                DeliveryBooking delivery = _repoBooking.GetById(order_id);
                if (delivery != null)
                {
                    if (!string.IsNullOrEmpty(accept))
                    {
                        delivery.BookingStatus = "ExecutiveAccept";
                    }
                    if (!string.IsNullOrEmpty(reject))
                    {
                        delivery.BookingStatus = "ExecutiveReject";
                    }
                    delivery.ResMessage = booking.ResMessage;
                    _repoBooking.EditInfo(delivery);
                    return RedirectToAction("BookingRequests");
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return NoContent();
        }
        public ActionResult TrackOrder()
        {
            try
            {
                int Exec_id = Convert.ToInt32(TempData.Peek("ExeID"));
                List<DeliveryBooking> bookings = _repoBooking.GetAllInfo().Where(a => a.ExecutiveId == Exec_id && a.BookingStatus == "ExecutiveAccept" && a.PickUpDateTime >= DateTime.Now).ToList();
                if (bookings.Count() != 0)
                {
                    return View(bookings);
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return View();
        }
        // GET: CustomerController/Details/5
        public ActionResult BookingDetails()
        {
            try
            {
                int Exec_id = Convert.ToInt32(TempData.Peek("ExeID"));
                List<DeliveryBooking> bookings = _repoBooking.GetAllInfo().Where(a => a.ExecutiveId == Exec_id).ToList();
                foreach (var item in bookings)
                {
                    if (item.PickUpDateTime < DateTime.Now && item.BookingStatus == "ExecutiveAccept")
                    {
                        item.BookingStatus = "PackagePickUped";
                        _repoBooking.EditInfo(item);
                    }
                }
                if (bookings.Count() != 0)
                {
                    return View(bookings);
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return View();
        }
        public ActionResult BookingDetailByOrderId(int Id)
        {
            try
            { 
                DeliveryBooking delivery = _repoBooking.GetById(Id);
                if (delivery != null)
                {
                    return View(delivery);
                }
                else
                {
                    return View(delivery);
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return View();
        }
        public ActionResult Logout()
        {
            foreach (var key in TempData.Keys.ToList())
            {
                TempData.Remove(key);
            }
            return RedirectToAction("Index","Home");
        }
        public ActionResult Error()
        {
            return View();
        }
        /*// GET: ExecutiveController/Delete/5
        public ActionResult DeleteExecutiveInfo()
        {
            int id = Convert.ToInt32(TempData.Peek("UserID"));
            DeliveryExecutive executive = _repoExecutive.GetById(id);
            return View(executive);
        }
        // POST: ExecutiveController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteExecutiveInfo(DeliveryExecutive executive)
        {
            try
            {
                if (executive != null)
                {
                    _repoExecutive.DeleteInfo(executive);
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    return NoContent();
                }
            }
            catch
            {
                return View();
            }
        }*/
    }
}
