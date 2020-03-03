using JooleDAL;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebGroupProject.Models;

namespace WebGroupProject.Controllers
{
    public class ProductsController : Controller
    {
        private TeamAlphaGroupProjectsEntities DataBase = new TeamAlphaGroupProjectsEntities();

        [HttpPost]
        public ActionResult ProductResult(int SubCategoaryID)
        {
            TempData.Keep();
            //Create the productList
            List<tblProduct> tblProductslist = DataBase.tblProducts.ToList();
            List<ProductViewModel> VMlist = tblProductslist.Where(x => x.SubCategoryID == SubCategoaryID).Select(x => new ProductViewModel
            {
                Series = x.Series,
                ProductName = x.ProductName,
                Model = x.Model,
                ProductID = x.ProductID
                
            }).ToList();

            return View(VMlist);
        }
    }
}