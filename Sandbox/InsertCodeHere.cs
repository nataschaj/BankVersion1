using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            BankAccount account1 = new BankAccount("Natascha");

            Console.WriteLine($"{account1.GetName()} has a balance of {account1.GetBalance()} ");



            // The LAST line of code should be ABOVE this line
        }
    }
}
