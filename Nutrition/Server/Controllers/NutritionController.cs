using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nutrition.Controllers;
using Nutrition.Data;
using Nutrition.Shared;

namespace Nutrition.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NutritionController : ControllerBase
    {
        private readonly NutritionContext _context;

        private readonly ILogger<NutritionController> _logger;

        private readonly NutritionService _nutritionService;
        public NutritionController(ILogger<NutritionController> logger, NutritionContext context)
        {
            _context = context;
            _logger = logger;
            _nutritionService = new NutritionService();
        }


        [HttpGet]
        public IActionResult Get(string food)
        {

            /*            var nutritionData = _context.NutritionLabels
                                    .Where(n => EF.Functions.Like(n.FoodName, food))
                                    .ToListAsync();
                        if (nutritionData.Result.Count == 0)
                        {
                            return NotFound("Not found. This food isn't in the Database.\n Input another food");
                        }

                        return Ok(nutritionData.Result[0]);*/
            var nutritionData = _nutritionService.GetNutritionData(food);
            return Ok( nutritionData);

        }
    }
}
