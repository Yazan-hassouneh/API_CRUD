using API_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_CRUD.Configuration.ModelsConfig
{
	public class ProductOrderConfig : IEntityTypeConfiguration<ProductOrder>
	{
		public void Configure(EntityTypeBuilder<ProductOrder> builder)
		{
			builder.HasKey(model => new { model.OrderId, model.ProductId });
			builder.Property(model => model.ProductCount).HasDefaultValue(1);
		}
	}
}
