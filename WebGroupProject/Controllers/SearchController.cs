using JooleDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGroupProject.Controllers
{
    public class SearchController : Controller
    {
        NewDatabase DataBase = new NewDatabase();
        // GET: Search
        public ActionResult Search()
        {
          
            //var CategoryList = DataBase.tblCategories.ToList();
            //SelectList List = new SelectList(CategoryList, "CategoryID", "CategoryName");
            //ViewBag.CategoryListName = List;

            List<tblCategory> categoryList = DataBase.tblCategories.ToList();
            ViewBag.CategoryListName = new SelectList(categoryList, "CategoryID", "CategoryName");


            return View();
        }
        public JsonResult GetSubCategory(int CategoryID)
        {
            DataBase.Configuration.ProxyCreationEnabled = false;
            List<tblSubCategory> subCategoriesList = DataBase.tblSubCategories.Where(x => x.CategoryID == CategoryID).ToList();
            return Json(subCategoriesList, JsonRequestBehavior.AllowGet);
        }
        public ActionResult SearchGo()
        {
            return View();
        }
    }
}