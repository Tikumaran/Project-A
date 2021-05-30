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
        public AdminController(ILogger<AdminController> logger, IRepo<Customer> repoCustomer, IRepo<DeliveryExecutive> repoExecutive)
        {
            _logger = logger;
            _repoCustomer = repoCustomer;
            _repoExecutive = repoExecutive;
        }

        [HttpGet]
        public IActionResult AdminLogin(User user)
        {
            if (user.UserName == "Admin" && user.Password == "Admin")
            {
                return RedirectToAction("CustomerDetails");
            }
            else
            {
                //return View("alert('Incorrect')");
                return RedirectToAction("Index", "User");
            }
        }
        public ActionResult CustomerDetails()
        {
            List<Customer> customers = _repoCustomer.GetAllInfo().ToList();
            if (customers != null)
                return View(customers);
            else
                return View();
        }
        public ActionResult ExecutiveDetails()
        {
            
           List<DeliveryExecutive> executives = _repoExecutive.GetAllInfo().ToList();
            if (executives != null)
                return View(executives);
            else
                return View();
        }
        public ActionResult CustomerRequests()
        {
            List<Customer> customers = _repoCustomer.GetAllInfo().ToList();
            List<Customer> customer = customers.Where(a => a.IsVerified == "Requested").ToList();
            if (customer.Count() != 0)
                return View(customer);
            else
                //alert box no content();
                return View();
        }
        public ActionResult ExecutiveRequests()
        {
            List<DeliveryExecutive> executives = _repoExecutive.GetAllInfo().ToList();
            List<DeliveryExecutive> executive = executives.Where(a => a.IsVerified == "Requested").ToList();
            if (executive.Count() != 0)
                return View(executive);
            else
                //alert Box no content();
                return View();
        }
        // GET: AdminController/Details/5
        public ActionResult CustomerProfile()
        {
            int id = Convert.ToInt32(TempData.Peek("UserID"));
            Customer customer = _repoCustomer.GetById(id);
            if (customer != null)
                return View(customer);
            return View();
        }
        public ActionResult ExecutiveProfile()
        {
            int id = Convert.ToInt32(TempData.Peek("UserID"));
            DeliveryExecutive executive = _repoExecutive.GetById(id);
            if (executive != null)
                return View(executive);
            return View();
        }

        // GET: AdminController/Edit/5
        //public ActionResult Edit()
        //{
        //    return View();
        //}

        // POST: AdminController/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult EditCustomerReqest(Customer Status)
        {
            int id = Convert.ToInt32(TempData.Peek("ID"));
            Customer customer = _repoCustomer.GetById(id);
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
        [HttpPost]
        public ActionResult EditExecutiveReqest(DeliveryExecutive ExecutiveStatus)
        {
            int id = Convert.ToInt32(TempData.Peek("ID"));
            DeliveryExecutive executive = _repoExecutive.GetById(id);
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
        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
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
