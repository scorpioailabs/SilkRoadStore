using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheSilkRoadStore.Application.CreateProducts;
using TheSilkRoadStore.Application.GetProducts;
using TheSilkRoadStore.Database;

namespace TheSilkRoadStore.UI.Pages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _ctx;

        public IndexModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;

        }
        
        [BindProperty]
        public Application.CreateProducts.ProductViewModel Product { get; set; } 

        public IEnumerable<Application.GetProducts.ProductViewModel> Products { get; set; }


        public void OnGet()
        {
            Products = new GetProducts(_ctx).Do();
        }

        public async Task<IActionResult> OnPost()
        {
            await new CreateProduct(_ctx).Do(Product);

            return RedirectToPage("Index");
        }
    }
}
