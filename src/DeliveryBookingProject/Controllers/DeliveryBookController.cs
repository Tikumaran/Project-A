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
            DeliveryBooking delivery = new DeliveryBooking();
            delivery.ExecutiveId = Id;
            DeliveryExecutive executive = _repoExecutive.GetById(Id);
            TempData["Exce_Name"] = executive.ExecutiveName;
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
        [HttpPost("{id}")]
        public ActionResult AddBooking(DeliveryBooking booking)
        {
            try
            {
                int Cust_id = Convert.ToInt32(TempData.Peek("UserID"));
                booking.CustomerId = Cust_id;
                booking.OrderDate = DateTime.Today;
                List<DeliveryBooking> Records = _repoBooking.GetAllInfo().Where(a => a.CustomerId == Cust_id && a.PickUpDateTime.Date == booking.PickUpDateTime.Date).ToList();// checking Whether they Have Same Day on Delivery (in Process-- && a.BookingStatus.Equals(a.BookingStatus == "CustomerRequest" || a.BookingStatus == "ExecutiveAccept")
                if (ModelState.IsValid)
                {
                    if(Records.Count == 0)
                    {
                        booking.BookingStatus = "CustomerRequest";
                        booking.Price = CalculatePrice(booking.WeightOfPackage);
                        _repoBooking.AddInfo(booking);
                        TempData["CustId"] = Cust_id;
                        return RedirectToAction("BookingStatus", "Customer");
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
                _logger.LogDebug(e.Message);
            }
            return View();
        }
        
    }
}
