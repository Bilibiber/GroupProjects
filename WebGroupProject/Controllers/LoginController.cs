using JooleBLL;
using JooleBLL.Interface;
using JooleDAL;
using JooleDomain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGroupProject.Models;

namespace WebGroupProject.Controllers
{
    public class LoginController : Controller
    {
        NewDataBase db = new NewDataBase();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string Email, string Password)
        {
            string HashedPassword = db.tblUsers.SingleOrDefault(x => x.UserEmail == Email)?.UserPassword.ToString();
            if (PasswordHash.ValidatePassword(Password, HashedPassword))
            {
                return RedirectToAction("Search", "Search");
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

                bool CheckEmail = db.tblUsers.Any(x => x.UserEmail == SignUpEmail);
                if (CheckEmail == false)
                {
                    tblUser user = new tblUser();
                    user.UserEmail = SignUpEmail;
                    user.UserPassword = HashedPassword;
                    user.UserName = SignUpUserName;

                    db.tblUsers.Add(user);
                    db.SaveChanges();
                    return View("Index");
                }
                else
                {
                    return View("SignUpError");
                }
            }
            catch (Exception)
            {
                return View("Index");
            }
        }
    }
}