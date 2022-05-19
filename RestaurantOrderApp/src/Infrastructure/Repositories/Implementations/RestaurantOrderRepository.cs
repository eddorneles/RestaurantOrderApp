using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using RestaurantOrderApp.Domain.Models;
using RestaurantOrderApp.Domain.Interfaces.Repositories;
using RestaurantOrderApp.Infrastructure.DatabaseContexts;


namespace RestaurantOrderApp.Infrastructure.Repositories.Implementations {

    public class  RestaurantOrderRepository : IRestaurantOrderRepository {
        
        RestaurantOrderAppContext Context;
        public RestaurantOrderRepository( RestaurantOrderAppContext context ) {
            this.Context = context;
        }

        public RestaurantOrder Add(RestaurantOrder order) {
            throw new NotImplementedException();
        }

        public IEnumerable<RestaurantOrder> FindAll(){
            return this.Context.RestaurantOrders;
        } //END class
    }
}//END namespace