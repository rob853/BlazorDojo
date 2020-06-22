using System;
using System.Threading.Tasks;

namespace BlazorServer3.DataAccess
{
    public interface IShoppingBasketData
    {
        Task<Guid> AddShoppingBasket();
    }
}