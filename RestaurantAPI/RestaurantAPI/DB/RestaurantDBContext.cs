using RestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantAPI.DB
{
    public class RestaurantDBContext:DbContext
    {
        public DbSet<Customer> custEntity { get; set; }
        public DbSet<Item> itemEntity { get; set; }
        public DbSet<Order> orderEntity { get; set; }
        public DbSet<OrderItems> orderItemEntity { get; set; }


    }
}