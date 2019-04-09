using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSilkRoadStore.Database;
using TheSilkRoadStore.Domain.Models;

namespace TheSilkRoadStore.Application.ProductsAdmin
{
    public class DeleteProduct
    {
        private ApplicationDbContext _context;
        public DeleteProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(int id)
        {
            var Product = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(Product);
            await _context.SaveChangesAsync();
        }
    }



}
