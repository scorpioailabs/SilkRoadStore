using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheSilkRoadStore.Database;

namespace TheSilkRoadStore.Application.Products
{
    public class GetProducts
    {
        private ApplicationDbContext _ctx;

        public GetProducts(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Do()
        {
            _ctx.Products.ToList();
        }
    }
}
