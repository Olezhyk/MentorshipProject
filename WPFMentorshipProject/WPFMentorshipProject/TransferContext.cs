﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMentorshipProject
{
	class TransferContext : DbContext
	{
		public TransferContext() : base("DbConnection")
		{
		}

		public DbSet<Country> Countries { get; set; }
		public DbSet<Federation> Federations { get; set; }
		public DbSet<Player> Players { get; set; }
		public DbSet<PlayerPosition> PlayerPositions { get; set; }
		public DbSet<Team> Teams { get; set; }
		public DbSet<Transfer> Transfers { get; set; }
	}
}
