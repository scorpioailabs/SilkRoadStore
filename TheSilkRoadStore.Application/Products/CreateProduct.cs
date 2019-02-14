using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheSilkRoadStore.Database;
using TheSilkRoadStore.Domain.Models;

namespace TheSilkRoadStore.Application.Products
{
    public class CreateProduct
    {
        private ApplicationDbContext _context;
        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(string Name, string Description, decimal Value)
        {
            _context.Products.Add(new Product
            {
                Name = Name,
                Description = Description,
                Value = Value
            });

            await _context.SaveChangesAsync();
        }
        

    }
}
