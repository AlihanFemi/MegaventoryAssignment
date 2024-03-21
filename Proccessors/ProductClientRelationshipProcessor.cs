using MegaventoryAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MegaventoryAssignment.Proccessors
{
    public class ProductClientRelationshipProcessor
    {
        public static async Task AddProduct(ProductClientRelationshipModel data)
        {
            string url = "https://api.megaventory.com/v2017a/ProductClient/ProductClientUpdate";
            ProductClientRelationshipResultModel result = new ProductClientRelationshipResultModel(data, "Insert");
            string jsonString = JsonSerializer.Serialize(result);
            File.WriteAllText("C:\\Users\\DELL\\source\\repos\\MegaventoryAssignment\\test.json", jsonString);
            var contentData = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await ApiHelper.ApiClient.PostAsync(url, contentData);

        }
    }
}
