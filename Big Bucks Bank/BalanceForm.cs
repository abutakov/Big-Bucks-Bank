/*
 * Program Name: Big Bucks Bank ATM 
 * Programmer: Oleksii Butakov
 * 
 * Course: CIT-287 (OOPL for Java Programmers)
 * Professor: Arland J. Richmond
 * 
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
    public partial class BalanceForm : Form
    {
        public BalanceForm()
        {
            InitializeComponent();

            txtChecking.Text = BankDB.account.CheckingBalance.ToString("c");
            txtSavings.Text = BankDB.account.SavingsBalance.ToString("c");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var menuForm = (MenuForm)Tag;
            menuForm.Visible = true;

            this.Close();
        }

        private void BalanceForm_Load(object sender, EventArgs e)
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
    }
}
