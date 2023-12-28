using HukukBuroYonetimSistemi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace HukukBuroYonetimSistemi.Data
{
    public class MahkemeDbContext : DbContext
    {
        public MahkemeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Mahkemeler> Mahkemeler { get; set; }
        public DbSet<GorevAtamalar> GorevAtamalar { get; set; }
        public DbSet<Users> Users { get; set; } 
        public DbSet<MahkemelerWebViews> MahkemelerWebViews { get; set; }
        public DbSet<ValuesForMahkemeWebViews> ValuesForMahkemeVewViews { get; set; }
    }
}
