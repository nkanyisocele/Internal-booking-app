using Internal_booking_app.Models;
using Internal_booking_app.Services;
using Microsoft.AspNetCore.Mvc;

namespace Internal_booking_app.Controllers
{
    public class ResourceController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IWebHostEnvironment environment;

        public ResourceController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            this.context = context;
            this.environment = environment;
        }
        public IActionResult Index()
        {
            var resources = context.Resources.OrderByDescending(p => p.Id).ToList();
            return View(resources);
        }
        public IActionResult Create()
        {
            
            return View();
        }
    [HttpPost]
    public IActionResult Create(ResourceDto resourceDto)
    {
      if(resourceDto.ImageFile == null)
      {
       ModelState.AddModelError("ImageFile", "The image file is redquired");
      }
      if(!ModelState.IsValid)
      {
                return View(resourceDto);
      }
      // save the image file

      string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
      newFileName += Path.GetExtension(resourceDto.ImageFile!.FileName);

      string imageFullPath = environment.WebRootPath + "/resources/" + newFileName;
      using (var stream = System.IO.File.Create(imageFullPath))
      {
          resourceDto.ImageFile.CopyTo(stream);
      }


            return RedirectToAction("Index", "Resources");

    } 
  }
}
