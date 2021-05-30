using DeliveryBookingProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingProject.Controllers
{
    public class UserController : Controller
    {
        private ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;

        }
        // GET: UserController
        public IActionResult Index()
        {
            return RedirectToAction("Login");
        }
        [HttpGet]
        public ActionResult Login()
        {
            try
            {
                User user = new User();
                if (TempData["UserName"] !=null)
                {
                    user.UserName = TempData.Peek("UserName").ToString();
                    return View(user);
                }
                else
                {
                    return View(user);
                }
            }
            catch(Exception e)
            {
                return RedirectToAction("Error", e.Message);
            }
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (user.UserName == "Admin")
            {
                return RedirectToAction("AdminLogin", "Admin", user);
            }
            else if (user.UserName != "Admin" && user.UserType == "Customer")
            {
                //return(ActionResult)_customer.CustomerLogin(user);
                return RedirectToAction("CustomerLogin", "Customer", user);
            }
            else if (user.UserName != "Admin" && user.UserType == "Executive")
            {
                //return(ActionResult)_customer.CustomerLogin(user);
                return RedirectToAction("ExecutiveLogin", "Executive", user);
            }
            return View();
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
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

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
