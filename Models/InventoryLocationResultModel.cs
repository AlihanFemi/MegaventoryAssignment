using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaventoryAssignment.Models
{
    public class InventoryLocationResultModel
    {
        public string APIKEY { get; set; }
        public InventoryLocationModel mvInventoryLocation { get; set; }
        public string mvRecordAction { get; set; }

        public InventoryLocationResultModel(InventoryLocationModel data, string action)
        {
            this.APIKEY = Program.apikey;
            this.mvInventoryLocation = data;
            this.mvRecordAction = action;
        }
    }
}
