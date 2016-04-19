using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebshop.Models
{
    public class Cart
    {
        public List<OrderRow> OrderRows { get; set; }
        public decimal Total { get { return OrderRows.Sum(x => x.Total); } }

        public int itemCount { get {return OrderRows.Sum(x => x.Amount); } }

        public Cart()
        {
            OrderRows = new List<OrderRow>();
        }
    }
}