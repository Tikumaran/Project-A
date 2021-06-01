﻿using DeliveryBookingProject.Models;
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
            Customer customer = new Customer();
            return View(customer);
        }
        [HttpPost]
        public ActionResult Register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.IsVerified = "Requested";
                _repoCustomer.AddInfo(customer);
                TempData["UserName"] = customer.UserName;
                return RedirectToAction("Login", "User");
            }
            else
            {
                return View(customer);
            }
        }
        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyUserName(string Username)
        {
            if (_repoCustomer.GetByUserName(Username) !=null)
            {
                return Json($"UserName {Username} is already in use.");
            }

            return Json(true);
        }
        public IActionResult CustomerLogin(User user)
        {
            string UserName = user.UserName;
            Customer Records = _repoCustomer.GetByUserName(UserName);
            if (Records != null && Records.Password == user.Password) 
            {
                if(Records.IsVerified == "Verified")
                {
                    TempData.Clear();
                    TempData["UserID"] = Records.CustomerId;
                    TempData["City"] = Records.City;
                    //TempData["UserName"] = Records.UserName;
                    TempData["Cust_Name"] = Records.CustomerName;
                    return RedirectToAction("Home");
                }
                else
                {
                    //alert Your Account was Not Verified
                    return RedirectToAction("Login", "User",new { user=user});
                }
            }
            else
            {
                //alert Incorrect UserName Or Password
                user.Password = null;
                return RedirectToAction("Login", "User", new { user = user });
            }
        }
        public ActionResult Home()
        {
            int id = Convert.ToInt32(TempData.Peek("UserID"));
            return View();
        }
        public ActionResult Profile()
        {
            try
            {
                int Cust_id = Convert.ToInt32(TempData.Peek("UserId"));
                Customer customer = _repoCustomer.GetById(Cust_id);
                if (customer != null)
                {
                    return View(customer);
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return View();
        }
        [HttpGet]
        // GET: CustomerController/Edit/5
        public ActionResult EditCustomerInfo()
        {
            try
            {
                int id = Convert.ToInt32(TempData.Peek("UserID"));
                Customer customer = _repoCustomer.GetById(id);
                return View(customer);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCustomerInfo(Customer customer)
        {
            try
            { 
                if (customer != null)
                {
                    _repoCustomer.EditInfo(customer);
                    return RedirectToAction("Profile");
                }
                else
                {
                    return View(customer);
                }
            }
            catch(Exception e)
            {
                _logger.LogDebug(e.Message);
                return View();
            }
        }
        [HttpGet]
        public ActionResult BookingExecutive()
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
                _logger.LogDebug(e.Message);
                return View();
            }
        }
        [HttpGet]
        public ActionResult BookingStatus()
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
                _logger.LogDebug(e.Message);
            }
            return NoContent();
        }
        public ActionResult BookingDetailById(int Id)
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
                int Cust_id = Convert.ToInt32(TempData.Peek("UserID"));
                List<DeliveryBooking> bookings = _repoBooking.GetAllInfo().Where(a => a.CustomerId == Cust_id && a.BookingStatus == "ExecutiveAccept" || a.BookingStatus == "PackagePickUped" || a.BookingStatus == "ExecutiveReject" || a.BookingStatus == "PackageNotPickUped").ToList();
                foreach (var item in bookings)
                {
                    if (item.PickUpDateTime >= DateTime.Now && item.BookingStatus == "ExecutiveAccept")
                    {
                        item.BookingStatus = "PackagePickUped";
                        _repoBooking.EditInfo(item);
                    }
                    else if (item.PickUpDateTime < DateTime.Now && item.BookingStatus == "ExecutiveAccept")
                    {
                        item.BookingStatus = "PackageNotPickUped";
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
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                return View();
            }
            
        }
        public ActionResult Logout()
        {
            foreach (var key in TempData.Keys.ToList())
            {
                TempData.Remove(key);
            }
            return RedirectToAction("Index", "Home");
        }
        /*// GET: CustomerController/Delete/5
        public ActionResult DeleteCustomerInfo()
        {
            int id = Convert.ToInt32(TempData.Peek("UserID"));
            Customer customer = _repoCustomer.GetById(id);
            return View(customer);
        }
        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCustomerInfo(Customer customer)
        {
            try
            {
                if (customer != null)
                {
                    _repoCustomer.DeleteInfo(customer);
                    return RedirectToAction("Login","User");
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