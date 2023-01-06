using InvMgmt_MVC_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvMgmt_MVC_App.Controllers
{
    public class ProductsController : Controller
    {
        private readonly InvMgmtDbContext dbContext;

        public ProductsController(InvMgmtDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {

            return View(dbContext.Products);
        }

        public IActionResult CreateProduct()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
