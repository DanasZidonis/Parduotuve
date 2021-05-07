using Microsoft.EntityFrameworkCore;
using Parduotuve.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Parduotuve.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> opt) : base(opt)
        {

        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Review> Review { get; set; }

    }
}
