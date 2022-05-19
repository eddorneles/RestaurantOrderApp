using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using RestaurantOrderApp.Domain.Models;
using RestaurantOrderApp.Domain.Enums;

namespace RestaurantOrderApp.Infrastructure.DatabaseContexts.Configurations {

    public class RestaurantOrderConfiguration : IEntityTypeConfiguration<RestaurantOrder> {
        public void Configure( EntityTypeBuilder<RestaurantOrder> builder ){
            builder.ToTable( "RestaurantOrder" );

            builder.HasKey( o => o.Number );
            builder.Property( o => o.Number )
                .ValueGeneratedOnAdd();

            builder.Property( o => o.GetTimeOfDay() )
                .IsRequired()
                .HasMaxLength( 20 )
                .HasConversion( 
                    v => v.ToString(),
                    v => (TimeOfDayEnum) Enum.Parse(typeof(TimeOfDayEnum), v) );

            builder.Ignore( o => o.HasError() );
        }
    }//END 

}