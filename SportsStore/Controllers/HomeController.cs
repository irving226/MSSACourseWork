using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;

namespace SportsStore.Controllers
{
    public class HomeController: Controller
    {

        //fields and properties

        //here's the repository(interface) 
        private IProductRepository _repository;

        //constructors 
        public HomeController(IProductRepository repository) //Dependency Injection
                                                               //Inversion of Control
        {
            _repository = repository;
        }
   

        //methods

        public IActionResult Index()
        {

            //1. go to database and get data out
            IQueryable<Product> allProducts = _repository.GetAllProducts();

            //2. Send taht data into the view

            return View(allProducts);
        }
    }
}
