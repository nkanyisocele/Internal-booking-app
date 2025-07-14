using System;

namespace Internal_booking_app.Models
{
    public class Resource
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public Boolean IsAvailable { get; set; }
    }
}
