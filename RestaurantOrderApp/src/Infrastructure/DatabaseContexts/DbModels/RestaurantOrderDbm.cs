using System;
using System.Linq;
using System.Collections.Generic;

using RestaurantOrderApp.Domain.Enums;

namespace RestaurantOrderApp.Domain.Models
{
    public class RestaurantOrderDbm {
        public int OrderNumber {get;set;}
        public List<Dish> Dishes {get;set;}
        private Dictionary<int,int> DishQuantity {get;set;}
        public TimeOfDayEnum TimeOfDay {get;set;}
        
    }//END class
}//END namespace
