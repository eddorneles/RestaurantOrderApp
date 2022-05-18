using RestaurantOrderApp.Domain.Models;
using RestaurantOrderApp.Domain.Enums;

namespace RestaurantOrderApp.Domain.Interfaces.Repositories {
    public interface IDishRepository {
        Dish GetByTypeNumberAndTimeOfDay( int typeNumber, TimeOfDayEnum timeOfDayEnum );
    }// END interface
}//END namespace