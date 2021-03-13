using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatim_Naloga.ViewComponents
{
    public enum ViewComponents
    {
        NewProductsVC
    }

    [ViewComponent(Name = nameof(ViewComponents.NewProductsVC))]
    public class NewProductsViewComponent: ViewComponent
    {
        
        public NewProductsViewComponent() { 
        
        }

        public async Task<IViewComponentResult> InvokeAsync(int nOfProducts, bool infiniteScroll) {

            //podamo čez število izdelkov, ki ga želimo izpisati v View-u
            ViewData["NumberOfProducts"] = nOfProducts;
            
            // true ali false vrednost ali se naj izpisuje infinite scroll
            ViewData["Infinite"] = infiniteScroll;
            return View();
        }
    }

}
