using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorServer3.Database
{
    public class ShoppingBasketItem
    {
        [Key]
        public Guid ItemId { get; set; }

        [Required]
        public Guid ShoppingBasketId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public Product Product { get; set; }

        public ShoppingBasket ShoppingBasket { get; set; }
    }
}
