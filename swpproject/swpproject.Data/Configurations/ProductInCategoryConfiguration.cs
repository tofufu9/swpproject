using swpproject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace swpproject.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            // Product và Category được set là quan hệ Many-to-many
            builder.HasKey(t => new {t.CategoryId, t.ProductId });
            // Trường chính của 2 bảng liên kết với nhau là CategoryId và ProductId
            builder.ToTable("ProductInCategories");

            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductInCategories)
                .HasForeignKey(pc=>pc.ProductId);

            builder.HasOne(t => t.Category).WithMany(pc => pc.ProductInCategories)
              .HasForeignKey(pc => pc.CategoryId);
        }
    }
}
