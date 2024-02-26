using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlazorApp;

public class CustomDbContext : DbContext
{
	public DbSet<User> Users { get; set; }

	public CustomDbContext()
	{

	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		string connectionString = "User ID=root;Password=rafa123;Host=localhost;Port=5432;Database=entitystudy;";

		optionsBuilder
			.UseNpgsql(connectionString);
	}

}
