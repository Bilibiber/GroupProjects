using JooleDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JooleBLL.Interface
{
    public interface ICustomerBusiness
    {
        string SignUp(string Email, string Password);
        List<CustomerDominModel> GetAllCustomer();

    }
}
