﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nutrition.Data;

#nullable disable

namespace Nutrition.Server.Migrations
{
    [DbContext(typeof(NutritionContext))]
    partial class NutritionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("Nutrition.Shared.NutritionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Calcium")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Calories")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cholesterol")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DietaryFiber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FoodName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Iron")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Protein")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SaturatedFat")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ServingSize")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sodium")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sugars")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalCarbohydrates")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalFat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TransFat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VitaminA")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VitaminC")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("NutritionLabels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calcium = 20,
                            Calories = 200,
                            Cholesterol = 30,
                            DietaryFiber = 5,
                            FoodName = "Cheese",
                            Iron = 4,
                            Protein = 5,
                            SaturatedFat = 1,
                            ServingSize = "1 cup (228g)",
                            Sodium = 200,
                            Sugars = 10,
                            TotalCarbohydrates = 30,
                            TotalFat = 8,
                            TransFat = 0,
                            VitaminA = 4,
                            VitaminC = 2
                        },
                        new
                        {
                            Id = 2,
                            Calcium = 20,
                            Calories = 300,
                            Cholesterol = 30,
                            DietaryFiber = 5,
                            FoodName = "Butter",
                            Iron = 4,
                            Protein = 5,
                            SaturatedFat = 100,
                            ServingSize = "1 cup (528g)",
                            Sodium = 500,
                            Sugars = 10,
                            TotalCarbohydrates = 800,
                            TotalFat = 15,
                            TransFat = 300,
                            VitaminA = 4,
                            VitaminC = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
