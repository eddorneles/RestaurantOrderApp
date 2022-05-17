using System;

using RestaurantOrderApp.Domain.Enums;

namespace RestaurantOrderApp.Domain.Models
{
    public class DishType {
        public int DishTypeNumber {get;set;}
        public DishTypeEnum Name {get; set;}

        public DishType ( int dishTypeNumber, DishTypeEnum dishTypeEnum ){
            this.DishTypeNumber = dishTypeNumber;
            this.Name = dishTypeEnum;
        }//END constructor
        
    }//END class
}//END namespace
