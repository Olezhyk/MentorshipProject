using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorshipProjectModels
{
	public class Transfer
	{
		public Guid TransferId { get; set; }

		public Guid PlayerId { get; set; }

		public Guid SellTeamId { get; set; }

		public Guid BuyTeamId { get; set; }

		public decimal Price { get; set; }

		public DateTime TransferDate { get; set; }
	}
}
