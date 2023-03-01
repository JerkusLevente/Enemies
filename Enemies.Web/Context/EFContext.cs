using Enemies.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Enemies.Web.Context
{
    public class EFContext : DbContext
    {
        public DbSet<Enemy> Enemies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.//DB//Enemies.db");
        }
    }
}
