using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Repositories;

public class UserRepository()
{
	public async Task Add(User user)
	{
		await using var dbContext = new CustomDbContext();
		dbContext.Add(user);
		await dbContext.SaveChangesAsync();
	}

	public async Task<List<User>> List()
	{
		await using var dbContext = new CustomDbContext();

		return await dbContext
			.Set<User>()
			.AsNoTracking()
			.OrderBy(user => user.Id)
			.ToListAsync();
	}

}
