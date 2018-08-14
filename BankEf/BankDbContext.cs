using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BankEf {
	public class BankDbContext: DbContext {
		public DbSet<Checkings> Checkings { get; set; }

		public BankDbContext() : base() {

		}
	}
}
