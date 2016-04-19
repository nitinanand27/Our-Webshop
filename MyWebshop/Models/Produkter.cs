using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebshop.Models
{
    public class Produkter
    {
        public int ID { get; set; }
        public string Namn { get; set; }
        public decimal Pris { get; set; }
        public int Antal { get; set; }
        public string Image { get; set; }

    }
}