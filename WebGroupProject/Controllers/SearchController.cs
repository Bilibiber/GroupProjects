using JooleDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGroupProject.Controllers
{
    public class SearchController : Controller
    {
        NewDataBase DataBase = new NewDataBase();
        // GET: Search
        [HttpGet]
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
        //public ActionResult SearchGo(string SubCategoryID)
        //{
        //    int SubID = Convert.ToInt32(SubCategoryID);
        //    var Products = DataBase.tblProducts.Where(a => a.SubCategoryID == SubID);


        //    string CS = "Server=192.168.1.5;Database=TeamAlphaGroupProjects;User Id=T_User1;Password=us1;";
        //    SqlConnection con = new SqlConnection(CS);

        //    con.Open();

        //    SqlCommand cmd = new SqlCommand("select * from tblProducts where SubCategoryID = @SubCategoryID", con);

        //    cmd.Parameters.AddWithValue("@SubCategoryID", SubCategoryID);
        //    DataTable dtProduct = new DataTable("Product");
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dtProduct);
        //    DataSet ds = new DataSet();
        //    ds.Tables.Add(dtProduct);
        //    con.Close();

        //    return RedirectToAction("ProductResult", "Products", new { DataSet=ds });
        //}
    }
}