using System;
using System.Collections.Generic;
using System.Text;

namespace TheSilkRoadStore.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderRef { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
