using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public string FoodName { get; set; }
        [DataType(DataType.Currency)]
        public decimal FoodPrice { get; set; }
        public string  ResturantName { get; set; }
        public string UserName { get; set; }
        public int ResturantId { get; set; }
    }
}
