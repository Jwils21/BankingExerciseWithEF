using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEf {
	public class Checkings : Accounts {
		public static int NextChkNum { get; set; } = 1;
		public string Payee { get; set; }

		public void WriteChk(decimal Amt, string payee) {
			int ChkNbr = NextChkNum++;
			this.Payee = payee;
			Withdrawal(Amt);
		}

		public Checkings(string accName, string clientName, decimal BegBal, string accNum) : base(accName,BegBal,clientName,accNum) { 
			
		}

		public Checkings() { }

	}
}
