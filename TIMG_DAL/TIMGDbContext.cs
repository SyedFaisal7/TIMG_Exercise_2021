using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TIMG_BOL;

namespace TIMG_DAL
{
    public class TIMGDbContext:DbContext
    {
        public TIMGDbContext(DbContextOptions<TIMGDbContext> options) : base(options)
        {
            Database.EnsureCreated();
            //Database.Migrate();
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Server=LAPTOP-8Q43K63K;Database=TIMG;Trusted_Connection=True;");
        //}

        public DbSet<Client> Client { get; set; }
        public DbSet<Order> Order { get; set; }

        public DbSet<OrderItem> OrderItem { get; set; }

        public DbSet<Product> Product { get; set; }
    }
}
