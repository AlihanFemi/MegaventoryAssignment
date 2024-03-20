using MegaventoryAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MegaventoryAssignment.Proccessors
{
    public static class SupplierClientProcessor
    {
        public static async Task AddProduct(SupplierClientModel data)
        {
            string url = "https://api.megaventory.com/v2017a/SupplierClient/SupplierClientUpdate\r\n";
            SupplierClientResultModel result = new SupplierClientResultModel(data, "action");
            string jsonString = JsonSerializer.Serialize(result);
            var contentData = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await ApiHelper.ApiClient.PostAsync(url, contentData);
            File.WriteAllText("C:\\Users\\DELL\\source\\repos\\MegaventoryAssignment\\test.json", response.ToString());
        }
    }
}
