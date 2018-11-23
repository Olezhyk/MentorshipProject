using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMentorshipProject
{
    public class Team
    {
        public Guid Id { get; set; }

        public Federation Federation { get; set; }

        public string TeamName { get; set; }

        public decimal Budget { get; set; }
    }
}
