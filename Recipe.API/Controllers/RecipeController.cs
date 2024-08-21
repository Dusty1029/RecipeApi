using CommonV2.Helpers.Controller;
using Microsoft.AspNetCore.Mvc;
using Recipe.API.BusinessLogics.Interfaces;
using Recipe.API.Models.Dtos;

namespace Recipe.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RecipeController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IControllerExecutor _controllerExecutor;
        private readonly IRecipeBL _recipeBL;

        public RecipeController(ILogger<RecipeController> logger, IControllerExecutor controllerExecutor, IRecipeBL recipeBL)
        {
            _logger = logger;
            _controllerExecutor = controllerExecutor;
            _recipeBL = recipeBL;
        }

        [HttpPost]
        public Task<IActionResult> CreateRecipe([FromBody] RecipeDto recipeDto)
            => _controllerExecutor.ExecuteAsync(this, () => _recipeBL.CreateRecipe(recipeDto));

        [HttpPut]
        [Route("{recipeId}")]
        public Task<IActionResult> UpdateRecipe([FromRoute] Guid recipeId, [FromBody] RecipeDto recipeDto)
            => _controllerExecutor.ExecuteAsync(this, () => _recipeBL.UpdateRecipe(recipeId, recipeDto));

        [HttpGet]
        [Route("{recipeId}")]
        public Task<IActionResult> GetRecipeById([FromRoute] Guid recipeId)
            => _controllerExecutor.ExecuteAsync(this, () => _recipeBL.GetRecipeById(recipeId));

        [HttpDelete]
        [Route("{recipeId}")]
        public Task<IActionResult> DeleteRecipeById([FromRoute] Guid recipeId)
            => _controllerExecutor.ExecuteAsync(this, () => _recipeBL.DeleteRecipeById(recipeId));

        [HttpPost]
        [Route("search")]
        public Task<IActionResult> SearchRecipe([FromBody] SearchRecipeDto searchRecipeDto)
            => _controllerExecutor.ExecuteAsync(this, () => _recipeBL.SearchRecipe(searchRecipeDto));
    }
}
