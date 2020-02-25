using JooleDAL;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WebGroupProject.Controllers
{
    public class ProductsController : Controller
    {
        private NewDataBase DataBase = new NewDataBase();

        // GET: Products
        [HttpGet]
        public ActionResult ProductResult()
        {
            List<tblCategory> categoryList = DataBase.tblCategories.ToList();
            ViewBag.CategoryListName = new SelectList(categoryList, "CategoryID", "CategoryName");

            // fill data to the view 
            // work from here.
          
            return View("ProductResult");
        }

        public JsonResult GetSubCategory(int CategoryID)
        {
            DataBase.Configuration.ProxyCreationEnabled = false;
            List<tblSubCategory> subCategoriesList = DataBase.tblSubCategories.Where(x => x.CategoryID == CategoryID).ToList();
            return Json(subCategoriesList, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult SearchGoGo()
        {
            return RedirectToAction("ProductResult", "Products");
        }
        public ActionResult Test()
        {
            return View();
        }
    }
}