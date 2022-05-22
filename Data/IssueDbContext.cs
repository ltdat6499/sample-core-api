using core_project.Models;
using Microsoft.EntityFrameworkCore;

namespace core_project.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options) : base(options)
        {

        }
        public DbSet<Issue> Issues { get; set; }
    }
}