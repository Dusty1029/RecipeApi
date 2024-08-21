using Recipe.API.Models.Dtos;
using Recipe.Infrastructure.Entities;

namespace Recipe.API.Extensions.Entities
{
    public static class RecipeExtensions
    {
        public static RecipeEntity ToEntity(this RecipeDto recipeDto, RecipeEntity? recipeEntity = null)
        {
            recipeEntity ??= new RecipeEntity();

            recipeEntity.Id = recipeDto.Id;
            recipeEntity.Name = recipeDto.Name;
            recipeEntity.Description = recipeDto.Description;

            return recipeEntity;
        }

        public static RecipeDto ToDto(this RecipeEntity recipeEntity) => new()
        {
            Id = recipeEntity.Id,
            Name = recipeEntity.Name,
            Description = recipeEntity.Description
        };
    }
}
