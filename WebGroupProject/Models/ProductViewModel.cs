using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGroupProject.Models
{
    public class ProductViewModel
    {
        public string Accessories { get; set; }
        public int ProductID { get; set; }
        public string Manufacturer { get; set; }
        public string ProductName { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public Nullable<System.DateTime> Model_Year { get; set; }
        public string FeaturedTag { get; set; }
        public string Use_Type { get; set; }
        public string Application { get; set; }
        public string Mounting_Location { get; set; }
        public string MinAirFlow { get; set; }
        public Nullable<int> SubCategoryID { get; set; }

        public string MaxAirfow { get; set; }
    }
}