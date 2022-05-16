using System;
using System.Collections.Generic;

using RestaurantOrderApp.Domain.Models;
using RestaurantOrderApp.Domain.Enums;

namespace RestaurantOrderApp.Infrastructure.Data
{
    public class DishMockData {
        public readonly static IList<Dish> Dishes = new List<Dish>(){
            new Dish {
                Name = "eggs",
                Type = new DishType( 1,DishTypeEnum.ENTREE ),
                Availability = TimeOfDayEnum.MORNING
            },
            new Dish {
                Name = "steak",
                Type = new DishType( 1,DishTypeEnum.ENTREE ),
                Availability = TimeOfDayEnum.NIGHT,
            },
            new Dish {
                Name = "Toast",
                Type = new DishType( 2, DishTypeEnum.SIDE ),
                Availability = TimeOfDayEnum.MORNING
            },
            new Dish {
                Name = "potato",
                Type = new DishType( 2, DishTypeEnum.SIDE ),
                Availability = TimeOfDayEnum.NIGHT,
            },
            new Dish {
                Name = "coffee",
                Type = new DishType( 3, DishTypeEnum.DRINK ),
                Availability = TimeOfDayEnum.MORNING
            },
            new Dish {
                Name = "wine",
                Type = new DishType( 3, DishTypeEnum.DRINK ),
                Availability = TimeOfDayEnum.NIGHT,
            },
            new Dish {
                Name = "cake",
                Type = new DishType( 4, DishTypeEnum.DESSERT ),
                Availability = TimeOfDayEnum.NIGHT,
            }
        };
    }//END class
}//END namespace
