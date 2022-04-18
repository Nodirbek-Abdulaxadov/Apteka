using Apteka.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Apteka.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Drug> Drugs { get; set; }
    }
}