using System;
using System.Collections.Generic;
using System.Text;

namespace practiceC_
{
    class Bank
    {
        private string accname="";
        private int accnum;
        private float accbal;
        private float depositnwithdraw;

        public void SetDetails()
        {
            Console.Write("Enter account holder name: ");
            accname = Console.ReadLine();

            Console.Write("Enter " + accname + "'s account number: ");
            accnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter " + accname + "'s account balance: ");
            accbal = Convert.ToSingle(Console.ReadLine());
        }

        public void Deposit()
        {
            Console.Write("\nEnter amount to deposit: ");
            depositnwithdraw = Convert.ToSingle(Console.ReadLine());

            accbal += depositnwithdraw;

            Console.WriteLine("\nAmount deposited successfully");
        }

        public void Withdraw()
        {
            Console.Write("\nEnter amount to withdraw: ");
            depositnwithdraw = Convert.ToSingle(Console.ReadLine());

            accbal -= depositnwithdraw;

            Console.WriteLine("\nAmount withdrawn successfully");
        }

        public static void Transfer(Bank o1, Bank o2)
        {
            if (o1.accbal > 0)
            {
                o2.accbal += o1.accbal;
                o1.accbal = 0;
            }
            else
            {
                Console.WriteLine("Insufficient balance in first account");
            }
        }

        public static void Display(Bank o2)
        {
            Console.WriteLine("\nAccount holder name: " + o2.accname);
            Console.WriteLine(o2.accname + "'s account number: " + o2.accnum);
            Console.WriteLine(o2.accname + "'s account balance: " + o2.accbal);
        }
    }

    class bank_management_system
    {
        static void Main()
        {
            Bank o1 = new Bank();
            Bank o2 = new Bank();

            Console.WriteLine("===================");
            Console.WriteLine("WELCOME TO ABC BANK");
            Console.WriteLine("===================\n");

            o1.SetDetails();
            o2.SetDetails();

            Bank.Transfer(o1, o2);

            Bank.Display(o2);
        }
    }

}
