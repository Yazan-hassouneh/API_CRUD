﻿
namespace API_CRUD.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
		public int CategoryId { get; set; }
		public Category Category { get; set; } = null!;
	}
}