using JooleBusinessLogicLayer;
using JooleBusinessLogicLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGroupProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            IJooleCustomerLogin customerLogin = new JooleCustomerLogin();
            ViewBag.test = customerLogin.CustomerLogin("guofx@dukes.jmu.edu", "123");

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
    }
}