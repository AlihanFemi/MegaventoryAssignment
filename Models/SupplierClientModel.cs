using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaventoryAssignment.Models
{
    public class SupplierClientModel
    {
        public int SupplierClientID { get; set; }
        public string SupplierClientType { get; set; }
        public string SupplierClientName { get; set; }
        public string SupplierClientEmail { get; set; }
        public string SupplierClientShippingAddress1 { get; set; }
        public string SupplierClientPhone1 { get; set; }

        public SupplierClientModel(int id, string type, string name, string email, string address, string phone)
        {
            this.SupplierClientID = id;
            this.SupplierClientType = type;
            this.SupplierClientName = name;
            this.SupplierClientEmail = email;
            this.SupplierClientShippingAddress1 = address;
            this.SupplierClientPhone1 = phone;
        }
    }
}
