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
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_Bucks_Bank
{
    /// <summary>
    /// Class that should contain access to all bank's customers information, but according to the specification we have only one customer,
    /// so this class has only one object
    /// </summary>
    static class BankDB
	{
        //private const string dir = @"C:\Users\Alex\documents\visual studio 2015\Projects\Big Bucks Bank\Big Bucks Bank\DB\";
        private static string der = Path.GetDirectoryName(Application.ExecutablePath); // .ExecutablePath);
        // By subrtracting 10 characters from the end of directory, we deleting "\bin\Debug\" portion
        private static string dir = der.Remove(der.Length - 10) + @"\DB\";
        private static string path = dir + "ExistingAccounts.dat";

        /// <summary>
        /// Bank's single customer account
        /// </summary>
        public static BankAccount account = new BankAccount("A1111111", "1111", "C1111111", "S1111111", 15236.0, 23050.0);

       
    }
}
