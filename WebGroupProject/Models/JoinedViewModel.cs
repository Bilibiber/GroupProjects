using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGroupProject.Models
{
    public class JoinedViewModel
    {
        public List<CategoaryListVM> categoaryListVMs { get; set; }
        public CategoaryListVM CategoaryListVM { get; set; }

        public ProductViewModel ProductViewModel { get; set; }
    }
}