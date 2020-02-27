using JooleDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGroupProject.Models;

namespace WebGroupProject.Controllers
{
    public class SearchController : Controller
    {
        NewDataBase DataBase = new NewDataBase();
        // GET: Search
        [HttpGet]
        public ActionResult Search()
        {          
            List<tblCategory> categoryList = DataBase.tblCategories.ToList();
            TempData["CategoryListName"]  = new SelectList(categoryList, "CategoryID", "CategoryName");
            TempData.Keep();
            return View();
        }
        public JsonResult GetSubCategory(int CategoryID)
        {
            DataBase.Configuration.ProxyCreationEnabled = false;
            List<tblSubCategory> subCategoriesList = DataBase.tblSubCategories.Where(x => x.CategoryID == CategoryID).ToList();
            return Json(subCategoriesList, JsonRequestBehavior.AllowGet);
        }
    }
}