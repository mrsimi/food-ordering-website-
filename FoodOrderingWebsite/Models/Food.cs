using System.ComponentModel.DataAnnotations;

namespace FoodOrderingWebsite.Models
{
    public class Food
    {
        public int ID { get; set; }
        [Display(Name = "Resturant Id")]
        public int ResturantID { get; set; }
        [Display(Name = "Food Name")]
        public string FoodName { get; set; }
        
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Food Image uri")]
        public string FoodImagesUriConcatenated { get; set; }
        
        public Resturant Resturant { get; set; }
    }
}
