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
    public partial class WithdrawalForm : Form
    {
        public WithdrawalForm()
        {
            InitializeComponent();
        }

        private void WithdrawalForm_Load(object sender, EventArgs e)
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

            if (Validator.IsPresent(txtAccNumber) && Validator.IsPresent(txtAmount))
            {
                if (txtAccNumber.Text == BankDB.account.CheckingAccountNumber || txtAccNumber.Text == BankDB.account.SavingsAccountNumber)
                {
                    try
                    {
                        amount = Convert.ToDouble(txtAmount.Text);
                        if (amount >= 0)
                        {
                            if (txtAccNumber.Text == BankDB.account.CheckingAccountNumber)
                            {
                                if (amount <= BankDB.account.CheckingBalance)
                                {
                                    BankDB.account.CheckingBalance -= amount;
                                    MessageBox.Show("Money has been Withdrawnd from Your Checking Account!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Returning Menu Form
                                    var menuForm = (MenuForm)Tag;
                                    menuForm.Visible = true;

                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Insufficient Funds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (amount <= BankDB.account.SavingsBalance)
                                {
                                    BankDB.account.SavingsBalance -= amount;
                                    MessageBox.Show("Money has been Withdrawn from Your Savings Account!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Returning Menu Form
                                    var menuForm = (MenuForm)Tag;
                                    menuForm.Visible = true;

                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Insufficient Funds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Amount can't de negative value!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Please enter numeric value into the \"Amount\" field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }
                    else
                    {
                        MessageBox.Show("Invalid account number!", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

        private void label2_Click(object sender, EventArgs e)
        {

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
