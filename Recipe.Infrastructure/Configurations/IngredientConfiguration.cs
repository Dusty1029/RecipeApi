using CommonV2.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe.Infrastructure.Entities;

namespace Recipe.Infrastructure.Configurations
{
    public class IngredientConfiguration : IEntityTypeConfiguration<IngredientEntity>
    {
        public void Configure(EntityTypeBuilder<IngredientEntity> builder)
        {
            builder.ToTable(nameof(IngredientEntity).ToTableName());

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                   .HasMaxLength(256)
                   .IsRequired();

            builder.HasMany(x => x.RecipeIngredients)
                   .WithOne(x => x.Ingredient)
                   .HasForeignKey(x => x.IngredientId);
        }
    }
}
