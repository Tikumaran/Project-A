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
    public class DeliveryBookController : Controller
    {
        private IRepo<DeliveryBooking> _repoBooking;
        private ILogger<DeliveryBookController> _logger;
        public DeliveryBookController(IRepo<DeliveryBooking> repoBooking,IRepo<Customer> repoCustomer, IRepo<DeliveryExecutive> repoExecutive, ILogger<DeliveryBookController> logger)
        {
            _repoBooking = repoBooking;
            _logger = logger;
        }
        [HttpGet("{id}/{Name}")]
        public ActionResult AddBooking(int Id,string Name)
        {
            DeliveryBooking delivery = new DeliveryBooking();
            delivery.ExecutiveId = Id;
            TempData["Exce_Name"] = Name;
            return View(delivery);
        }
        public double CalculatePrice(double kg)
        {
            double PricePerKg = kg * 100, petrol = 200.0,gst =  0.02 ;
            double price = PricePerKg + petrol;
            gst = price * gst;
            price = price + gst;
            return price;
        }
        [HttpPost("{id}/{Name}")]
        public ActionResult AddBooking(DeliveryBooking booking)
        {
            try
            {
                int Cust_id = Convert.ToInt32(TempData.Peek("UserID"));
                booking.CustomerId = Cust_id;
                booking.OrderDate = DateTime.Now;
                DeliveryBooking Records = _repoBooking.GetAllInfo().SingleOrDefault(a => a.CustomerId == Cust_id && a.PickUpDateTime == booking.PickUpDateTime &&
                                                                a.BookingStatus == "CustomerRequested" || a.BookingStatus == "ExecutiveAccepted");// checking Whether they Have Same Day Delivery in Process
                if (ModelState.IsValid && Records == null)
                {
                    booking.BookingStatus = "CustomerRequest";
                    booking.Price = CalculatePrice(booking.WeightOfPackage);
                    _repoBooking.AddInfo(booking);
                    TempData["CustId"] = Cust_id;
                    return RedirectToAction("BookingStatus", "Customer");
                }
                else
                {
                    return View(Records);//check
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return View();
        }
    }
}
