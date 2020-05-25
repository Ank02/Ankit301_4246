﻿// <auto-generated />
using MT.OnlineRestaurant.DataLayer.DataEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MT.OnlineRestaurant.DataLayer.Migrations
{
    [DbContext(typeof(ReviewDetailsContext))]
    partial class ReviewDetailsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MT.OnlineRestaurant.DataLayer.Data_Entity.ReviewDetails", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Rating");

                    b.Property<string>("Restaurant_Name");

                    b.Property<string>("Review");

                    b.HasKey("RestaurantId");

                    b.ToTable("Reviewdetails");
                });
#pragma warning restore 612, 618
        }
    }
}
