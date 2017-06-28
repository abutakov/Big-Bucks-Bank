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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
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

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm();
            depositForm.Tag = this;
            depositForm.Show(this);

            this.Visible = false;

        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            WithdrawalForm withdrawwalForm = new WithdrawalForm();
            withdrawwalForm.Tag = this;
            withdrawwalForm.Show(this);

            this.Visible = false;

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            BalanceForm balanceForm = new BalanceForm();
            balanceForm.Tag = this;
            balanceForm.Show(this);

            this.Visible = false;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Transfer_Funds transferForm = new Transfer_Funds();
            transferForm.Tag = this;
            transferForm.Show(this);

            this.Visible = false;

        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var loginForm = (LoginForm)Tag;
                loginForm.Visible = true;

                this.Close();
            }
        }
    }
}
