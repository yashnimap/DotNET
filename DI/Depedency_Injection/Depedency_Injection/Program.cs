using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depedency_Injection
{
    internal class Program
    {
        public interface IAccount 
        {
            void Print_Details();  
        }
        public class Current_Account : IAccount
        {
            public void Print_Details()
            {
                Console.WriteLine("Current account details");
            }
        }
        public class Saving_Account : IAccount 
        {
            public void Print_Details()
            {
                Console.WriteLine("Saving account details");
            }
        }
        public class Account 
        {
            public IAccount account { get; set; }
            //private IAccount account;
            //public Account(IAccount account)
            //{
            //    this.account = account;
            //}

            public void Print_Account() 
            {
                account.Print_Details();
            }
        }
        static void Main(string[] args)
        {
            //IAccount ca = new Current_Account();
            //Account account = new Account(ca);
            //account.Print_Account();

            //IAccount sa = new Saving_Account();
            //Account account1 = new Account(sa);
            //account1.Print_Account();


            Account sa = new Account();
            sa.account = new Saving_Account();
            sa.Print_Account();

            Account ca = new Account();
            ca.account = new Current_Account();
            ca.account.Print_Details();


        }
    }
}
