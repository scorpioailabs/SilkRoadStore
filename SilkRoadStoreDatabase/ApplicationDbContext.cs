using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheSilkRoadStore.Domain.Models; 
using System;
using System.Collections.Generic;
using System.Text;

namespace TheSilkRoadStore.Database
{
    public class ApplicationDbContext : IdentityDbContext 

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; } 
        {

        }
        
    }
}
