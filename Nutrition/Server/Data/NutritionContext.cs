using Microsoft.EntityFrameworkCore;
using Nutrition.Shared;

namespace Nutrition.Data
{
    public class NutritionContext : DbContext
    {
        public NutritionContext(DbContextOptions<NutritionContext> options) : base(options) { }
        public DbSet<NutritionModel> NutritionLabels => Set<NutritionModel>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NutritionModel>().HasData(
                new {
                    Id = 1,
                    FoodName = "Cheese",
                    ServingSize = "1 cup (228g)",
                    Calories = 200,
                    TotalFat = 8,
                    SaturatedFat = 1,
                    TransFat = 0,
                    Cholesterol = 30,
                    Sodium = 200,
                    TotalCarbohydrates = 30,
                    DietaryFiber = 5,
                    Sugars = 10,
                    Protein = 5,
                    VitaminA = 4,
                    VitaminC = 2,
                    Calcium = 20,
                    Iron = 4,
                },
                new {
                    Id = 2,
                    FoodName = "Butter",
                    ServingSize = "1 cup (528g)",
                    Calories = 300,
                    TotalFat = 15,
                    SaturatedFat = 100,
                    TransFat = 300,
                    Cholesterol = 30,
                    Sodium = 500,
                    TotalCarbohydrates = 800,
                    DietaryFiber = 5,
                    Sugars = 10,
                    Protein = 5,
                    VitaminA = 4,
                    VitaminC = 2,
                    Calcium = 20,
                    Iron = 4,
                }
            );
        }


    }

}
