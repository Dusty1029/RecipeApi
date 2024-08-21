using CommonV2.Infrastructure.Repository;
using CommonV2.Infrastructure.Services.Interfaces;
using Recipe.Infrastructure.Entities;
using Recipe.Infrastructure.Repositories.Interfaces;

namespace Recipe.Infrastructure.Repositories.Implementations
{
    public class RecipeRepository : GenericRepository<RecipeContext, RecipeEntity>, IRecipeRepository
    {
        public RecipeRepository(RecipeContext context, ICancellationTokenService cancellationTokenService) : base(context, cancellationTokenService)
        {
        }
    }
}
