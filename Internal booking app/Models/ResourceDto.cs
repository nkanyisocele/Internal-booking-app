using System.ComponentModel.DataAnnotations;

namespace Internal_booking_app.Models
{
    public class ResourceDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; } = "";

        [Required]
        public string Description { get; set; } = "";

        [Required, MaxLength(100)]
        public string Location { get; set; } = "";

        [Required]
        public int Capacity { get; set; }

        [Required]
        public Boolean IsAvailable { get; set; }

        [Required]
        public IFormFile? ImageFile { get; set; } 
    }
}
