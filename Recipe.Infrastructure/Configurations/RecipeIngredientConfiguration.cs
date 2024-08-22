using CommonV2.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe.Infrastructure.Entities;

namespace Recipe.Infrastructure.Configurations
{
    public class RecipeIngredientConfiguration : IEntityTypeConfiguration<RecipeIngredientEntity>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredientEntity> builder)
        {
            builder.ToTable(nameof(RecipeIngredientEntity).ToTableName());

            builder.HasKey(x => new {x.RecipeId, x.IngredientId});

            builder.Property(x => x.Quantity)
                   .HasColumnType("decimal(5,2)")
                   .IsRequired();

            builder.Property(x => x.Unity)
                   .IsRequired();
        }
    }
}
