using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEf
{
    public class Accounts
    {
		public int id { get; set; }
		[Required]
		[StringLength(250)]
		public string Name { get; set; }
		[Required]
		[StringLength(100)]
		public string ClientName { get; set; }
		[Required]
		public decimal Balance { get; private set; }
		[Required]
		public string AccNum { get; set; }

		public void Deposit(Decimal DepAmt) {
			if(DepAmt < 0) {
				throw new Exception("Deposit amount cannot be negative");
			}
			Balance += DepAmt;
		}

		public void Withdrawal(Decimal WithAmt) {
			if(WithAmt > Balance) {
				throw new Exception("Deposit amount cannot be negative");
			}
			Balance -= WithAmt;
		}

		public Accounts(string name, decimal balance, string clientName, string accNum) {
			Name = name;
			Deposit(balance);
			ClientName = clientName;
			AccNum = accNum;
		}

		public Accounts() { }
	}
}
