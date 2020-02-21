using JooleBLL.Interface;
using JooleDAL;
using JooleDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JooleBLL
{
    public class CustomerBusiness : ICustomerBusiness
    {
        public List<CustomerDominModel> GetAllCustomer()
        {
            List<CustomerDominModel> list = new List<CustomerDominModel>();
            list.Add(new CustomerDominModel { CustomerEmail = "guofx@dukes.jmu.edu", CustomerPassword = "123456", CustomerUserName = "guofx", CustomerID = "1" });
            return list;
        }

        public string SignUp(string Email, string Password)
        {
            TeamAlphaGroupProjectsEntities Database = new TeamAlphaGroupProjectsEntities();
            return "Fan Guo" + Email;
        }
    }
}
