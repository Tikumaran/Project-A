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
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class DeliveryBookController : Controller
    {
        private IRepo<DeliveryBooking> _repoBooking;
        private IRepo<Customer> _repoCustomer;
        private IRepo<DeliveryExecutive> _repoExecutive;
        private ILogger<DeliveryBookController> _logger;
        public DeliveryBookController(IRepo<DeliveryBooking> repoBooking,IRepo<Customer> repoCustomer, IRepo<DeliveryExecutive> repoExecutive, ILogger<DeliveryBookController> logger)
        {
            _repoBooking = repoBooking;
            _repoCustomer = repoCustomer;
            _repoExecutive = repoExecutive;
            _logger = logger;
        }
        [HttpGet("{id}")]
        public ActionResult AddBooking(int Id)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                DeliveryExecutive executive = _repoExecutive.GetById(Id);
                if(executive!= null && executive.City == TempData.Peek("City").ToString())
                {
                    TempData["Exce_Name"] = executive.ExecutiveName;
                    DeliveryBooking delivery = new DeliveryBooking();
                    delivery.ExecutiveId = Id;
                    return View(delivery);
                }else if(executive == null)
                {
                    TempData["Msg"] = "No Executives";
                    return RedirectToAction("Error", "Customer");
                }
                else
                {
                    TempData["Msg"] = "Selecting Invalid Executive";
                    return RedirectToAction("Error", "Customer");
                }                                                //from Customer Controller
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
        public double CalculatePrice(double kg)
        {
            double PricePerKg = kg * 100, petrol = 200.0,gst =  0.02 ;
            double price = PricePerKg + petrol;
            gst = price * gst;
            price = price + gst;
            return price;
        }
        [HttpPost("{id}")]
        public ActionResult AddBooking(DeliveryBooking booking)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                try
                {
                    int Cust_id = Convert.ToInt32(TempData.Peek("UserID"));
                    booking.CustomerId = Cust_id;
                    booking.OrderDate = DateTime.Today;
                    List<DeliveryBooking> Records = _repoBooking.GetAllInfo().Where(a => a.CustomerId == Cust_id && a.PickUpDateTime.Date == booking.PickUpDateTime.Date).ToList();// checking Whether they Have Same Day on Delivery (in Process-- && a.BookingStatus.Equals(a.BookingStatus == "CustomerRequest" || a.BookingStatus == "ExecutiveAccept")
                    if (ModelState.IsValid)
                    {
                        if (Records.Count == 0)
                        {
                            booking.BookingStatus = "CustomerRequest";
                            booking.Price = CalculatePrice(booking.WeightOfPackage);
                            bool result = _repoBooking.AddInfo(booking);
                            if (result == true)
                            {
                                TempData["BSuccess"] = "BookingAdded";
                                TempData["CustId"] = Cust_id;
                                return View();
                            }
                            else
                            {
                                TempData["Msg"] = "Not BookingAdded";
                                return RedirectToAction("Error", "Customer");
                            }
                        }
                        else
                        {
                            TempData["Msg"] = "Booking Is Exists";
                            return RedirectToAction("Error", "Customer");
                        }
                    }
                    else
                    {
                        return View(Records);//check
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    TempData["Msg"] = "Booking Is IN Error Check Log";
                    return RedirectToAction("Error", "Customer");
                }                                                 //from Customer Controller
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
        
    }
}
