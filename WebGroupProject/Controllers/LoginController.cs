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
        public ActionResult Login(string Email, string Password)
        {
            string HashedPassword = "";
            con.Open();
            SqlCommand sql = new SqlCommand();
            sql.Connection = con;
            sql.CommandText = "Select UserPassword from tblUser where UserEmail=@Email";
            sql.Parameters.AddWithValue("@Email", Email);
            SqlDataReader reader;
            reader = sql.ExecuteReader();
            if (reader.Read()) 
            {
                HashedPassword = reader.GetString(0);
                if (PasswordHash.ValidatePassword(Password, HashedPassword))
                {
                    return RedirectToAction("Search", "Search");
                }
                else
                {
                    return View("LoginError");
                }
            }
            else
            {
                return View("LoginError");
            }
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