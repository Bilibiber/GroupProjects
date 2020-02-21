using JooleBLL;
using JooleBLL.Interface;
using JooleDomain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGroupProject.Controllers
{
    public class LoginController : Controller
    {
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            string DeHashPassword = "";
            con.Open();

            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string SignUpUserName, string SignUpEmail, string SignUpPassword)
        {
            try
            {
                string HashedPassword = PasswordHash.HashPassword(SignUpPassword);
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "Insert Into tblUser Values(@SignUpEmail, @SignUpPassword, @SignUpUserName, @SignUpUserName)";
                command.Parameters.AddWithValue("@SignUpEmail", SignUpEmail);
                command.Parameters.AddWithValue("@SignUpPassword", HashedPassword);
                command.Parameters.AddWithValue("@SignUpUserName", SignUpUserName);
                command.ExecuteNonQuery();
                return View("Index");
            }
            catch(Exception)
            {
                return View("SignUpError");
            }
            
        }
    }
}