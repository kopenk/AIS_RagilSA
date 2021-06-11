using Ragil.AIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ragil.AIS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Satu()
        {
            var products = GetProducts();
            var model = products.GroupBy(g => g.barcode)
                        .Select(s => new ProductsVM
                        {
                            barcode = s.Key,
                            totalQty = s.Count(),
                            totalPrice = s.Sum(su => su.price),
                            ready = s.Count(c => c.status == "READY"),
                            onhold = s.Count(c => c.status == "ONHOLD"),
                            delivered = s.Count(c => c.status == "DELIVERED"),
                            packing = s.Count(c => c.status == "PACKING"),
                            sent = s.Count(c => c.status == "SENT"),
                        });



            return View(model);
        }

        public ActionResult Dua()
        {
            return View();
        }



        public List<Products> GetProducts()
        {
            List<Products> products = new List<Products>()
            {
                new Products(1,1111,"APPLE",10,"READY"),
                new Products(2,1111,"APPLE",20,"DELIVERED"),
                new Products(3,1111,"APPLE",30,"SENT"),
                new Products(4,1111,"APPLE",10,"ONHOLD"),
                new Products(5,1111,"APPLE",20,"PACKING"),
                new Products(6,1111,"APPLE",40,"SENT"),
                new Products(7,1111,"APPLE",50,"SENT"),
                new Products(8,1122,"PINAPPLE",10,"READY"),
                new Products(9,1122,"PINAPPLE",10,"DELIVERED"),
                new Products(10,1122,"PINAPPLE",10,"PACKING"),
                new Products(11,1122,"PINAPPLE",10,"DELIVERED")
            };

            return products;
        }
    }
}