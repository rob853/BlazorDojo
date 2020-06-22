using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorServer3.Database
{
    public interface IDbContext : IDisposable
    {
        void RecreateDatabase();

        DbSet<Category> Categories { get; set; }

        DbSet<Product> Products { get; set; }

        DbSet<ShoppingBasket> ShoppingBaskets { get; set; }

        DbSet<ShoppingBasketItem> ShoppingBasketItems { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
