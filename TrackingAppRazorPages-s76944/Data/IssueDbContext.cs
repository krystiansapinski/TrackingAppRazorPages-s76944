using Microsoft.EntityFrameworkCore;
using TrackingAppRazorPages_s76944.Models;

namespace TrackingAppRazorPages_s76944.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Issue> Issues { get; set; }
    }
}
