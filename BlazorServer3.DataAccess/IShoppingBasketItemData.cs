using BlazorServer3.ClassLibrary;
using System.Threading.Tasks;

namespace BlazorServer3.DataAccess
{
    public interface IShoppingBasketItemData
    {
        Task AddShoppingBasketItem(ShoppingBasketItem shoppingBasketItem);
    }
}