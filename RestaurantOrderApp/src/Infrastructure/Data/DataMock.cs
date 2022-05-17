using System;
using System.Collections.Generic;

using RestaurantOrderApp.Domain.Models;
using RestaurantOrderApp.Domain.Enums;

namespace RestaurantOrderApp.Infrastructure.Data
{
    public class DishMockData {
        public readonly static IList<Dish> Dishes = new List<Dish>(){
            new Dish( TimeOfDayEnum.MORNING ) {
                Name = "eggs",
                TypeNumber = 1,
            },
            new Dish( TimeOfDayEnum.NIGHT ) {
                Name = "steak",
                TypeNumber = 1,
            },
            new Dish( TimeOfDayEnum.MORNING ) {
                Name = "Toast",
                TypeNumber = 2,
            },
            new Dish( TimeOfDayEnum.NIGHT ) {
                Name = "potato",
                TypeNumber = 2,
            },
            new Dish( TimeOfDayEnum.MORNING) {
                Name = "coffee",
                TypeNumber = 3,
            },
            new Dish( TimeOfDayEnum.NIGHT ) {
                Name = "wine",
                TypeNumber = 3,
            },
            new Dish( TimeOfDayEnum.NIGHT ){
                Name = "cake",
                TypeNumber = 4,
            }
        };
    }//END class
}//END namespace
