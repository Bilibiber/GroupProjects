using JooleDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebGroupProject.Models;

namespace WebGroupProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFTest" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WCFTest.svc or WCFTest.svc.cs at the Solution Explorer and start debugging.
    public class WCFTest : IWCFTest
    {
        TeamAlphaGroupProjectsEntities db = new TeamAlphaGroupProjectsEntities();
        public void DoWork()
        {
        }
        public List<JasonTest> getSubCategory(int CategoryID)
        {
            List<tblSubCategory> tblSubs = db.tblSubCategories.ToList();

            List<JasonTest> SubcategoryName = tblSubs.Where(x => x.CategoryID == CategoryID).Select(x => new JasonTest
            {
                SubcategoryID = x.SubCategoryID,
                SubcategoryName = x.SubCategoryName
            }).ToList();

            return SubcategoryName;
        }
    }
}
