using FinalProjectMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace FinalProjectMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        
        
        }
      
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Customer> Customers { get; set; }
      
        public DbSet<Item> Item { get; set; }
        public DbSet<Fee> Fee { get; set; }
        public IEnumerable Product { get; internal set; }
    }
    
}
