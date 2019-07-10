using System.ComponentModel.DataAnnotations;

namespace FoodOrderingWebsite.Models
{
    public class Cart
    {
        
        public int ID { get; set; }
        [Display(Name = "Food Name")]
        public string FoodName { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Food Price")]
        public decimal FoodPrice { get; set; }
        [Display(Name = "Resturant Name")]
        public string  ResturantName { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Display(Name = "Resturant Id")]
        public int ResturantId { get; set; }
    }
}
