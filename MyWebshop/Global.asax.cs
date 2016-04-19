using MyWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MyWebshop
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

           protected void Session_Start(object sender, EventArgs e)
            {
                Session["Produkter"] = new List<Produkter>()
                    {
                    new Bil () { ID=1, Namn = "BMW", Antal = 10, Pris = 12000000, Modell = "BMW-725i", Image ="https://s-media-cache-ak0.pinimg.com/736x/56/9f/35/569f3587db21884ed6c0db30edbc013a.jpg"},
                    new Bil () {ID=2, Namn = "Audi", Antal = 20, Pris = 20000000, Modell = "Audi-A8", Image = "http://images.car.bauercdn.com/upload/22350/images/1040x585/audia8.jpg?mode=pad" },
                    new Bil () {ID=3, Namn = "Ferrari", Antal = 50, Pris = 30000000, Modell = "Ferrari-458", Image ="https://cdn-images.speedvegas.com/images/news/w6om-2014-ferrari-458-italia_100435781_h.jpg" },
                    new Bil () {ID=4, Namn = "RollsRoyce", Antal = 25, Pris = 40000000, Modell = "RR-001", Image ="http://bestcarmag.com/sites/default/files/1754996rolls-royce2.jpg" },
                    new Whisky () {ID=5, Namn = "Jack Daniels", Alkohol = 42.8, Pris = 230, Antal = 30, Image ="http://cdn2.bigcommerce.com/server900/b0811/products/1501/images/6971/jack_daniels__79730.1451544603.1280.1280.JPG?c=2" },
                    new Whisky () {ID=6, Namn = "Johnny Walker (Blue Label)", Alkohol = 41.8, Pris = 230, Antal = 30, Image ="http://sr1.wine-searcher.net/images/labels/04/84/10670484.jpg" },
                    new Whisky () {ID=7, Namn = "Chivas Regal 25year", Alkohol = 45.8, Pris = 230, Antal = 30, Image ="http://www.lcbo.com/content/dam/lcbo/products/007617.jpg/jcr:content/renditions/cq5dam.web.1280.1280.jpeg" },
                    new Whisky () {ID=8, Namn = "Dimple 22years", Alkohol = 42, Pris = 230, Antal = 30, Image = "http://www.dimplewhisky.com/wp-content/uploads/2013/04/1279905214_106549886_1-Fotos-de-WHISKY-DIMPLE-15-AnOS-1279905214.jpg"},
                    new Parfum () {ID=9, Namn = "Burberry", Doft = "Lavender", Antal = 100, Pris= 450, Image ="http://www.perfume.com/images/products/parent/medium/71581W.jpg" },
                    new Parfum () {ID=10, Namn = "CK", Doft = "Sandal", Antal = 50, Pris= 350, Image ="http://www.perfume.com/images/products/parent/medium/65865M.jpg" },
                    new Parfum () {ID=11, Namn = "Hugo Boss", Doft = "Aqua", Antal = 80, Pris= 650, Image ="https://fimgs.net/images/secundar/o.31522.jpg" },
                    new Parfum () {ID=12, Namn = "Dolce Gabana", Doft = "Cactus", Antal = 90, Pris= 750, Image="http://www.glossme.se/PartnerFiles/glossme/images/products/4-CDOL6-small.jpg" },
              
                };            
                  
            }
    }
}
