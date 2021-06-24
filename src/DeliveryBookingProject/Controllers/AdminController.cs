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
    public class AdminController : Controller
    {
        private ILogger<AdminController> _logger;
        private IRepo<Customer> _repoCustomer;
        private IRepo<DeliveryExecutive> _repoExecutive;
        private IRepo<DeliveryBooking> _repoDelivery;
        public AdminController(ILogger<AdminController> logger, IRepo<Customer> repoCustomer, IRepo<DeliveryExecutive> repoExecutive,IRepo<DeliveryBooking> repoDelivery)
        {
            _logger = logger;
            _repoCustomer = repoCustomer;
            _repoExecutive = repoExecutive;
            _repoDelivery = repoDelivery;
        }
        
        [HttpGet]
        public IActionResult AdminLogin(User user)
        {
            try
            {
                if (user.UserName == "Apple" && user.Password == "Apple")
                {
                    TempData["AUName"] = user.UserName;
                    return RedirectToAction("Home");
                }
                else if(user.Password == null)
                {
                    TempData["ErrMsg"] = "Please Enter Password";
                    return RedirectToAction("Error", "User");
                }
                else
                {
                    TempData["ErrMsg"] = "Incorrect UserName or Password";
                    return RedirectToAction("Error", "User");
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return RedirectToAction("Login", "User");
            }
        }
        public ActionResult Home()
        {
            if (TempData.Count()>1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");   //from Executive Controller
            }
            else if (TempData.Count() == 1)
            {
                return View();                                  //from Admin Controller
            }
            else
            {
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
        }
        public ActionResult CustomerDetails()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");
            }
            else if (TempData.Count() == 1)
            {
                try
                {
                    List<Customer> customers = _repoCustomer.GetAllInfo().ToList();
                    if (customers != null)
                        return View(customers);
                    else
                        return View();
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();
                }                                               //from Admin Controller
            }
            else
            {
                return RedirectToAction("Index", "Home");       //from User or Home Controller
            }
           
        }
        public ActionResult ExecutiveDetails()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");
            }
            else if (TempData.Count() == 1)
            {
                try
                {
                    List<DeliveryExecutive> executives = _repoExecutive.GetAllInfo().ToList();
                    if (executives != null)
                        return View(executives);
                    else
                        return View();
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult CustomerRequests()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");
            }
            else if (TempData.Count() == 1)
            {
                try
                {
                    List<Customer> customers = _repoCustomer.GetAllInfo().ToList();
                    List<Customer> customer = customers.Where(a => a.IsVerified == "Requested").ToList();
                    if (customer.Count() != 0)
                        return View(customer);
                    else
                        return View();
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult ExecutiveRequests()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");
            }
            else if(TempData.Count() == 1)
            {
                try
                {
                    List<DeliveryExecutive> executives = _repoExecutive.GetAllInfo().ToList();
                    List<DeliveryExecutive> executive = executives.Where(a => a.IsVerified == "Requested").ToList();
                    if (executive.Count() != 0)
                        return View(executive);
                    else
                        //alert Box no content();
                        return View();
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        // GET: AdminController/Details/5
        public ActionResult CustomerProfile(int Id)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");
            }
            else if (TempData.Count() == 1)
            {
                try
                {
                    Customer customer = _repoCustomer.GetById(Id);
                    if (customer != null)
                        return View(customer);
                    return View();
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult ExecutiveProfile(int Id)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");
            }
            else if(TempData.Count() == 1)
            {
                try
                {
                    DeliveryExecutive executive = _repoExecutive.GetById(Id);
                    if (executive != null)
                        return View(executive);
                    return View();
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                }
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCustomerRequest(int Id,Customer Status)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");
            }
            else if (TempData.Count() == 1)
            {
                try
                {
                    Customer customer = _repoCustomer.GetById(Id);
                    if (customer != null)
                    {
                        customer.IsVerified = Status.IsVerified;
                        _repoCustomer.EditInfo(customer);
                        return RedirectToAction("CustomerRequests");
                    }
                    else
                    {
                        //alert there is no customer
                        return NoContent();
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
        [HttpPost]
        public ActionResult EditExecutiveRequest(int Id,DeliveryExecutive ExecutiveStatus)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");
            }
            else if(TempData.Count() == 1)
            {
                try
                {
                    DeliveryExecutive executive = _repoExecutive.GetById(Id);
                    if (executive != null)
                    {
                        executive.IsVerified = ExecutiveStatus.IsVerified;
                        _repoExecutive.EditInfo(executive);
                        return RedirectToAction("ExecutiveRequests");
                    }
                    else
                    {
                        //alert there is no executive
                        return NoContent();
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult OrdersDetails()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");
            }
            else if (TempData.Count() == 1)
            {
                try
                {
                    List<DeliveryBooking> bookings = _repoDelivery.GetAllInfo().ToList();
                    foreach (var item in bookings)
                    {
                        if (item.PickUpDateTime <= DateTime.Now && item.BookingStatus == "ExecutiveAccept")
                        {
                            item.BookingStatus = "PackagePickUped";
                            _repoDelivery.EditInfo(item);
                        }
                    }
                    bookings = _repoDelivery.GetAllInfo().ToList();
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
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult OrdersDetailsById(int Id)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");
            }
            else if (TempData.Count() == 1)
            {
                try
                {
                    DeliveryBooking delivery = _repoDelivery.GetById(Id);
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
                    _logger.LogError(e.Message);
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
        public ActionResult Logout()
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");
            }
            else if (TempData.Count() == 1)
            {
                foreach (var key in TempData.Keys.ToList())
                {
                    TempData.Remove(key);
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
