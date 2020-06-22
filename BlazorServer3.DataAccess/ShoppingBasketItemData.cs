using BlazorServer3.ClassLibrary;
using BlazorServer3.Database;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer3.DataAccess
{
    public class ShoppingBasketItemData : IShoppingBasketItemData
    {
        private readonly IDbContext _dbContext;

        public ShoppingBasketItemData(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddShoppingBasketItem(ClassLibrary.ShoppingBasketItem shoppingBasketItem)
        {
            var existingShoppingBasketItem = _dbContext.ShoppingBasketItems
                .FirstOrDefault(p => p.ShoppingBasketId == shoppingBasketItem.ShoppingBasketId && p.ProductId == shoppingBasketItem.ProductId);

            if (existingShoppingBasketItem != null)
            {
                existingShoppingBasketItem.Quantity += shoppingBasketItem.Quantity;
            }
            else
            {
                _dbContext.ShoppingBasketItems.Add(new Database.ShoppingBasketItem
                {
                    ItemId = Guid.NewGuid(),
                    ShoppingBasketId = shoppingBasketItem.ShoppingBasketId,
                    ProductId = shoppingBasketItem.ProductId,
                    Quantity = shoppingBasketItem.Quantity
                });
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
