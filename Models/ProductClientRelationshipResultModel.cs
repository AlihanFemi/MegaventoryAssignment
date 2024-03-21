using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaventoryAssignment.Models
{
    public class ProductClientRelationshipResultModel
    {
        public string APIKEY { get; set; }
        public ProductClientRelationshipModel mvProductClientUpdate { get; set; }
        public string mvRecordAction { get; set; }

        public ProductClientRelationshipResultModel(ProductClientRelationshipModel data, string action)
        {
            this.APIKEY = Program.apikey;
            this.mvProductClientUpdate = data;
            this.mvRecordAction = action;
        }
    }
}
