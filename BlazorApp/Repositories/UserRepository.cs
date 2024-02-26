using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Repositories;

public class UserRepository(DbContext dbContext)
{
	DbContext _dbContext = dbContext;

	public void Add(User user)
	{
		_dbContext.Add(user);
	}

	public async Task<List<User>> List()
	{
		return await _dbContext
			.Set<User>()
			.AsNoTracking()
			.OrderBy(user => user.Id)
			.ToListAsync();
	}

}
