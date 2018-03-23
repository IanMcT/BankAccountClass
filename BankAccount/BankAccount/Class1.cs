using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McTBank
{
    /// <summary>
    /// Creates a bank account that you can deposit and withdraw money
    /// </summary>
    public class BankAccount
    {
        private double m_balance;

        /// <summary>
        /// Your balance is set to $0 when created
        /// </summary>
        public BankAccount()
        {
            m_balance = 0;
        }
        /// <summary>
        /// Your balance is set to the amount
        /// </summary>
        /// <param name="b">The amount to add</param>
        public BankAccount(double b)
        {
            m_balance = b;
        }
        /// <summary>
        /// Gets the current balance
        /// </summary>
        public double Balance
        {
            get
            {
                return m_balance;
            }
        }
        /// <summary>
        /// Deposits to the bank account
        /// </summary>
        /// <param name="amount">Must be a positive number.</param>
        public void deposit(double amount)
        {
            if (amount > 0)
            {
                m_balance += amount;
            }
            else {
                throw new Exception("Amount must be a positive number");
            }
        }
        public string withdraw(double amount)
        {
            if (amount > 0 && amount < m_balance)
            {
                m_balance -= amount;
                return "Your balance is now " + m_balance.ToString("$0.00");
            }
            return "You can't withdraw that amount.";
        }

    }
}
