using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Models
{
    public class Food
    {
        public int ID { get; set; }
        public int ResturantID { get; set; }
        public string FoodName { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [NotMapped]
        public List<string> FoodImagesUri { get; set; }
        public string FoodImagesUriConcatenated { get; set; }
        
        public Resturant Resturant { get; set; }
    }
}
