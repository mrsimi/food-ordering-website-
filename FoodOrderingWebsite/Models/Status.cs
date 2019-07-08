using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Models
{
    public class DeliveryStatus
    {
        public int Id { get; set; }
        public string  FoodBought { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int EstimatedTimeofArrival { get; set; }
        public string UserName { get; set; }
    }
}
