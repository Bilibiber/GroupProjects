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
            return "Worked";
        }

        public List<CustomerDominModel> GetAllCustomer()
        {
            MyConnectionString dbcontext = new MyConnectionString();
            List<CustomerDominModel> CustomerList = dbcontext.tblUsers.Select(m=>new CustomerDominModel {UserEmail=m.UserEmail, UserPassword=m.UserPassword, UserID=m.UserID, UserFirstName=m.UserFirstName,UserLastName=m.UserLastName}).ToList();
            return CustomerList;
        }
    }
}
