﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class BankAccount
    {
        private String AccountHolderName;
        private double balance;

        public BankAccount(String name)
        {
            AccountHolderName = name;
            balance = 0;
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }

        public String GetName()
        {
            return AccountHolderName;
        }

        public double GetBalance()
        {
            return balance;
        }


    }
}
