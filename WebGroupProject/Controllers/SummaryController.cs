using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WebGroupProject.Models;

namespace WebGroupProject.Controllers
{
    public class SummaryController : Controller
    {
        // GET: Summary
        public ActionResult Index(int ProductID)
        {
            TempData.Keep();
            //int s1 = 4;
            string CS = "Server=192.168.1.5;Database=TeamAlphaGroupProjects;User Id=T_User1;Password=us1;";
            SqlConnection con = new SqlConnection(CS);

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from tblProductsDetals join tblProducts on tblProducts.ProductID = tblProductsDetals.ProductID and tblProducts.ProductID = @pid", con);


            cmd.Parameters.AddWithValue("@pid", ProductID);
            DataTable dtProduct = new DataTable("Product");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtProduct);
            DataSet ds = new DataSet();
            ds.Tables.Add(dtProduct);


            con.Close();
            /*          
            SummaryContext summaryContext = new SummaryContext();
            Summary summary = summaryContext.Products.Single(x => x.Product_ID == s1);
            */

            return View(ds);
        }

        /*public ActionResult Search(int Search = 4)
        {
            string CS = "Server=192.168.1.5;Database=TeamAlphaGroupProjects;User Id=T_User1;Password=us1;";
            SqlConnection con = new SqlConnection(CS);

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from tblProducts where ProductID = @pid", con);


            cmd.Parameters.AddWithValue("@pid", Search);
            DataTable dtProduct = new DataTable("Product");
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dtProduct);
            DataSet ds1 = new DataSet();
            ds1.Tables.Add(dtProduct);

            con.Close();


            return View(ds1);
        }*/

        public ActionResult Search(string Search)
        {

            string CS = "Server=192.168.1.5;Database=TeamAlphaGroupProjects;User Id=T_User1;Password=us1;";
            SqlConnection con = new SqlConnection(CS);

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from tblProducts where ProductName = @name", con);

            cmd.Parameters.AddWithValue("@name", Search);
            DataTable dtProduct = new DataTable("Product");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtProduct);
            DataSet ds = new DataSet();
            ds.Tables.Add(dtProduct);


            con.Close();

            return View(ds);
        }

    }
}

