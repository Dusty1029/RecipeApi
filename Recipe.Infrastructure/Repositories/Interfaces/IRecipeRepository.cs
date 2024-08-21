using CommonV2.Infrastructure.Repository;
using Recipe.Infrastructure.Entities;

namespace Recipe.Infrastructure.Repositories.Interfaces
{
    public interface IRecipeRepository : IGenericRepository<RecipeContext, RecipeEntity>
    {
    }
}
