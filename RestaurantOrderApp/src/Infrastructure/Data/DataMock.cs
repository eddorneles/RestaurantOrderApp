using System;
using System.Collections.Generic;

using RestaurantOrderApp.Domain.Models;
using RestaurantOrderApp.Domain.Enums;

namespace RestaurantOrderApp.Infrastructure.Data
{
    public class DishMockData {
        public readonly static IList<Dish> Dishes = new List<Dish>(){
            new Dish( TimeOfDayEnum.Morning ) {
                Name = "eggs",
                TypeNumber = 1,
            },
            new Dish( TimeOfDayEnum.Night ) {
                Name = "steak",
                TypeNumber = 1,
            },
            new Dish( TimeOfDayEnum.Morning ) {
                Name = "Toast",
                TypeNumber = 2,
            },
            new Dish( TimeOfDayEnum.Night ) {
                Name = "potato",
                TypeNumber = 2,
            },
            new Dish( TimeOfDayEnum.Morning) {
                Name = "coffee",
                TypeNumber = 3,
            },
            new Dish( TimeOfDayEnum.Night ) {
                Name = "wine",
                TypeNumber = 3,
            },
            new Dish( TimeOfDayEnum.Night ){
                Name = "cake",
                TypeNumber = 4,
            }
        };
    }//END class
}//END namespace
