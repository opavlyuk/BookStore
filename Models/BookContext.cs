using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models
{
    public class BookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=bookstore.sqlite");

        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity => { entity.Property(e => e.Id).IsRequired(); });

            #region BookSeed

            modelBuilder.Entity<Book>().HasData(
                new Book {Id = 1, Name = "Война и мир", Author = "Л. Толстой", Price = "220"},
                new Book {Id = 2, Name = "Война и мир2", Author = "Л. Толстой2", Price = "221"}
            );

            #endregion
        }
    }
}