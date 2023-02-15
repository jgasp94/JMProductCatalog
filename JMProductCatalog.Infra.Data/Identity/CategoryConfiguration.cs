using JMProductCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace JMProductCatalog.Infra.Data.Identity
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();

            #region Initial Values
            builder.HasData(
                    new Category(Guid.NewGuid(), "Material Escolar"),
                    new Category(Guid.NewGuid(), "Jogos"),
                    new Category(Guid.NewGuid(), "Acessórios para Celular")
               );
           #endregion

        }
    }
}
