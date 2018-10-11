using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMentorshipProject
{
    public class Player
    {
        public Guid Id { get; set; }

        public Team Team { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public PlayerPosition PlayerPosition { get; set; }

        public int Age { get; set; }

        public Country PlayerNationality { get; set; }

        public decimal Price { get; set; }

        public bool IsInTransfer { get; set; }
    }
}
