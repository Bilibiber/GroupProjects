using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGroupProject.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult ProductResult()
        {
            return View("ProductResult");
        }
    }
}