using RestaurantOrderApp.Domain.Models;
using RestaurantOrderApp.Domain.Enums;

namespace RestaurantOrderApp.Domain.Interfaces.Repositories {
    public interface IRestaurantOrderRepository {
        RestaurantOrder Add( RestaurantOrder order );
    }// END interface
}//END namespace