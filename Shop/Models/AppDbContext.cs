using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Shop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<OrderDetail>().HasKey(og=>new {og.OrderID,og.GoodID});

            modelBuilder.Entity<OrderDetail>().HasOne(og => og.Order)
                .WithMany(o => o.OrderDetail);


            modelBuilder.Entity<OrderDetail>().HasOne(og => og.Goods)
                .WithMany(g => g.OrderDetails);





        }
    }
}