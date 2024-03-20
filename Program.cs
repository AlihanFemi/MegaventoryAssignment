using MegaventoryAssignment.Models;
using MegaventoryAssignment.Proccessors;

namespace MegaventoryAssignment
{
    internal class Program
    {
        public static readonly string apikey = "f5998c44a276f84f@m146536";
        static void Main(string[] args)
        {
            ApiHelper.InitializeClient();
            InventoryLocationModel test = new InventoryLocationModel();
            test.InventoryLocationAbbreviation = "Test3";
            test.InventoryLocationName = "Test3";
            test.InventoryLocationAddress = "Testington";
            InventoryLocationProcessor.AddProduct(test, "Insert").Wait();
        }
    }
}
