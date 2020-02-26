using JooleDAL;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebGroupProject.Models;

namespace WebGroupProject.Controllers
{
    public class ProductsController : Controller
    {
        private NewDataBase DataBase = new NewDataBase();

        [HttpGet]
        public ActionResult ProductResult(int SubCategoryID)
        {
            //Create the dropdown list
            List<tblCategory> categoryList = DataBase.tblCategories.ToList();
            ViewBag.CategoryListName = new SelectList(categoryList, "CategoryID", "CategoryName");

            //Create the productList
            List<tblProduct> tblProductslist = DataBase.tblProducts.ToList();
            List<ProductViewModel> VMlist = tblProductslist.Where(x => x.SubCategoryID == SubCategoryID).Select(x => new ProductViewModel
            {
                Series = x.Series,
                ProductName = x.ProductName,
                Model = x.Model,
                ProductID = x.ProductID
            }).ToList();

            return View(VMlist);
        }

        public JsonResult GetSubCategory(int CategoryID)
        {
            DataBase.Configuration.ProxyCreationEnabled = false;
            List<tblSubCategory> subCategoriesList = DataBase.tblSubCategories.Where(x => x.CategoryID == CategoryID).ToList();
            return Json(subCategoriesList, JsonRequestBehavior.AllowGet);
        }
    }
}