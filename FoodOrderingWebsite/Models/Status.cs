using System;
using System.ComponentModel.DataAnnotations;

namespace FoodOrderingWebsite.Models
{
    public class DeliveryStatus
    {
        public int Id { get; set; }
        [Display(Name = "Food Bought")]
        public string  FoodBought { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Estimated Time of Arrival")]
        public int EstimatedTimeofArrival { get; set; }
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [Display(Name = "Date and Time Order Completed")]
        public DateTime DateTimeOrderCompleted{ get; set; }
    }
}
