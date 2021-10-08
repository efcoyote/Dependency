using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dependency.DataAccess
{
	public class BaseRepository<TEntity, TContext>
		where TEntity : class
		where TContext : DbContext
	{
		protected readonly TContext dbContext;

		public BaseRepository(TContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<IEnumerable<TEntity>> GetAll()
		{
			return await dbContext.Set<TEntity>().ToListAsync();
		}
	}
}
