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
            ProductModel nike = new ProductModel(41, "1112256", "Nike shoes2", 99.99, 44.99);
            ProductModel addidas = new ProductModel(42, "1112248 ", "Adidas shoes2", 99.99, 44.99);
            SupplierClientModel babis = new SupplierClientModel(13, "Client", "babis3", "babis@exampletest.com", "Example 8, Athens", "1235698967");
            SupplierClientModel odysseus = new SupplierClientModel(14, "Supplier", "odysseus3", "odysseus@exampletest.com", "Example 10, Athens", "1235698988");
            InventoryLocationModel test = new InventoryLocationModel("Test5", "Test Project Location", "Example 20, Athens");

            ProductProcessor.AddProduct(nike, "Insert").Wait();
            ProductProcessor.AddProduct(addidas, "Insert").Wait();
            SupplierClientProcessor.AddProduct(babis).Wait();
            SupplierClientProcessor.AddProduct(odysseus).Wait();
            InventoryLocationProcessor.AddProduct(test).Wait();

            ProductClientRelationshipModel relation = new ProductClientRelationshipModel(41, 13);
            ProductClientRelationshipProcessor.AddProduct(relation).Wait();

            ProductSupplierRelationshipModel relation2 = new ProductSupplierRelationshipModel(42, 14);
            ProductSupplierRelationshipProcessor.AddProduct(relation2).Wait();

            ProductModel jacket1 = new ProductModel(22, "1112221", "Straight jacket --Updated", 49.99, 99.99);
            ProductModel jacket2 = new ProductModel(7, "1112212", "Tight jacket -Updated", 99.99, 49.99);
            ProductModel jacket4 = new ProductModel(8, "1112214", "Low-cut jacket -Updated", 99.99, 49.99);
            ProductModel jacket3 = new ProductModel(13, "1112223", "Loose jacket -Updated", 99.99, 49.99);
            ProductModel jacket5 = new ProductModel(11, "1112216", "Formal jacket -Updated", 99.99, 49.99);

            ProductProcessor.AddProduct(jacket1, "Update").Wait();
            ProductProcessor.AddProduct(jacket4, "Update").Wait();
            ProductProcessor.AddProduct(jacket3, "Update").Wait();
            ProductProcessor.AddProduct(jacket2, "Update").Wait();
            ProductProcessor.AddProduct(jacket5, "Update").Wait();

        }
    }
}
