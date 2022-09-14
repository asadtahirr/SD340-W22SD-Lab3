using Microsoft.EntityFrameworkCore;
using SD340_Lab2.Models;

namespace SD340_Lab2.Data
{
    public class ApplicationDbContext : DbContext
    {   
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {}
        public DbSet<SD340_Lab2.Models.Route> Routes { get; set; }
        public DbSet<ScheduleStop> ScheduleStops { get; set; }
        public DbSet<Stop> Stop { get; set; }   

    }
}
