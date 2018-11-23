using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentorshipProjectRepository.Transfers;
using MentorshipProjectModels;
using WPFMentorshipProject;

namespace MentorshipProjectRepository
{
	public class TransfersRepository<Transfer> : Repository<Transfer>, ITransfersRepository<Transfer>
	{
		public TransfersRepository(TransferContext context) : base(context)
		{
		}

		public Task<IEnumerable<Transfer>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Transfer> GetByIdAsync(long id)
		{
			throw new NotImplementedException();
		}
	}
}
