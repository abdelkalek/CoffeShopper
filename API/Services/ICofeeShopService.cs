using API.Models;

namespace API.Services
{
    public interface ICofeeShopService
    {
        Task<List<CoffeeShopModel>> List();
    }
}
