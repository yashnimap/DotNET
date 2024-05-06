using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    public class PersonalLoan
    {
        public string AccountNumber { get; set; }
        public string AccounHolderName { get; set; }
        public Loan LoanDetail { get; set; }
        public PersonalLoan(string accountNumber)
        {
            this.AccountNumber = accountNumber;
            this.AccounHolderName = "Sourav";
        }
    }
    public class Loan
    {
        public string AccountNumber { get; set; }
        public float LoanAmount { get; set; }
        public bool IsLoanApproved { get; set; }
        public Loan(string accountNumber)
        {
            Console.WriteLine("Loan loading started");
            this.AccountNumber = accountNumber;
            this.LoanAmount = 1000;
            this.IsLoanApproved = true;
            Console.WriteLine("Loan loading started");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalLoan p = new PersonalLoan("123456");
            //Load Detail started to load
            p.LoanDetail = new Loan("123456");
            Console.WriteLine(p.LoanDetail.AccountNumber);
            Console.WriteLine(p.LoanDetail.IsLoanApproved);
            Console.WriteLine(p.LoanDetail.LoanAmount);
            Console.ReadLine();
        }
    }
}
