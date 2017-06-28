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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_Bucks_Bank
{
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }


        private void DepositForm_Load(object sender, EventArgs e)
        {
            // Loading the logo
            FileStream bmp = new FileStream
                (Directory.GetParent
                (Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\bigbucks_logo.png", FileMode.Open, FileAccess.Read);
            Image img = new Bitmap(bmp);
            pictureBox1.Image = img;
            bmp.Close();

            // setting backgroud image 
            this.BackgroundImage = Image.FromFile
                (Directory.GetParent
                (Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\background_light.png");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double amount = 0;
            // flag that indicates if operation was successful 
            bool isSuccess = false;

            if (Validator.IsPresent(txtAccNum) && Validator.IsPresent(txtAmount))
            {
                if (txtAccNum.Text == BankDB.account.CheckingAccountNumber || txtAccNum.Text == BankDB.account.SavingsAccountNumber)
                {
                    try
                    {
                        amount = Convert.ToDouble(txtAmount.Text);

                        if (amount >= 0)
                            isSuccess = true;

                    }
                    catch
                    {
                        MessageBox.Show("Please enter numeric value into the \"Amount\" field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (isSuccess)
                    {
                        if (txtAccNum.Text == BankDB.account.CheckingAccountNumber)
                        {
                            BankDB.account.CheckingBalance += amount;
                            MessageBox.Show("Money Deposited to Your Checking Account!", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            BankDB.account.SavingsBalance += amount;
                            MessageBox.Show("Money Deposited to Your Savings Account!", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid account number!", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Returning Menu Form
                    var menuForm = (MenuForm)Tag;
                    menuForm.Visible = true;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid account number!", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Returning Menu Form
            var menuForm = (MenuForm)Tag;
            menuForm.Visible = true;

            this.Close();
        }
    }
}
