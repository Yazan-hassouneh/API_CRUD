using API_CRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
namespace API_CRUD.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
	}
}