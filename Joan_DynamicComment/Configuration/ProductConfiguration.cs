using System;
using Joan_DynamicComment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Joan_DynamicComment.Configuration
{
	public class ProductConfiguration:IEntityTypeConfiguration<Product>
	{
		public ProductConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.CreatedAt).HasDefaultValueSql("getdate()");
        }
    }
}

