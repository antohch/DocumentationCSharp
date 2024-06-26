﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Bank8
{
    internal class BankAccount
    {
        private readonly decimal _minimumBalance;
        public string Number { get; }
        public string Owner { get; set; }

        public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
        {
            Number = s_accountNumberSeed.ToString();
            s_accountNumberSeed++;

            Owner = name;
            _minimumBalance = minimumBalance;
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }
        public decimal Balance 
        { 
            get 
            {
                decimal balance = 0;
                foreach (var item in _allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            } 
        }
        private static int s_accountNumberSeed = 1234567890;
        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0)
        {
            Number = s_accountNumberSeed.ToString();
            s_accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }
        private List<Transaction> _allTransactions = new List<Transaction>();
        public void MakeDeposit(decimal amount, DateTime date, string note)
        { 
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        { 
            //if (amount <= 0)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            //}
            //if ( Balance - amount < _minimumBalance)
            //{
            //    throw new InvalidOperationException("No sufficient funds for this withdrawal");
            //}
            //var withdrawal = new Transaction(-amount, date, note);
            //_allTransactions.Add(withdrawal);
        }
        protected virtual Transaction CheckWithdrawalLimit(bool isOverdrawn)
        {
            return new Transaction(10, DateTime.Now, "10");
        }
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();
            decimal balance = 0;
            report.AppendLine("Data\t\tAmount\tBalance\tNote");
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }
            return report.ToString();
        }
        public virtual void PerformMonthEndTransactions() { }
    }
}
