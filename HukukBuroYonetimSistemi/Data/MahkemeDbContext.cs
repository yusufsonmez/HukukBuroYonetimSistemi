using HukukBuroYonetimSistemi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace HukukBuroYonetimSistemi.Data
{
    public class MahkemeDbContext : DbContext
    {
        public MahkemeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MahkemeModel> MahkemeModel { get; set; }
        public DbSet<GorevAtama> GorevAtama { get; set; }
        public DbSet<UserModel> UserModel { get; set; }
    }
}
