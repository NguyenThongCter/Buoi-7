using System;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp4
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;" +
                "Database=QuanLySinhVien;" +
                "Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}