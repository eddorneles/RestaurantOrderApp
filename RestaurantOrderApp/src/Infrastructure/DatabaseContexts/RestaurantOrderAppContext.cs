using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RestaurantOrderApp.Domain.Models;
using RestaurantOrderApp.Infrastructure.DatabaseContexts.Configurations;

#nullable disable

namespace RestaurantOrderApp.Infrastructure.DatabaseContexts
{
    public partial class RestaurantOrderAppContext : DbContext
    {
        public RestaurantOrderAppContext() {
        }

        public RestaurantOrderAppContext( DbContextOptions<RestaurantOrderAppContext> options )
            : base( options ) {
        }

        public virtual DbSet<RestaurantOrder> RestaurantOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}