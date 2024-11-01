
using carousel.Models;
using Microsoft.EntityFrameworkCore;

namespace carousel.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CarouselItem> CarouselItems { get; set; }
    }
}
