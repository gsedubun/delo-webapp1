 using delo_webapp1.Models;
    
 namespace delo_webapp1.Database;
    
 using Microsoft.EntityFrameworkCore;
    
 public class MyDbContext : DbContext
 {
     public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
     {
     }
    
     public DbSet<Product> Products { get; set; }
 }    