
namespace Recipe.Infrastructure.Entities
{
    public class RecipeEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public List<RecipeIngredientEntity>? RecipeIngredients { get; set; }
        public List<CategoryEntity>? Categories { get; set; }
    }
}
