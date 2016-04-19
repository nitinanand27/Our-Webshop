using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebshop.Models
{
    public class OrderRow
    {
        public Produkter Product { get; set; }
        public int Amount { get; set; }     //Antal produkter beställt 
        public decimal SellingPrice { get; set; }
        public decimal Total { get { return SellingPrice * Amount; } }
    }
} 