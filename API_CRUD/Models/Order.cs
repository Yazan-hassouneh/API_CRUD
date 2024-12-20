namespace API_CRUD.Models
{
	public class Order
	{
		public int Id { get; set; }
		public DateTime OrderDate { get; set; }
		public ICollection<ProductOrder> Products { get; set; } = null!;
	}
}
