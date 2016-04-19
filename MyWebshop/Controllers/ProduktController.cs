using MyWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebshop.Controllers
{
    public class ProduktController : Controller
    {
        // GET: Produkt

        public ActionResult Index()
        {
            var produkter = (List<Produkter>)Session["Produkter"];


            //searches the item

            if (!String.IsNullOrEmpty(Request["search"]))
            {
                var products = from p in produkter
                               where p.Namn.ToLower().Contains(Request["search"].ToLower())
                               select p;

                List<Produkter> searchList = new List<Produkter>();

                foreach (var item in products)
                {
                    searchList.Add(item);
                }

                return View(searchList);
            }

            return View(produkter);
        }

        // public ActionResult Edit(string prodNamn)
        //    {
        //       var produkter = (List<Produkter>)Session["Produkter"];

        //       var produkt = (from p in produkter
        //                          where p.Namn == prodNamn
        //                          select p).FirstOrDefault();          

        //      return View(produkt);
        //    }

        //[HttpPost]
        //public ActionResult Edit(Produkter prdkt)
        //{
        //    var produkter = (List<Produkter>)Session["Produkter"];



        //    return RedirectToAction("Index");
        //}

    }
    
}