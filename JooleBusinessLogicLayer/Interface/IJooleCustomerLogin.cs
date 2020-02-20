using JooleDomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JooleBusinessLogicLayer.Interface
{
    public interface IJooleCustomerLogin
    {
        string CustomerLogin(string Email, string Password);
        List<CustomerDominModel> GetAllCustomer();
    }
}
