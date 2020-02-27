using JooleDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGroupProject.Models;

namespace WebGroupProject.Controllers
{
    
    public class CompareController : Controller
    {
        private NewDataBase DataBase = new NewDataBase();
        // GET: Compare
        [HttpPost]
        public ActionResult Compare(List<int> data)
        {
            TempData.Keep();
            int[] arr = data.ToArray();
            List<tblProduct> tblProducts =DataBase.tblProducts.ToList();
            List<ProductViewModel> ProductVM = tblProducts.Where(x => arr.Contains(x.ProductID)).Select(x => new ProductViewModel
            {
                ProductID = x.ProductID,
                ProductName =x.ProductName,
                Series=x.Series,
                Model=x.Model,
                Manufacturer=x.Manufacturer,
                Use_Type=x.Use_Type,
                Application=x.Application,
                Mounting_Location=x.Mounting_Location,
                Model_Year=x.Model_Year
            }).ToList();

            TempData["ProductVM"] = ProductVM;
            return RedirectToAction("Page");
        }
        public ActionResult Page()
        {
            TempData.Keep();
            var ProductVM = TempData["ProductVM"] as List<ProductViewModel>;
            return View(ProductVM);
        }
        
    }
}