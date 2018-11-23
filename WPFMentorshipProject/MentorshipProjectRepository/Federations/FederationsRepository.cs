using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentorshipProjectRepository.Federations;
using MentorshipProjectModels;
using WPFMentorshipProject;

namespace MentorshipProjectRepository
{
	public class FederationsRepository<Federation> : Repository<Federation>, IFederationsRepository
	{
		public FederationsRepository(TransferContext context) : base(context)
		{
		}

		public async Task<MentorshipProjectModels.Federation> GetByIdAsync(byte id)
		{
			return await context.Federations.FirstOrDefaultAsync(x => x.Id == id);
		}

		public Task<IEnumerable<MentorshipProjectModels.Federation>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<MentorshipProjectModels.Federation> GetByIdAsync(long id)
		{
			throw new NotImplementedException();
		}

		public Task CreateAsync(MentorshipProjectModels.Federation item)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(MentorshipProjectModels.Federation item)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(MentorshipProjectModels.Federation item)
		{
			throw new NotImplementedException();
		}

		public Task SaveAsync()
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(Federation item)
		{
			throw new NotImplementedException();
		}
	}
}
