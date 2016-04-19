using MyWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebshop.Controllers
{
    public class KundvagnController : Controller
    {
        // GET: Kundvagn
        public ActionResult Index()
        {
            var cart = (Cart)Session["Cart"];

            if (Request["product"] != null)
            {
                var produkter = (List<Produkter>)Session["Produkter"];

                var product = (from p in produkter
                               where p.Namn == Request["product"]
                               select p).FirstOrDefault();

                var existingItem = cart.OrderRows.Where(x => x.Product.Namn == Request["product"]).FirstOrDefault();

                if (existingItem == null)
                {
                    cart.OrderRows.Add(new OrderRow { Product = product, SellingPrice = product.Pris, Amount = 1 });
                    Session["CartCount"] = cart.itemCount;
                }

                else
                {
                    existingItem.Amount += 1;
                    Session["CartCount"] = cart.itemCount;
                }
            }           

            return View(cart);
        }

        public ActionResult Delete()
        {
            var cart = (Cart)Session["Cart"];
            var test = Request["rowToDelete"];
            var rowToDelete = cart.OrderRows.Where(r => r.Product.Namn == Request["rowToDelete"]).FirstOrDefault();

            if (rowToDelete != null)
            {
                cart.OrderRows.Remove(rowToDelete);
                Session["CartCount"] = cart.itemCount;
            }

            return View("Index", cart);
        }

        //reads automatically parameters with exact names
        public ActionResult UpdateAmount(int amount, string productName)
        {
            var cart = (Cart)Session["Cart"];

            var orderRowToUpdate = cart.OrderRows.Where(r => r.Product.Namn == productName).FirstOrDefault();

            if (orderRowToUpdate != null)
            {
                orderRowToUpdate.Amount = amount;
                Session["CartCount"] = cart.itemCount;
            }

            return View("Index", cart);
        }

    }
}