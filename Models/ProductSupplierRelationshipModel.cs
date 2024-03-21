using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaventoryAssignment.Models
{
    public class ProductSupplierRelationshipModel
    {
        public int ProductID { get; set; }
        public int ProductSupplierID { get; set; }

        public ProductSupplierRelationshipModel(int id, int supplierID)
        {
            this.ProductID = id;
            this.ProductSupplierID = supplierID;
        }
    }
}
