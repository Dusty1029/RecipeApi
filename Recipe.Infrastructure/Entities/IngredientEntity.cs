
namespace Recipe.Infrastructure.Entities
{
    public class IngredientEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<RecipeIngredientEntity>? RecipeIngredients { get; set; }
    }
}
