using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorshipProjectRepository.Teams
{
	interface ITeamsRepository<TEntity>
	{
		Task<IEnumerable<TEntity>> GetAllAsync();

		Task<TEntity> GetByIdAsync(long id);

		Task CreateAsync(TEntity item);

		Task UpdateAsync(TEntity item);

		Task DeleteAsync(TEntity item);

		Task SaveAsync();
	}
}
