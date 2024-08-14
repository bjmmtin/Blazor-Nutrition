using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nutrition.Server.Migrations
{
    public partial class added_nutrition_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NutritionLabels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodName = table.Column<string>(type: "TEXT", nullable: true),
                    ServingSize = table.Column<string>(type: "TEXT", nullable: true),
                    Calories = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalFat = table.Column<int>(type: "INTEGER", nullable: false),
                    SaturatedFat = table.Column<int>(type: "INTEGER", nullable: false),
                    TransFat = table.Column<int>(type: "INTEGER", nullable: false),
                    Cholesterol = table.Column<int>(type: "INTEGER", nullable: false),
                    Sodium = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalCarbohydrates = table.Column<int>(type: "INTEGER", nullable: false),
                    DietaryFiber = table.Column<int>(type: "INTEGER", nullable: false),
                    Sugars = table.Column<int>(type: "INTEGER", nullable: false),
                    Protein = table.Column<int>(type: "INTEGER", nullable: false),
                    VitaminA = table.Column<int>(type: "INTEGER", nullable: false),
                    VitaminC = table.Column<int>(type: "INTEGER", nullable: false),
                    Calcium = table.Column<int>(type: "INTEGER", nullable: false),
                    Iron = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionLabels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "NutritionLabels",
                columns: new[] { "Id", "Calcium", "Calories", "Cholesterol", "DietaryFiber", "FoodName", "Iron", "Protein", "SaturatedFat", "ServingSize", "Sodium", "Sugars", "TotalCarbohydrates", "TotalFat", "TransFat", "VitaminA", "VitaminC" },
                values: new object[] { 1, 20, 200, 30, 5, "Cheese", 4, 5, 1, "1 cup (228g)", 200, 10, 30, 8, 0, 4, 2 });

            migrationBuilder.InsertData(
                table: "NutritionLabels",
                columns: new[] { "Id", "Calcium", "Calories", "Cholesterol", "DietaryFiber", "FoodName", "Iron", "Protein", "SaturatedFat", "ServingSize", "Sodium", "Sugars", "TotalCarbohydrates", "TotalFat", "TransFat", "VitaminA", "VitaminC" },
                values: new object[] { 2, 20, 300, 30, 5, "Butter", 4, 5, 100, "1 cup (528g)", 500, 10, 800, 15, 300, 4, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NutritionLabels");
        }
    }
}
