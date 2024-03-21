using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaventoryAssignment.Models
{
    public class ProductClientRelationshipModel
    {
        public int ProductID { get; set; }
        public int ProductClientID { get; set;}

        public ProductClientRelationshipModel(int id, int clientID)
        {
            this.ProductID = id;
            this.ProductClientID = clientID;
        }
    }
}
