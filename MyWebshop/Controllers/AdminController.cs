using MyWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MyWebshop.Controllers
{
    [Authorize(Users = "admin@admin.com")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        
        public ActionResult Manage()
        {
            var produkter = (List<Produkter>)Session["Produkter"];
            return View(produkter);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Produkter produkt)
        {
            var products = (List<Produkter>)Session["Produkter"];

            if (ModelState.IsValid)
            {
                products.Add(produkt);

                return RedirectToAction("Manage");
            }
            else
            {
                return View(produkt);
            }
        }

        public ActionResult Edit(int ID)
        {
            var products = (List<Produkter>)Session["Produkter"];

            if (ID == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Produkter productToEdit = products.Where(p => p.ID == ID).FirstOrDefault();

            if (productToEdit == null)
            {
                return HttpNotFound();
            }            

            return View(productToEdit);
        }

        public ActionResult Save(int ID, string Namn, decimal Pris, int Antal, string Image)
        {
            var products = (List<Produkter>)Session["Produkter"];

            var editedProduct = (from p in products
                                 where p.ID == ID
                                 select p).FirstOrDefault();
                                

            editedProduct.Namn = Namn;
            editedProduct.Pris = Pris;
            editedProduct.Antal = Antal;
            editedProduct.Image = Image;

            return RedirectToAction("Manage", editedProduct);
        }

        public ActionResult Delete(int ID)
        {
            var products = (List<Produkter>)Session["Produkter"];

            var productToDelete = products.Where(p => p.ID == ID).FirstOrDefault();

                products.Remove(productToDelete);
            
            return RedirectToAction("Manage", products);
        }

    }
}