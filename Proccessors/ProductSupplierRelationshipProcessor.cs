using MegaventoryAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MegaventoryAssignment.Proccessors
{
    public static class ProductSupplierRelationshipProcessor
    {
        public static async Task AddProduct(ProductSupplierRelationshipModel data)
        {
            string url = "https://api.megaventory.com/v2017a/ProductSupplier/ProductSupplierUpdate\r\n";
            ProductSupplierRelationshipResultModel result = new ProductSupplierRelationshipResultModel(data, "Insert");
            string jsonString = JsonSerializer.Serialize(result);
            File.WriteAllText("C:\\Users\\DELL\\source\\repos\\MegaventoryAssignment\\test.json", jsonString);
            var contentData = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await ApiHelper.ApiClient.PostAsync(url, contentData);

        }
    }
}
