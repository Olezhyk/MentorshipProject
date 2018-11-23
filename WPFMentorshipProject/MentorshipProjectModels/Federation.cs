using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MentorshipProjectModels
{
	[DataContract]
	public class Federation
	{
		[DataMember]
		public byte Id { get; set; }

		[DataMember]
		public Country FederationName { get; set; }
	}
}
