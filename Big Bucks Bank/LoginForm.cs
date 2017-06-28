/*
 * Program Name: Big Bucks Bank ATM 
 * Programmer: Oleksii Butakov
 * 
 * Course: CIT-287 (OOPL for Java Programmers)
 * Professor: Arland J. Richmond
 * Institution: Bunker Hill Community College
 * 
 * NOTE: Click Help icon for all information necessary to login 
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
    public partial class LoginForm : Form
    {

        // User attempt counter  
        private static Int16 attemptCounter = 0;

        // hint-text 
        private string strHintLogin = "Enter username...";
        private string strHintPass = "Enter password...";

        // initializing admin account
        private static BankAccount admin = new BankAccount("A1234567", "1234", "", "", 0.0, 0.0);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // setting backgroud image 
            this.BackgroundImage = Image.FromFile
                (Directory.GetParent
                (Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\background_light.png");

            /* Loading the Logo using FileStreamer 
             * because otherwise I'm having troubles with the Image Disposal 
             * after I close my forms 
            */
            FileStream bmp = new FileStream
               (Directory.GetParent
               (Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\bigbucks_logo.png", FileMode.Open, FileAccess.Read);
            Image img = new Bitmap(bmp);
            pictureBox1.Image = img;
            bmp.Close();

            // Clearing all the textfields 
            clearAll();

            // Hidding "Unlock" button 
            btnUnlock.Visible = false;

            // Shows hint-text to the user 
            showHints();
        }

        /// <summary>
        /// Sets hint-text for both username and password fields if there is no input present
        /// </summary>
        private void showHints()
        {
            // If textboxes with login and password is empty - shows hint-text
            if (txtUserId.Text == "")
            {
                txtUserId.Text = strHintLogin;
                txtUserId.Font = new Font(txtUserId.Font, FontStyle.Italic);
            }
            if (txtPassword.Text == "")
            {
                txtPassword.Text = strHintPass;
                txtPassword.PasswordChar = '\0';
                txtPassword.Font = new Font(txtUserId.Font, FontStyle.Italic);
            }
        }

        /// <summary>
        /// Removes password's hint-text
        /// </summary>
        private void removePasswordHint()
        {
            // Erasing hint-text and setting bold font for further user input
            txtPassword.Text = "";
            txtPassword.Font = new Font(txtPassword.Font, FontStyle.Bold);
            // asterisk characters instead if SSN 
            txtPassword.PasswordChar = '*';
        }

        /// <summary>
        /// Removes username's textbox username-hint text 
        /// </summary>
        private void removeUsernameHint()
        {

            // Erasing hint-text and setting bold font for further user input
            txtUserId.Text = "";
            txtUserId.Font = new Font(txtUserId.Font, FontStyle.Bold);
        }

        /// <summary>
        /// Removes hint-text from both username nand password fields.
        /// </summary>
        private void removeHints()
        {
            removePasswordHint();
            removeUsernameHint();
        }

        // Set hint-text if user left and didn't left any input
        private void txtUserIf_Leave(object sender, EventArgs e)
        {
            // Showing hint-text to the user if no input left
            if (txtUserId.Text == "")
            {
                txtUserId.Text = strHintLogin;
                txtUserId.Font = new Font(txtUserId.Font, FontStyle.Italic);
            }
        }

        // Set hint-text if user left and didn't left any input
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            // Showing hint-text to the user if no input left
            if (txtPassword.Text == "")
            {
                //sending asterisk character from the password field textbox to the Null-land 
                txtPassword.PasswordChar = '\0';

                //returning hint-text to the password textbpx
                txtPassword.Text = strHintPass;
                txtPassword.Font = new Font(txtUserId.Font, FontStyle.Italic);
            }
        }

        /// <summary>
        /// returns "true" if user has account in the system, "false" - if hasn't.  
        /// </summary>
        /// <returns></returns>
        private bool hasAccount()
        {
            bool temp = false;

            if (txtUserId.Text == BankDB.account.UserId && txtPassword.Text == BankDB.account.Password)
            {
               txtErrorBox.Text = "Access Granted!";
               temp =  true;
            }
            else
            {
                txtErrorBox.Text = "Invalid Username or Password. Try again!";
            }

            return temp;

        }

        private void txtUserId_Click(object sender, EventArgs e)
        {
            removeUsernameHint();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            removePasswordHint();

        }

        /// <summary>
        /// Locks UI, by removing Login and Clear buttons, and making "unlock" button visible 
        /// </summary>
        private void lockUI()
        {
            btnLogin.Visible = false;
            btnClear.Visible = false;
            btnUnlock.Visible = true;
            txtErrorBox.BackColor = Color.LightCoral;
        }

        /// <summary>
        /// Makes login and clear buttons visible, removes "unlock" button
        /// </summary>
        private void unlockUI()
        {
            btnLogin.Visible = true;
            btnClear.Visible = true;
            btnUnlock.Visible = false;
            txtErrorBox.BackColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtUserId) && Validator.IsPresent(txtPassword))
            { 
                if (hasAccount())
                {

                    MenuForm menuForm = new MenuForm();
                    menuForm.Tag = this;
                    menuForm.Show(this);

                    this.Visible = false;
                }
                else
                    attemptCounter++;
            }

            // Lock UI if more then 3 invalid attempts to login
            if(attemptCounter % 3 == 0 && attemptCounter != 0)
            {
                txtErrorBox.Text = "PLEASE SEE A BANK OFFICER - NO FURTHER LOGIN ATTEMPTS!";
                lockUI();
            }
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Cleans all the textfields from the form 
        /// </summary>
        private void clearAll()
        {
            txtUserId.Text = "";
            txtPassword.Text = "";
            txtErrorBox.Text = "";
        }

        // "Clear" button
        private void button1_Click(object sender, EventArgs e)
        {
            clearAll();
            showHints();
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {

            if (txtUserId.Text == admin.UserId && txtPassword.Text == admin.Password)
            {
                txtErrorBox.Text = "Access Granted!";
                unlockUI();

            }
        }

        private void cbChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (cboShow.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
        }

        private void LoginForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            // Showing default account information
            StringBuilder temp = new StringBuilder();
            temp.AppendLine("Default User Information");
            temp.AppendLine("");
            temp.AppendLine(BankDB.account.ToString());
            temp.AppendLine("Admin's Information");
            temp.AppendLine("");
            temp.AppendLine(admin.ToString());

            MessageBox.Show(temp.ToString(), "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            clearAll();

            showHints();
        }
    }
}
