using Recipe.API.BusinessLogics.Implementations;
using Recipe.API.BusinessLogics.Interfaces;
using Recipe.Infrastructure.Extensions;

namespace Recipe.API.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddBusinessLogics();
        }

        public static void AddBusinessLogics(this IServiceCollection services)
        {
            services.AddScoped<IRecipeBL, RecipeBL>();
        }
    }
}
