using Microsoft.EntityFrameworkCore;
using AspNetCoreMvcApp.Models;  

namespace AspNetCoreMvcApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        // DbSet representing the Submission table
        public DbSet<Submission> Submissions { get; set; }
    }
}
