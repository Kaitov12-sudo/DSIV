using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Laboratorio181.Models

{
    public class YourDbContext : DbContext
    {
        public YourDbContext() : base("DefaultConnection") 
        {
        }

        public DbSet<User> Users { get; set; } 
    }
}