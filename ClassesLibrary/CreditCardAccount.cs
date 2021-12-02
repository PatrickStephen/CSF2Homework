using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //frugal / fields
        private int _accountNbr;
        //people / properties
        public int AccountNbr { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        //collect / constructors (ctors)
        public CreditCardAccount(int accountNbr, Customer customerInfo,decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNbr = accountNbr;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }
        //money / methods
        public CreditCardAccount() { }
        public override string ToString()
        {
            return string.Format("Account number: {0}\n" +
                                 "{1}" +
                                 "balance is: {2}\n" +
                                 "is it past due? {3}\n" +
                                 "your intrest rate is: {4}\n",
                                 AccountNbr,
                                 CustomerInfo,
                                 Balance,
                                 IsPastDue,
                                 AnnualInterestRate);
        }
    }
}
