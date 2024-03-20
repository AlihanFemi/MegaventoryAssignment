using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaventoryAssignment.Models
{
    public class SupplierClientResultModel
    {
        public string APIKEY { get; set; }
        public SupplierClientModel mvSupplierClient { get; set; }
        public string mvRecordAction { get; set; }

        public SupplierClientResultModel(SupplierClientModel data, string action)
        {
            this.APIKEY = Program.apikey;
            this.mvSupplierClient = data;
            this.mvRecordAction = action;
        }
    }
}
