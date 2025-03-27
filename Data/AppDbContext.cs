using BlazorCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Users> Users { get; set; } = null!;
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Users>().HasData(
        //        new Users
        //        {
        //            Id = 1,
        //            Name = "Teste",
        //            Age = 26,
        //            Email = "test@mecontratapf.com",
        //            Password = "123",
        //        });
        //}
    }
}
