using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaventoryAssignment.Models
{
    public class ProductResultModel
    {
        public string APIKEY { get; set; }
        public ProductModel mvProduct { get; set; }
        public string mvRecordAction { get; set; }
        public ProductResultModel(ProductModel data, string action)
        {
            this.APIKEY = Program.apikey;
            this.mvProduct = data;
            this.mvRecordAction = action;
        }
    }
}
