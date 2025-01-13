using BotanicalApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BotanicalApp.Data
{
	public class AppDbContext:IdentityDbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		DbSet<Settings> Settings { get; set; }
		DbSet<Product> Products { get; set; }

    }
}
