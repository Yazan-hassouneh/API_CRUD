namespace API_CRUD.Models
{
	public class ProductOrder
	{
		public int ProductId { get; set; }
		public Product Product { get; set; } = null!;
		public int OrderId { get; set; }
		public int ProductCount { get; set; }
	}
}
