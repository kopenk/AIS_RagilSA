using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ragil.AIS.Models
{
    public class Products
    {
        public Products(int id, int barcode, string productName, decimal price, string status)
        {
            this.id = id;
            this.barcode = barcode;
            this.product_name = productName;
            this.price = price;
            this.status = status;
        }
        public int id { get; set; }
        public int barcode { get; set; }
        public string product_name { get; set; }
        public decimal price { get; set; }
        public string status { get; set; }
    }

    public class ProductsVM
    {
        public int barcode;
        public int totalQty;
        public decimal totalPrice;
        public int ready;
        public int onhold;
        public int delivered;
        public int packing;
        public int sent;
    }
}