using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkipperTools.Models;

namespace SkipperTools.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<CrewMemberModel> CrewMembers { get; set; }
        public DbSet<VoyageModel> Voyages { get; set; }
        public DbSet<VesselModel> Vessels { get; set; }
    }
}
