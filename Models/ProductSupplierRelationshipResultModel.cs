using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaventoryAssignment.Models
{
    public class ProductSupplierRelationshipResultModel
    {
        public string APIKEY { get; set; }
        public ProductSupplierRelationshipModel mvProductSupplierUpdate { get; set; }
        public string mvRecordAction { get; set; }

        public ProductSupplierRelationshipResultModel(ProductSupplierRelationshipModel data, string action)
        {
            this.APIKEY = Program.apikey;
            this.mvProductSupplierUpdate = data;
            this.mvRecordAction = action;
        }
    }
}
