using Demo.AppMaui.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Demo.AppMaui.Services
{
    public class ProductService : IProductRepository
    {
        public async Task<List<Product>?> GetProducts()
        {
            try
            {
                var client = new HttpClient();

                //string localhostUrl = "http://localhost:5053/api/Product";

                string localhostUrl = "http://192.168.1.133:5053/api/Product";

                client.BaseAddress = new Uri(localhostUrl);

                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);

                if (response.IsSuccessStatusCode)
                {
                    List<Product>? products = await response.Content.ReadFromJsonAsync<List<Product>>();

                    return products;
                }
                return null;
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "Ok");

                return null;
            }
          
            
            
        }
    }
}
