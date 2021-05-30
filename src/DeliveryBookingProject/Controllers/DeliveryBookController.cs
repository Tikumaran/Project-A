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
        private IRepo<Customer> _repoCustomer;
        private IRepo<DeliveryExecutive> _repoExecutive;
        private IRepo<DeliveryBooking> _repoBooking;
        private ILogger<DeliveryBookController> _logger;
        public DeliveryBookController(IRepo<DeliveryBooking> repoBooking,IRepo<Customer> repoCustomer, IRepo<DeliveryExecutive> repoExecutive, ILogger<DeliveryBookController> logger)
        {
            _repoCustomer = repoCustomer;
            _repoExecutive = repoExecutive;
            _repoBooking = repoBooking;
            _logger = logger;
        }
        [HttpGet]
        public ActionResult AddBooking()
        {
            return View();
        }
        public double CalculatePrice(double kg)
        {
            double PricePerKg = kg * 100, petrol = 200.0,gst = PricePerKg * (2.5 / 100);
            double price = PricePerKg + petrol + gst;
            return price;
        }
        [HttpPost]
        public ActionResult AddBooking(DeliveryBooking booking)
        {
            
            int Cust_id = Convert.ToInt32(TempData.Peek("UserID"));
            int Exec_id = Convert.ToInt32(TempData.Peek("ExecutiveID"));
            booking.CustomerId = Cust_id;
            booking.ExecutiveId = Exec_id;
            booking.OrderDate = DateTime.Now;
            DeliveryBooking Records = _repoBooking.GetAllInfo().SingleOrDefault(a => a.CustomerId == Cust_id && a.PickUpDateTime == booking.PickUpDateTime &&
                                                            a.BookingStatus == "CustomerRequested" || a.BookingStatus == "ExecutiveAccepted");
            if (Records == null)
            {
                booking.BookingStatus = "CustomerRequest";
                _repoBooking.AddInfo(booking);
                TempData["ExeId"] = Exec_id;
                TempData["CustId"] = Cust_id;
                return RedirectToAction("BookingStatus", "Customer");
            }
            else
            {
                return View(Records);//check
            }
        }

        // GET: DeliveryBookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeliveryBookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeliveryBookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeliveryBookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeliveryBookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeliveryBookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeliveryBookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
