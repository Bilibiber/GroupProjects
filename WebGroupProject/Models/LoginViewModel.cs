using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGroupProject.Models
{
    public class LoginViewModel
    {
        public int UserID { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
    }
}