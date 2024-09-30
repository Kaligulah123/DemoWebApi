using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Demo.AppMaui.MVVM.Models;
using Demo.AppMaui.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.AppMaui.MVVM.ViewModels
{
    public partial class NewPage1ViewModel : ObservableObject
    {
        public ObservableCollection<Product> Products { get; set; } = new();

        readonly IProductRepository productService = new ProductService();

        public NewPage1ViewModel()
        {
        }

        [RelayCommand]
        private async Task GetProducts()
        {
            Products.Clear();

            var products = await productService.GetProducts();

            if (products != null)
            {
                foreach (var product in products)
                {
                    Products.Add(product);
                }
            }
        }
    }
}
