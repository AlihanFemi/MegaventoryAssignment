using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaventoryAssignment.Models
{
    public class InventoryLocationModel
    {
        public string InventoryLocationAbbreviation { get; set; }
        public string InventoryLocationName { get; set; }
        public string InventoryLocationAddress { get; set; }
        public InventoryLocationModel(string abbreviation, string name, string address)
        {
            this.InventoryLocationAbbreviation = abbreviation;
            this.InventoryLocationName = name;
            this.InventoryLocationAddress = address;
        }
    }
}
