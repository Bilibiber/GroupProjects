using JooleBusinessLogicLayer.Interface;
using JooleDAL;
using JooleDomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JooleBusinessLogicLayer
{
    public class JooleCustomerLogin : IJooleCustomerLogin
    {
        public string CustomerLogin(string Email, string Password)
        {
            string pass = "Pass";
            MyConnectionString DB = new MyConnectionString();
           
            return pass;
        }

      
    }
}
