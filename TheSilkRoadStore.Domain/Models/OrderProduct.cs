using System;
using System.Collections.Generic;
using System.Text;

namespace TheSilkRoadStore.Domain.Models
{
    public class OrderProduct
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
