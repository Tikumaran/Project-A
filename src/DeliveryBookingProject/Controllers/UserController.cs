using DeliveryBookingProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");   //from Executive Controller
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");   //from Admin Controller
            }
            else
            {
                try
                {
                    User user = new User();
                    if (TempData["UserName"] != null)
                    {
                        user.UserName = TempData.Peek("UserName").ToString();
                        return View(user);
                    }
                    else
                    {
                        return View(user);
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    TempData["ErrMsg"] = e.Message;
                    return RedirectToAction("Error");
                }                                               //from User or Home Controller
            }
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (TempData.Count() > 1 && TempData.Count() >= 3)
            {
                return RedirectToAction("Home", "Customer");    //from Customer Controller
            }
            else if (TempData.Count() > 1 && TempData.Count() == 2)
            {
                return RedirectToAction("Home", "Executive");   //from Executive Controller
            }
            else if (TempData.Count() == 1)
            {
                return RedirectToAction("Home", "Admin");   //from Admin Controller
            }
            else
            {
                if (user.UserName == "Apple" && user.UserType == null)
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
                        return RedirectToAction("Error", "User");
                    }
                }
                else
                {
                    return View(user);
                }                                                   //from User or Home Controller
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
