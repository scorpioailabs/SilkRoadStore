using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheSilkRoadStore.Database;
using TheSilkRoadStore.Domain.Models;

namespace TheSilkRoadStore.Application.ProductsAdmin
{
    public class UpdateProduct
    {
        private ApplicationDbContext _context;
        public UpdateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(ProductViewModel vm)
        {

            await _context.SaveChangesAsync();
        }
        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
    }



}
