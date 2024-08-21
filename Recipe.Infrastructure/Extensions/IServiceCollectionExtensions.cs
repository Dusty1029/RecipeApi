using Microsoft.Extensions.DependencyInjection;
using Recipe.Infrastructure.Repositories.Implementations;
using Recipe.Infrastructure.Repositories.Interfaces;

namespace Recipe.Infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRecipeRepository, RecipeRepository>();
        }
    }
}
