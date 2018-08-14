using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEf;

namespace BankWithEf { 
	public class Program {
		private static BankDbContext db = new BankDbContext();
		static void Main(string[] args) {
			Checkings Chk1 = new Checkings("Jon Checking", "Jon Wilson", 500, "545656455");
			db.Checkings.Add(Chk1);
		}
	}
}
