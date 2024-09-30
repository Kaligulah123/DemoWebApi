
using Demo.AppMaui.MVVM.Models;

namespace Demo.AppMaui.Services
{
    public interface IProductRepository
    {
        Task<List<Product>?> GetProducts();
    }
}
