using Recipe.Infrastructure.Entities.Enums;

namespace Recipe.Infrastructure.Entities
{
    public class RecipeIngredientEntity
    {
        public Guid RecipeId { get; set; }
        public Guid IngredientId { get; set; }
        public decimal Quantity { get; set; }
        public UnityEnumEntity Unity { get; set; }
        public RecipeEntity? Recipe { get; set; }
        public IngredientEntity? Ingredient { get; set; }
    }
}
