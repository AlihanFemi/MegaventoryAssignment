using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaventoryAssignment.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductSKU { get; set; }
        public string ProductDescription { get; set; }
        public double ProductSellingPrice { get; set; }
        public double ProductPurchasePrice { get; set; }
        public ProductModel(int id, string sku, string desc, double sellingprice, double purchaseprice)
        {
            this.ProductID = id;
            this.ProductSKU = sku;
            this.ProductDescription = desc;
            this.ProductSellingPrice = sellingprice;
            this.ProductPurchasePrice = purchaseprice;
        }
    }
}
