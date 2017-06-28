/*
 * Program Name: Big Bucks Bank ATM 
 * Programmer: Oleksii Butakov
 * 
 * Course: CIT-287 (OOPL for Java Programmers)
 * Professor: Arland J. Richmond
 * Institution: Bunker Hill Community College
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Bucks_Bank
{
    /// <summary>
    /// Class that holds information about bank's customer 
    /// </summary>
    public class BankAccount
    {
        public BankAccount()
        {

        }

        public BankAccount(string user_id, string _password, string _checkingAccountNum, string _savingsAccountNum, double _checkingBalance, double _savingsBalance)
        {
            this.UserId = user_id;
            this.Password = _password;
            this.CheckingAccountNumber = _checkingAccountNum;
            this.SavingsAccountNumber = _savingsAccountNum;
            this.CheckingBalance = _checkingBalance;
            this.SavingsBalance = _savingsBalance;
        }

        public string UserId { get; set; }

        public string Password { get; set; }

        public string CheckingAccountNumber { get; set; }

        public string SavingsAccountNumber { get; set; }

        public double CheckingBalance { get; set; }

        public double SavingsBalance { get; set; }

        public override string ToString()
        {
            StringBuilder tempStr = new StringBuilder();

            tempStr.AppendLine("User ID: " + this.UserId);
            tempStr.AppendLine("Password: " + this.Password.ToString());
            tempStr.AppendLine("Checking Account #: " + this.CheckingAccountNumber);
            tempStr.AppendLine("Savings Account #: " + this.SavingsAccountNumber.ToString());
            tempStr.AppendLine("Checking Balance: " + this.CheckingBalance);
            tempStr.AppendLine("Savings Balance: " + this.SavingsBalance.ToString());

            return tempStr.ToString();
        }
    }
}
