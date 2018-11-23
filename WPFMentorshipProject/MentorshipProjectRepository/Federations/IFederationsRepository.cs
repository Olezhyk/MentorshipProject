using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentorshipProjectModels;

namespace MentorshipProjectRepository.Federations
{
	interface IFederationsRepository
	{
		Task<IEnumerable<Federation>> GetAllAsync();

		Task<Federation> GetByIdAsync(long id);

		Task CreateAsync(Federation item);

		Task UpdateAsync(Federation item);

		Task DeleteAsync(Federation item);

		Task SaveAsync();
	}
}
