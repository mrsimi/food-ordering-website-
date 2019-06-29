using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodOrderingWebsite.Models
{
    public class Resturant
    {
        public int ID { get; set; }
        public string ResturantName { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string OpeningHours { get; set; }
        [NotMapped]
        public List<string> ResturantImagesUri { get; set; }
        public string ResturantImagesUriConcatenated { get; set; }

        public ICollection<Food> Menu { get; set; }
    }
}