using JooleDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebGroupProject.Models;

namespace WebGroupProject.Controllers
{
    public class ProductsController : Controller
    {
        private TeamAlphaGroupProjectsEntities DataBase = new TeamAlphaGroupProjectsEntities();

        [HttpPost]
        public ActionResult ProductResult(int SubCategoaryID)
        {
            TempData.Keep();

            List<tblProduct> tblProductslist = DataBase.tblProducts.ToList();
            List<ProductViewModel> VMlist = tblProductslist.Where(x => x.SubCategoryID == SubCategoaryID).Select(x => new ProductViewModel
            {
                Series = x.Series,
                ProductName = x.ProductName,
                Model = x.Model,
                ProductID = x.ProductID,
                MaxAirfow = x.tblProductsDetail.MaxFanSpeed,
                MinAirFlow = x.tblProductsDetail.MinFanSpeed
            }).ToList();

            TempData["SubID"] = SubCategoaryID;

            return View(VMlist);
            //Create the productList
        }

        public ActionResult ProductResultFilter(int data)
        {
            int SubCategoryID = Convert.ToInt32(TempData["SubID"]);
            List<tblProduct> tblProductslist = DataBase.tblProducts.ToList();
            List<ProductViewModel> VMlist = tblProductslist.Where(x => x.SubCategoryID == SubCategoryID && x.tblProductsDetail.MinFanSpeed>data ).Select(x => new ProductViewModel
            {
                Series = x.Series,
                ProductName = x.ProductName,
                Model = x.Model,
                ProductID = x.ProductID,
                MaxAirfow = x.tblProductsDetail.MaxFanSpeed,
                MinAirFlow = x.tblProductsDetail.MinFanSpeed
            }).ToList();

            TempData["SelectedList"] = VMlist;

            return RedirectToAction("ProductResult");
        }

        public ActionResult ProductResult()
        {
            List<ProductViewModel> SelectedVMlist = TempData["SelectedList"] as List<ProductViewModel>;
            return View(SelectedVMlist);
        }
    }
}