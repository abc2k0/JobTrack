
using JobTrack.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace JobTrack.Api.Data;

public class JobTrackDbContext: DbContext
{
    public JobTrackDbContext(DbContextOptions<JobTrackDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JobApplication>().ToTable("Applications", table => {
            table.HasCheckConstraint(
            "CK_Applications_Status",
            "[Status] IN (0, 1, 2, 3, 4)");
        });
    }

    public DbSet<JobApplication> Applications {get; set;}
}