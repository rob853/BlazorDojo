using BlazorServer3.Database;
using System;
using System.Threading.Tasks;

namespace BlazorServer3.DataAccess
{
    public class ShoppingBasketData : IShoppingBasketData
    {
        private readonly IDbContext _dbcontext;

        public ShoppingBasketData(IDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task<Guid> AddShoppingBasket()
        {
            var newShoppingBasket = new ShoppingBasket
            {
                ShoppingBasketId = Guid.NewGuid(),
                CreatedDateTime = DateTime.Now
            };

            _dbcontext.ShoppingBaskets.Add(newShoppingBasket);

            await _dbcontext.SaveChangesAsync();

            return newShoppingBasket.ShoppingBasketId;
        }
    }
}
