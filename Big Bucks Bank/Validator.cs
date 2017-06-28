using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_Bucks_Bank
{
    public static class Validator
	{
		private static string title = "Entry Error";

		public static string Title
		{
			get
			{
				return title;
			}
			set
			{
				title = value;
			}
		}

		public static bool IsPresent(TextBox textBox)
		{

			if (textBox.Text == "" || textBox.Text == "Enter username..." )
			{
				MessageBox.Show("\"Username\"" + " is a required field.", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textBox.Focus();
				return false;
			}
            if (textBox.Text == "" || textBox.Text == "Enter password...")
            {
                MessageBox.Show("\"Password\"" + " is a required field.", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
                return true;
		}

        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsDouble(TextBox textBox)
        {
            double number = 0;
            if (Double.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an double.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
		{
			decimal number = Convert.ToDecimal(textBox.Text);
			if (number < min || number > max)
			{
				MessageBox.Show(textBox.Tag + " must be between " + min
					+ " and " + max + ".", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

        public static bool IsValidEmail(TextBox textBox)
        {
            if (textBox.Text.IndexOf("@") == -1 ||
                 textBox.Text.IndexOf(".") == -1)
            {
                MessageBox.Show(textBox.Tag + " must be a valid email address.",
                    Title);
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
