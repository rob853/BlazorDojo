using System;

namespace BlazorServer3.ClassLibrary
{
    public class ShoppingBasketItem
    {
        public Guid ShoppingBasketItemId { get; set; }

        public Guid ShoppingBasketId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
