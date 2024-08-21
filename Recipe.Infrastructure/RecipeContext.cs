using Microsoft.EntityFrameworkCore;
using Recipe.Infrastructure.Entities;

namespace Recipe.Infrastructure
{
    public class RecipeContext: DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RecipeEntity).Assembly);
        }
    }
}
