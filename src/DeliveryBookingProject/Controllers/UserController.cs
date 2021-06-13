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
                TempData["ErrMsg"] = e.Message;
                return RedirectToAction("Error");
            }
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (user.UserName == "Apple" && user.UserType== null)
            {
                return RedirectToAction("AdminLogin", "Admin", user);
            }
            else if (ModelState.IsValid)
            {
                if (user.UserName != "Apple" && user.Password != "Apple" && user.UserType == "Customer")
                {
                    return RedirectToAction("CustomerLogin", "Customer", user);
                }
                else if (user.UserName != "Apple" && user.Password != "Apple" && user.UserType == "Executive")
                {
                    return RedirectToAction("ExecutiveLogin", "Executive", user);
                }
                else
                {
                    TempData["ErrMsg"] = "Incorrect UserName or Password";
                    return RedirectToAction("Error","User");
                }
            }
            else
            {
                return View(user);
            }
        }        
        public ActionResult Error()
        {
            return View();
        }
    }
}
