using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordtxtbox_TextChanged(object sender, EventArgs e)
        {

            // password character is asterisk
            passwordtxtbox.PasswordChar = '*';

        }

        private void passwordbtn_Click(object sender, EventArgs e)
        {
            string password = passwordtxtbox.Text;

            if (passwordtxtbox.Text == "georgian")
            {
                MessageBox.Show("Password accepted. Please continue");
            }
            else
            {
                MessageBox.Show("Incorrect password. PLease try again");
            }
        }

    }
}
