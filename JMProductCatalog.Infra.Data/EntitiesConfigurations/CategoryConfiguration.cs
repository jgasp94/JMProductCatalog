using JMProductCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace JMProductCatalog.Infra.Data.EntitiesConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();

            #region Initial Values
            builder.HasData(
                    new Category(Guid.Parse("06b5594a-7503-4bd8-b210-47d41b364634"), "Material Escolar"),
                    new Category(Guid.Parse("47f617e9-3135-4cc1-9d0e-4e1d9476536a"), "Jogos"),
                    new Category(Guid.Parse("8860d9a5-8269-4e00-8381-36ddeac332cf"), "Acessórios para Celular")
               );
            #endregion

        }
    }
}
