using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorshipProjectRepository.Transfers
{
	interface ITransfersRepository<TEntity>
	{
		Task<IEnumerable<TEntity>> GetAllAsync();

		Task<TEntity> GetByIdAsync(long id);
	}
}
