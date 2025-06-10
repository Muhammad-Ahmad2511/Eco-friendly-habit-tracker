using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        string nam;
        DBAccess objdBAccess = new DBAccess();
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {
                string email = username.Text;
                if (objdBAccess.CheckEmailExists(email))
                {
                    we.Text = "";
                    password.Focus();
                }
                else
                {
                    
                    we.Text = "Invalid Username";
                    username.Clear();
                    username.Focus();
                }
            }
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            string email = username.Text;
            string pass = password.Text;

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (objdBAccess.CheckPassword(email, pass))
                {
                    wp.Text = "";
                    login.PerformClick();
                }
                else
                {
                    wp.Text = "Invalid Password";
                    password.Clear();
                    password.Focus();
                }
            }
        }

        private void login_Click(object sender, EventArgs e)
        {

            string email = username.Text;
            string userName = objdBAccess.GetUsername(email);
            if (userName != null)
            {
                this.Hide();
                mainpage f1 = new mainpage(userName,email);
                f1.Show();
            }
            else
            {
                MessageBox.Show("Failed to retrieve username.");
            }

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signup f1 = new signup();
            f1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void we_Click(object sender, EventArgs e)
        {

        }

        private void wp_Click(object sender, EventArgs e)
        {

        }
    }
}
