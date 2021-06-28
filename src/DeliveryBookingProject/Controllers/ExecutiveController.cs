using DeliveryBookingProject.Models;
using DeliveryBookingProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingProject.Controllers
{
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
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
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");   //from Executive Controller
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");        //from Admin Controller
            }
            else
            {
                return View();                                  //from User or Home Controller
            }
        }
        [HttpPost]
        public ActionResult Register(DeliveryExecutive executive)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                if (ModelState.IsValid)
                {
                    var record = _repoExecutive.GetByUserName(executive.UserName);
                    if (record == null && executive.UserName != "Apple")
                    {
                        executive.IsVerified = "Requested";
                        executive.City = executive.City.ToLower();
                        bool result=_repoExecutive.AddInfo(executive);
                        if(result == true)
                        {
                            TempData["UserName"] = executive.UserName;
                            TempData["Success"] = "Registered";
                            return View();
                        }
                        else
                        {
                            TempData["Msg"] = "Not Registered";
                            return RedirectToAction("Error");
                        }
                    }
                    else
                    {
                        TempData["Msg"] = "UserName Exists";
                        return RedirectToAction("Error");
                    }
                }
                else
                {
                    return View(executive);
                }                                               //from Executive Controller
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");         //from Admin Controller
            }
            else
            {
                return View();                                 //from User or Home Controller
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
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                int id = Convert.ToInt32(TempData.Peek("ExeID"));
                return View();                                  //from Executive Controller
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");         //from Admin Controller
            }
            else
            {
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        public ActionResult Profile()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                try
                {
                    int id = Convert.ToInt32(TempData.Peek("ExeID"));
                    DeliveryExecutive executive = _repoExecutive.GetById(id);
                    if (executive != null)
                    {
                        return View(executive);
                    }
                    else
                    {
                        return View(executive);
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();                              //from Executive Controller
                }
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");        //from Admin Controller
            }
            else
            {
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        // GET: ExecutiveController/Edit/5
        public ActionResult EditExecutiveInfo()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                try
                {
                    int id = Convert.ToInt32(TempData.Peek("ExeID"));
                    DeliveryExecutive executive = _repoExecutive.GetById(id);
                    if (executive != null)
                    {
                        return View(executive);
                    }
                    else
                    {
                        return View(executive);
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();                              //from Executive Controller
                }                                               
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");        //from Admin Controller
            }
            else
            {
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditExecutiveInfo(DeliveryExecutive executive)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
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
                    _logger.LogError(e.Message);
                    return View();                              //from Executive Controller
                }
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");        //from Admin Controller
            }
            else
            {
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        public ActionResult BookingRequests()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");                    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
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
                        return View(bookings);
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();                              //from Executive Controller
                }          
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");           //from Admin Controller
            }
            else
            {
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        public ActionResult BookingDetailById(int Id)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                try
                {
                    DeliveryBooking delivery = _repoBooking.GetById(Id);
                    if (delivery != null && delivery.BookingStatus == "CustomerRequest")
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
                            return RedirectToAction("Error", "Executive");
                        }
                    }
                    else
                    {
                        return View(delivery);
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();
                }                                              //from Executive Controller
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");       //from Admin Controller
            }
            else
            {
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        [HttpPost]
        public ActionResult EditRequests(DeliveryBooking booking,string action)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                try
                {
                    int order_id = Convert.ToInt32(TempData.Peek("Id"));
                    DeliveryBooking delivery = _repoBooking.GetById(order_id);
                    if (delivery != null)
                    {
                        if (action == "Accept")
                        {
                            delivery.BookingStatus = "ExecutiveAccept";
                        }
                        else if (action == "Reject")
                        {
                            delivery.BookingStatus = "ExecutiveReject";
                        }
                        delivery.ResMessage = booking.ResMessage;
                        _repoBooking.EditInfo(delivery);
                        return RedirectToAction("BookingRequests");
                    }
                    else
                    {
                        TempData["Msg"] = "Order Not Found";
                        return RedirectToAction("Error", "Executive");
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();                               //from Executive Controller
                }
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");             //from Admin Controller
            }
            else
            {
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        public ActionResult TrackOrder()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                try
                {
                    int Exec_id = Convert.ToInt32(TempData.Peek("ExeID"));
                    List<DeliveryBooking> bookings = _repoBooking.GetAllInfo().Where(a => a.ExecutiveId == Exec_id && a.BookingStatus == "ExecutiveAccept" && a.PickUpDateTime.Date >= DateTime.Today.Date).ToList();
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
                    _logger.LogError(e.Message);
                    return View();
                }                                               //from Executive Controller
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");        //from Admin Controller
            }
            else
            {
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        // GET: CustomerController/Details/5
        public ActionResult BookingDetails()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
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
                    _logger.LogError(e.Message);
                    return View();
                }                                               //from Executive Controller
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");       //from Admin Controller
            }
            else
            {
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        public ActionResult BookingDetailByOrderId(int Id)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                try
                {
                    DeliveryBooking delivery = _repoBooking.GetById(Id);
                    if (delivery != null)
                    {
                        if (TempData.Peek("ExeID").Equals(delivery.ExecutiveId))
                        {
                            return View(delivery);
                        }
                        else
                        {
                            TempData["Msg"] = "Not Eligible";
                            return RedirectToAction("Error", "Executive");
                        }
                    }
                    else
                    {
                        return View();
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();
                }                                               //from Executive Controller
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");       //from Admin Controller
            }
            else
            {
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        public ActionResult Logout()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                TempData.Clear();
                return RedirectToAction("Index", "Home");       //from Executive Controller
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");          //from Admin Controller
            }
            else
            {
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        public ActionResult Error()
        {
            _logger.LogInformation(TempData.Peek("Msg").ToString());
            return View();
        }
    }
}
