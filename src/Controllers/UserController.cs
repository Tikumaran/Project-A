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
    }
}
