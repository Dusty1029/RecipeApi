using CommonV2.Models;
using CommonV2.Models.Exceptions;
using Recipe.API.BusinessLogics.Interfaces;
using Recipe.API.Extensions.Entities;
using Recipe.API.Models.Dtos;
using Recipe.Infrastructure.Entities;
using Recipe.Infrastructure.Repositories.Interfaces;

namespace Recipe.API.BusinessLogics.Implementations
{
    public class RecipeBL : IRecipeBL
    {
        private readonly IRecipeRepository _recipeRepository;

        public RecipeBL(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public async Task<Guid> CreateRecipe(RecipeDto recipeDto)
        {
            var recipe = await _recipeRepository.InsertAndSave(recipeDto.ToEntity());

            return recipe.Id;
        }

        public async Task UpdateRecipe(Guid id, RecipeDto recipeDto)
        {
            var recipe = await GetRecipeEntityById(id, false);

            recipeDto.ToEntity(recipe);
            await _recipeRepository.SaveChanges();
        }

        public async Task<RecipeDto> GetRecipeById(Guid id)
        {
            var recipe = await GetRecipeEntityById(id);

            return recipe.ToDto();
        }

        public async Task DeleteRecipeById(Guid id)
        {
            var recipe = await GetRecipeEntityById(id);

            await _recipeRepository.DeleteAndSave(recipe);
        }

        public async Task<PaginationResult<RecipeDto>> SearchRecipe(SearchRecipeDto searchRecipe)
        {
            var recipes = await _recipeRepository.Search(searchRecipe.Size, searchRecipe.Page, r => r.Name.ToLower().Contains(searchRecipe.Name.ToLower()));

            return new()
            {
                TotalItems = recipes.TotalItems,
                Items = recipes.Items.Select(x => x.ToDto())
            };
        }

        private async Task<RecipeEntity> GetRecipeEntityById(Guid id, bool noTracking = true)
        {
            var recipe = await _recipeRepository.Find(r => r.Id == id, noTracking: noTracking);
            if (recipe is null)
                throw new NotFoundException($"The recipe with Id [{id}] was not found.");

            return recipe;
        }
    }
}
