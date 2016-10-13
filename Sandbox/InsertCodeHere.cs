using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            BankAccount account1 = new BankAccount("Natascha");

            Console.WriteLine($"{account1.GetName()} has a bank account balance of {account1.GetBalance()} ");

            account1.Deposit(200);
            account1.Deposit(300);

            Console.WriteLine($"{account1.GetName()} has a bank account balance of {account1.GetBalance()} ");

            account1.Withdraw(100);

            Console.WriteLine($"{account1.GetName()} has a bank account balance of {account1.GetBalance()} ");
            // The LAST line of code should be ABOVE this line
        }
    }
}
