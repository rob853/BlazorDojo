using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorServer3.Database
{
    public class ShoppingBasket
    {
        [Key]
        public Guid ShoppingBasketId { get; set; }

        [Required]
        public DateTime CreatedDateTime { get; set; }

        public List<ShoppingBasketItem> ShoppingBasketItems { get; set; }
    }
}
