using InspectionApi.Models;
using Microsoft.EntityFrameworkCore;

namespace InspectionApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<InspectionType> InspectionTypes { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
