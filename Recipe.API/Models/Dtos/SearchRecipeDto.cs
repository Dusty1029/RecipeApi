namespace Recipe.API.Models.Dtos
{
    public class SearchRecipeDto
    {
        public int Size { get; set; }
        public int Page { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
