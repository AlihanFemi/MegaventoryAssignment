using MegaventoryAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace MegaventoryAssignment.Proccessors
{
    public static class ProductProcessor
    {
        
        public static async Task AddProduct(ProductModel data)
        {
            string url = "https://api.megaventory.com/v2017a/Product/ProductUpdate\r\n";
            ProductResultModel result = new ProductResultModel(data, "action");
            string jsonString = JsonSerializer.Serialize(result);
            var contentData = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await ApiHelper.ApiClient.PostAsync(url, contentData);
            File.WriteAllText("C:\\Users\\DELL\\source\\repos\\MegaventoryAssignment\\test.json", response.ToString());
        }
    }
}
