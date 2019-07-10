using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodOrderingWebsite.Models
{
    public class Resturant
    {
        public int ID { get; set; }
        [Display(Name = "Resturant Name")]
        public string ResturantName { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        [Display(Name = "Opening Hours")]
        public string OpeningHours { get; set; }
        [Display(Name = "Resturant Image Uri")]
        public string ResturantImagesUriConcatenated { get; set; }

        public ICollection<Food> Menu { get; set; }
    }
}