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
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true,Duration =0)]
    public class CustomerController : Controller
    {
        private IRepo<Customer> _repoCustomer;
        private IRepo<DeliveryExecutive> _repoExecutive;
        private IRepo<DeliveryBooking> _repoBooking;
        private ILogger<CustomerController> _logger;
        public CustomerController(IRepo<Customer> repoCustomer,IRepo<DeliveryExecutive> repoExecutive,IRepo<DeliveryBooking> repoBooking, ILogger<CustomerController> logger)
        {
            _repoCustomer = repoCustomer;
            _repoExecutive = repoExecutive;
            _repoBooking = repoBooking;
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
                return View();                         //from User or Home Controller
            }
        }
        [HttpPost]
        public ActionResult Register(Customer customer)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");   //from Executive Controller
            }else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");       //from Admin Controller
            }else
            {
                if (ModelState.IsValid)
                {
                    var record = _repoCustomer.GetByUserName(customer.UserName);
                    if (record == null && customer.UserName != "Apple")
                    {
                        customer.IsVerified = "Requested";
                        customer.City = customer.City.ToLower();
                        bool result=_repoCustomer.AddInfo(customer);
                        if(result == true)
                        {
                            TempData["Success"] = "Registered";
                            TempData["UserName"] = customer.UserName;
                            return View();
                        }
                        else
                        {
                            TempData["Msg"] = "Not Registered";
                            return RedirectToAction("Error");
                        }
                        
                    }else
                    {
                        TempData["Msg"] = "UserName Exists";
                        return RedirectToAction("Error");
                    }
                }else
                {
                    return View(customer);
                }                                                   //from User or Home Controller
            }
        }
        public IActionResult CustomerLogin(User user)
        {
            string UserName = user.UserName;
            Customer Records = _repoCustomer.GetByUserName(UserName);
            if (Records != null && Records.Password == user.Password) 
            {
                if(Records.IsVerified == "Verified")
                {
                    TempData["UserID"] = Records.CustomerId;
                    TempData["City"] = Records.City;
                    //TempData["UserName"] = Records.UserName;
                    TempData["Cust_Name"] = Records.CustomerName;
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
                int id = Convert.ToInt32(TempData.Peek("UserID"));
                return View();                                   //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");   //from Executive Controller
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
        public ActionResult Profile()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                try
                {
                    int Cust_id = Convert.ToInt32(TempData.Peek("UserId"));
                    Customer customer = _repoCustomer.GetById(Cust_id);
                    if (customer != null)
                    {
                        return View(customer);
                    }
                    else
                    {
                        return View(customer);
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();
                }                                              //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");   //from Executive Controller
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
        [HttpGet]
        // GET: CustomerController/Edit/5
        public ActionResult EditCustomerInfo()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                try
                {
                    int id = Convert.ToInt32(TempData.Peek("UserID"));
                    Customer customer = _repoCustomer.GetById(id);
                    return View(customer);
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();
                }                                              //from Customer Controller
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
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCustomerInfo(Customer customer)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        _repoCustomer.EditInfo(customer);
                        return RedirectToAction("Profile");
                    }
                    else
                    {
                        return View(customer);
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();
                }                                                //from Customer Controller
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
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        [HttpGet]
        public ActionResult BookingExecutive()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                try
                {
                    int id = Convert.ToInt32(TempData.Peek("UserID"));
                    string city = TempData.Peek("City").ToString();
                    List<DeliveryExecutive> executives = _repoExecutive.GetAllInfo().Where(a => a.City == city && a.IsVerified == "Verified").ToList();
                    if (executives.Count() != 0)
                    {
                        return View(executives);
                    }
                    else
                    {
                        //no content();
                        return View();
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();
                }                                               //from Customer Controller
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
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        [HttpGet]
        public ActionResult BookingStatus()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                try
                {
                    int Cust_id = Convert.ToInt32(TempData.Peek("UserID"));
                    List<DeliveryBooking> bookings = _repoBooking.GetAllInfo().Where(a => a.CustomerId == Cust_id && a.BookingStatus == "CustomerRequest" || a.BookingStatus == "ExecutiveAccept" || a.BookingStatus == "ExecutiveReject").ToList();
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
                    return View();
                }                                                //from Customer Controller
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
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        public ActionResult BookingDetailById(int Id)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                try
                {
                    DeliveryBooking delivery = _repoBooking.GetById(Id);
                    if (delivery != null)
                    {
                        if (TempData.Peek("UserID").Equals(delivery.CustomerId))
                        {
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
                    _logger.LogError(e.Message);
                    return View();
                }                                               //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");   //from Executive Controller
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
        // GET: CustomerController/Details/5
        public ActionResult BookingDetails()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                try
                {
                    int Cust_id = Convert.ToInt32(TempData.Peek("UserID"));
                    List<DeliveryBooking> bookings = _repoBooking.GetAllInfo().Where(a => a.CustomerId == Cust_id).ToList();
                    foreach (var item in bookings)
                    {
                        if (item.PickUpDateTime <= DateTime.Now && item.BookingStatus == "ExecutiveAccept")
                        {
                            item.BookingStatus = "PackagePickUped";
                            _repoBooking.EditInfo(item);
                        }
                    }
                    bookings = _repoBooking.GetAllInfo().Where(a => a.CustomerId == Cust_id).ToList();
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
                    return View();
                }                                                //from Customer Controller
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
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        public ActionResult Logout()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                TempData.Clear();
                return RedirectToAction("Index", "Home");        //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");   //from Executive Controller
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
        public ActionResult Error()
        {
            _logger.LogInformation(TempData.Peek("Msg").ToString());
            return View();
        }
    }
}
