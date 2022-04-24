using API.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class CofeeShopService : ICofeeShopService
    {
        public readonly ApplicationDbContext _dbContext;
        public CofeeShopService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;   
        }
         public async Task<List<CoffeeShopModel>> List()
        {
            var cofeeshop = await (from shop in _dbContext.CoffeeShops
                                   select new CoffeeShopModel()
                                   {
                                       Id = shop.Id,
                                       Name = shop.Name,
                                       Address = shop.Address,
                                       OpeningHours = shop.OpeningHours
                                   }).ToListAsync();
            return cofeeshop;
        }
    }
}
