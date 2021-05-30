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
            string UserName = executive.UserName;
            DeliveryExecutive Records = _repoExecutive.GetByUserName(UserName);
            if (Records == null)
            {
                executive.IsVerified = "Requested";
                _repoExecutive.AddInfo(executive);
                TempData["UserName"] = UserName;
                return RedirectToAction("Login", "User");
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
                    TempData.Clear();
                    TempData["UserID"] = Records.ExecutiveId;
                    //TempData["City"] = Records.City;
                    //TempData["UserName"] = Records.UserName;
                    return RedirectToAction("Profile");
                }
                else
                {
                    //alert Your Account was Not Verified
                    return RedirectToAction("Login", "User", new { user = user });
                }
            }
            else
            {
                //alert Incorrect UserName Or Password
                user.Password = "";
                return RedirectToAction("Login", "User", new { user = user });
            }
        }
        public ActionResult Profile()
        {
            int id = Convert.ToInt32(TempData.Peek("UserID"));
            DeliveryExecutive executive = _repoExecutive.GetById(id);
            if (executive != null)
                return View(executive);
            return View();
        }
        // GET: ExecutiveController/Edit/5
        public ActionResult EditExecutiveInfo()
        {
            int id = Convert.ToInt32(TempData.Peek("UserID"));
            DeliveryExecutive executive = _repoExecutive.GetById(id);
            return View(executive);
        }

        // POST: ExecutiveController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditExecutiveInfo(DeliveryExecutive executive)
        {
            try
            {
                int id = executive.ExecutiveId;
                DeliveryExecutive executiveOldInfo = _repoExecutive.GetById(executive.ExecutiveId);
                executive.IsVerified = executiveOldInfo.IsVerified;
                if (executive != null)
                {
                    _repoExecutive.EditInfo(executive);
                    return RedirectToAction("Profile");
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
        }
        public ActionResult BookingRequests()
        {
            int Exec_id = Convert.ToInt32(TempData.Peek("UserID"));
            List<DeliveryBooking> bookings = _repoBooking.GetAllInfo().Where(a => a.ExecutiveId == Exec_id && a.BookingStatus == "CustomerRequest").ToList();
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
        // GET: CustomerController/Details/5
        public ActionResult BookingDetails()
        {
            int Exec_id = Convert.ToInt32(TempData.Peek("UserID"));
            List<DeliveryBooking> bookings = _repoBooking.GetAllInfo().Where(a => a.ExecutiveId == Exec_id && a.BookingStatus == "ExecutiveAccept" || a.BookingStatus == "PackagePickUped").ToList();
            foreach (var item in bookings)
            {
                if (item.PickUpDateTime >= DateTime.Now && item.BookingStatus == "ExecutiveAccept")
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
                return View(bookings);
            }
        }
        public ActionResult BookingDetailById()
        {
            int Order_Id = Convert.ToInt32(TempData.Peek("OrderId"));
            DeliveryBooking delivery = _repoBooking.GetById(Order_Id);
            if (delivery != null)
            {
                TempData["Address"] = _repoCustomer.GetById(delivery.CustomerId).Address;
                return View(delivery);
            }
            else
            {
                return View();
            }
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
