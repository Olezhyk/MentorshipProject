using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentorshipProjectRepository.Teams;
using MentorshipProjectModels;
using WPFMentorshipProject;

namespace MentorshipProjectRepository
{
	public class TeamsRepository<Team> : Repository<Team>, ITeamsRepository<Team>
	{
		public TeamsRepository(TransferContext context) : base(context)
		{
		}

		public Task<IEnumerable<Team>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Team> GetByIdAsync(long id)
		{
			throw new NotImplementedException();
		}

		public Task CreateAsync(Team item)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(Team item)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(Team item)
		{
			throw new NotImplementedException();
		}

		public Task SaveAsync()
		{
			throw new NotImplementedException();
		}
	}
}
