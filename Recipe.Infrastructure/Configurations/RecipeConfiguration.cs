﻿using CommonV2.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe.Infrastructure.Entities;

namespace Recipe.Infrastructure.Configurations
{
    public class RecipeConfiguration : IEntityTypeConfiguration<RecipeEntity>
    {
        public void Configure(EntityTypeBuilder<RecipeEntity> builder)
        {
            builder.ToTable(nameof(RecipeEntity).ToTableName());
             
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                   .HasMaxLength(256)
                   .IsRequired();

            builder.Property(x => x.Description)
                   .IsRequired(false);

            builder.HasMany(x => x.Categories)
                   .WithMany(x => x.Recipes)
                   .UsingEntity($"{nameof(RecipeEntity).ToTableName()}{nameof(CategoryEntity).ToTableName()}");

            builder.HasMany(x => x.RecipeIngredients)
                   .WithOne(x => x.Recipe)
                   .HasForeignKey(x => x.RecipeId);
        }
    }
}
