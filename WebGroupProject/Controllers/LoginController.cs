using JooleBLL;
using JooleBLL.Interface;
using JooleDomain;
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
            ICustomerBusiness customer = new CustomerBusiness();

           ViewBag.Name = customer.SignUp("guofx@dukes.jmu.edu", "123");

            List<CustomerDominModel> customerDomins = new List<CustomerDominModel>();

            ViewBag.CustomerList = customer.GetAllCustomer();
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public string SignUp()
        {
            return "";
        }
    }
}