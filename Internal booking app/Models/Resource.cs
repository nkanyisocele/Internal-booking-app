using System;
using System.ComponentModel.DataAnnotations;

namespace Internal_booking_app.Models
{
    public class Resource
    {
        public int Id {get; set;}

        [MaxLength(100)]
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        [MaxLength(100)]
        public string Location { get; set; } = "";

        public int Capacity { get; set; }

        public Boolean IsAvailable { get; set; }

        [MaxLength(100)]
        public string ImageFileName { get; set; } = "";
    }
}
