using JooleDAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using System.Web.Script.Serialization;
using WebGroupProject.Models;

namespace WebGroupProject
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        TeamAlphaGroupProjectsEntities db = new TeamAlphaGroupProjectsEntities();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public List<JasonTests> getSubCategory(int CategoryID)
        {
            List<tblSubCategory> tblSubs = db.tblSubCategories.ToList();

            List<JasonTests> SubcategoryName = tblSubs.Where(x => x.CategoryID == CategoryID).Select(x => new JasonTests
            {
                SubcategoryID = x.SubCategoryID,
                SubcategoryName = x.SubCategoryName
            }).ToList();

            return SubcategoryName;
        }
    }
}
