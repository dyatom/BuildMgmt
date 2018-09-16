using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;

namespace BuildingMgmt.Models
{
    public partial class BuildingMgmtContext : DbContext
    {
        public BuildingMgmtContext()
        {
        }

        public BuildingMgmtContext(DbContextOptions<BuildingMgmtContext> options)
            : base(options)
        {
        }

        // Unable to generate entity type for table 'dbo.SiteUsers'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BuildingMgmt"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
