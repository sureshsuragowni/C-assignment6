using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDetails
{
    public class TransactionEventArgs : EventArgs
    {
        public int TranactionAmount { get; set; }
        public string TranactionType { get; set; }

        public TransactionEventArgs(int amt, string type)
        {
            TranactionAmount = amt;
            TranactionType = type;
        }
    }
    public delegate void TransactionHandler(object sender, TransactionEventArgs e);
    public class MyEvent
    {
        public event TransactionHandler TransactionMade;  
        public int BalanceAmount;  

        public MyEvent(int amount)  
        {
            this.BalanceAmount = amount;
        }


        public void Debit(int debitAmount) 
        {
            if (debitAmount < BalanceAmount)
            {
                BalanceAmount = BalanceAmount - debitAmount;
                TransactionEventArgs e = new TransactionEventArgs(debitAmount, "Debited");//event
                OnTransactionMade(e); 
            }
        }



        public void Credit(int creditAmount)  //credit or deposit method
        {

            BalanceAmount = BalanceAmount + creditAmount;
            TransactionEventArgs e = new TransactionEventArgs(creditAmount, "Credited"); //event
            OnTransactionMade(e); // Credit transaction made

        }



        public void ZeroBalance()
        {
            BalanceAmount = 0;
            TransactionEventArgs e = new TransactionEventArgs(0, "ZeroBalanceFound"); 
            OnTransactionMade(e);
        }



        protected virtual void OnTransactionMade(TransactionEventArgs e)  
        {
            if (TransactionMade != null) 
            {
                TransactionMade(this, e); 
            }
        }
    }
    public class TestMyEvent
    {
        private static void SendNotification(Object sender, TransactionEventArgs e) //it should match with delegate returntype
        {
            Console.WriteLine("Your Account is {0} for Rs.{1} ", e.TranactionType, e.TranactionAmount);

            //Console.WriteLine("Your Account is UnderBalance",e.TranactionType, e.TranactionAmount);
        }

        private static void Main(String[] args)
        {
            Console.WriteLine("   Mini Statement  ");
            MyEvent ac2 = new MyEvent(200);

            if (ac2.BalanceAmount > 500)
            {
                ac2.TransactionMade += new TransactionHandler(SendNotification);
            }
            else if (ac2.BalanceAmount < 500 && ac2.BalanceAmount > 0)
            {
        
                Console.WriteLine("Your account is UnderBalance");
            }
            else if (ac2.BalanceAmount == 0)
            {
                ac2.ZeroBalance();
                ac2.TransactionMade += new TransactionHandler(SendNotification);
            }
            
            ac2.Credit(2000);
            Console.WriteLine("Your Current Balance is : " + ac2.BalanceAmount);
            Console.ReadLine();
            Console.WriteLine("* Rs 999 is Auto debited as Maintainance charge by Your Bank");
            Console.WriteLine("Press enter to view Total balance");
            Console.ReadKey();
            ac2.Debit(500);
            Console.WriteLine("Your Current Balance is : " + ac2.BalanceAmount);
            Console.ReadLine();
        }
    }
}