using Internal_booking_app.Services;
using Microsoft.AspNetCore.Mvc;

namespace Internal_booking_app.Controllers
{
    public class ResourceController : Controller
    {
        private readonly ApplicationDbContext context;

        public ResourceController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var resources = context.Resources.ToList();
            return View(resources);
        }
    }
}
