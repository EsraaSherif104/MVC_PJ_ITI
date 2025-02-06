using Microsoft.AspNetCore.Mvc;
using MVC_ITI.Models;

namespace MVC_ITI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductBL productBL = new ProductBL();
            List<Product> products = productBL.GetALL();
            return View("Index",products);
        }
        public IActionResult Details(int id)
        {
            ProductBL productBL = new ProductBL();
            Product products = productBL.GetById(id);

            if (products == null)
            {
                return RedirectToAction("Index"); 
            }
            return View("Details", products);
        }
    }
}
