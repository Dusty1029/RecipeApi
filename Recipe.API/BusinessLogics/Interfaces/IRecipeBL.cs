using CommonV2.Models;
using Recipe.API.Models.Dtos;

namespace Recipe.API.BusinessLogics.Interfaces
{
    public interface IRecipeBL
    {
        Task<Guid> CreateRecipe(RecipeDto recipeDto);
        Task UpdateRecipe(Guid id, RecipeDto recipeDto);
        Task<RecipeDto> GetRecipeById(Guid id);
        Task DeleteRecipeById(Guid id);
        Task<PaginationResult<RecipeDto>> SearchRecipe(SearchRecipeDto searchRecipe);

    }
}
