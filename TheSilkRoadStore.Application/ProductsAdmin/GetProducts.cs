using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheSilkRoadStore.Database;

namespace TheSilkRoadStore.Application.ProductsAdmin   
{
    public class GetProducts
    {
        private ApplicationDbContext _ctx;

        public GetProducts(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<ProductViewModel> Do() =>
            _ctx.Products.ToList().Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,              
                Value =x.Value,  //1010.50 =1,010.50 => £1,010.50)
            });
        public class ProductViewModel
        {
            public int Id { get; set; } 
            public string Name { get; set; }
            public decimal Value { get; set; }
        }
    }



}
