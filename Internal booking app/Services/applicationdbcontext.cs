

using Microsoft.EntityFrameworkCore;

namespace Internal_booking_app.Services
{
    public class applicationdbcontext : DbContext
    {
        public applicationdbcontext(DbContextOptions options) : base(options)
        {

        }
    }
}
