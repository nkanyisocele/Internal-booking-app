
using Internal_booking_app.Models;
using Microsoft.EntityFrameworkCore;



namespace Internal_booking_app.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Resource> Resources { get; set; }
    }
}
