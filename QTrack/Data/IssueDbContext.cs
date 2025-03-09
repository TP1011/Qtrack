using Microsoft.EntityFrameworkCore;
using QTrack.Models;

namespace QTrack.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Issue> Issues { get; set; }
    }
}