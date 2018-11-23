using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentorshipProjectModels;
using WPFMentorshipProject;

namespace MentorshipProjectRepository
{
	public abstract class Repository<TEntity>
	{
		protected TransferContext context;

		protected Repository(TransferContext context)
		{
			this.context = context;
		}
	}
}
