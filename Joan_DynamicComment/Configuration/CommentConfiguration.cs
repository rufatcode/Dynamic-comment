using System;
using Joan_DynamicComment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Joan_DynamicComment.Configuration
{
	public class CommentConfiguration:IEntityTypeConfiguration<Comment>
	{
		public CommentConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(x => x.Date).HasDefaultValueSql("getdate()");
        }
    }
}

