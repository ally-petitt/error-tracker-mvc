using Microsoft.EntityFrameworkCore;

namespace error_track.Models
{
    public class ErrorContext : DbContext
    {
        public ErrorContext(DbContextOptions<ErrorContext> options):base(options) {

        }

        public DbSet<Error> Errors { get; set; }
    }
}