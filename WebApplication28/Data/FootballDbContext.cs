using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication28.Models;

namespace WebApplication28.Data
{
    public class FootballDbContext :DbContext
    {
        protected readonly IConfiguration Configuration;
        public FootballDbContext(DbContextOptions<FootballDbContext> options):base(options)
        {

        }
        public DbSet<Player> Players { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(build =>
            {
                build.HasKey(_ => _.PlayerId);
            });
        }
    }
}
