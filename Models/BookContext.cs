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
    }
}