using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentorshipProjectRepository.Players;
using MentorshipProjectModels;
using WPFMentorshipProject;

namespace MentorshipProjectRepository
{
	public class PlayersRepository<Player> : Repository<Player>, IPlayersRepository<Player>
	{
		public PlayersRepository(TransferContext context) : base(context)
		{
		}

		public Task<IEnumerable<Player>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Player> GetByIdAsync(long id)
		{
			throw new NotImplementedException();
		}

		public Task CreateAsync(Player item)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(Player item)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(Player item)
		{
			throw new NotImplementedException();
		}

		public Task SaveAsync()
		{
			throw new NotImplementedException();
		}
	}
}
