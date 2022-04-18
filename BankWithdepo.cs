using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankingdepwith
{

    public class BankAccount
    {
        public int AccNumber;
        public string CustomerName;
        public double Balance;

        public BankAccount(int AccNumber, String CustomerName, double Balance)
        {
       
            this.AccNumber = AccNumber;
            this.CustomerName = CustomerName;
            this.Balance = Balance;
        }


        public void Withdraw(double amount)
        {
            Console.WriteLine("Enter amount .......");
            Console.ReadLine();
            

            if (this.Balance > 500)
            {
                if (amount == 100 || amount == 500 || amount == 2000)
                {
                    Console.WriteLine(Balance + " : Rs is your Savings,Please choose Account to withdraw");
                    Console.WriteLine("1.Savings Account");
                    Console.WriteLine("2.Current Account");
                    Console.Read();
                    Console.WriteLine("Your transaction is processing...");
                    double finalbalance = Balance - amount;
                    Console.WriteLine(finalbalance + " : here is your balance after debiting the money, If not done by you please inform the local bank officials ");
                    Console.WriteLine("----------THANK YOU -----------");
                }
                else
                {
                    Console.WriteLine("transaction has beeen declained");
                }

            }
            else if (Balance < 500)
            {
                Console.WriteLine("Your balance is less than 500rs .....");
            }
            else
            {
                Console.WriteLine("Your Session has been Expired!!");
            }

        }
        public void Deposit(double amt)
        {
            Console.WriteLine("Enter the amount you want to deposit ");
            Console.Read();
            if (amt >= 500)
            {
                Console.WriteLine("You transaction is under process....");
                Console.WriteLine("Thank you !! your Transaction is successful");
                double dep = Balance + amt;
                Console.WriteLine(dep + ": Rs is your balance after the deposoition");
                Console.WriteLine("----------THANK YOU FOR AVAILING ATM DEPOSIT SERVICE-----------");
            }
            else if (amt < 500)
            {
                Console.WriteLine("Please deposit more than 500 Rs");
            }
            else
            {
                Console.WriteLine("Invalid Number!!");
            }
        }
    }
    internal class WithdrawDeposit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------WELCOME----------");
            Console.ReadKey();
            BankAccount ac1 = new BankAccount(746454, "Suresh Gowd", 746350);
            ac1.Withdraw(500);

            ;
        }
    }
}