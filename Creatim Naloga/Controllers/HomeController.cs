using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Creatim_Naloga.Models;

namespace Creatim_Naloga.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult NewProducts()
        {
            //kliči View Component New Products.. HTML koda v Views > Shared > Components > New ProductsVC
            // kot parametre pošljemo čez število izdelkov, ki jih želimo izpisati in ali želimo aktivirati infinite scroll
            // ta komponenta se kliče kadar ne spreminjamo filtra. Torej, ko scrollamo do dna strani, ta ViewComponent izpiše 4 nove izdelke, v neskončnost
            return ViewComponent(nameof(Creatim_Naloga.ViewComponents.ViewComponents.NewProductsVC), new { nOfProducts = 4, infiniteScroll=true });
        }

        public IActionResult SimulateProducts(int nOfProducts)
        {
            return ViewComponent(nameof(Creatim_Naloga.ViewComponents.ViewComponents.NewProductsVC), new { nOfProducts= nOfProducts, infiniteScroll=false });
        }
    }
}
