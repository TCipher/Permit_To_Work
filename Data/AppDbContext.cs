using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PermitToWorkSystem.Data;
using PermitToWorkSystem.Models;
using System.Diagnostics.Metrics;

namespace PermitToWorkSystem.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<PermitToWorkForm> permitToWorkForm{ get; set; }
          public DbSet<SiteCheck> siteChecker{ get; set; }
       
    }
}
