//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpeedUpCoreAPIExample.Models;

namespace SpeedUpCoreAPIExample.Contexts
{
    //public class DefaultContext
    //{
    //}
    public class DefaultContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Price> Prices { get; set; }

        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }
    }
}
