using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class signup : Form
    {
        DBAccess objdBAccess = new DBAccess();
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sign_Click(object sender, EventArgs e)
        {
            string name = na.Text;
            string email = ema.Text;
            string password = pas.Text;

            if (name.Equals(""))
            {
                MessageBox.Show("Enter your name");
            }
            else if (email.Equals(""))
            {
                MessageBox.Show("Enter your email");
            }
            else if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Please enter a valid Gmail address (e.g., example@gmail.com)");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Enter your password");
            }
            else if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long");
            }
            else
            {
                // MessageBox.Show("Sign up successful");
                SqlCommand insertcommand = new SqlCommand("INSERT INTO users (name, email, password) VALUES (@name, @Email, @Password)");
                insertcommand.Parameters.AddWithValue("@name", name);
                insertcommand.Parameters.AddWithValue("@Email", email);
                insertcommand.Parameters.AddWithValue("@Password", password);
                int row = objdBAccess.executeQuery(insertcommand);
                if (row == 1)
                {
                    SqlCommand insertRowStyleCommand = new SqlCommand(@"
            INSERT INTO DataGridStyles (Email, Target, ForeColor, BackColor, SelectionForeColor, SelectionBackColor, FontName)
            VALUES (@Email, 'Rows', 'Black', 'White', 'Coral', 'LawnGreen', 'Arial')");
                    insertRowStyleCommand.Parameters.AddWithValue("@Email", email);
                    objdBAccess.executeQuery(insertRowStyleCommand);

                    // Insert default styles for headers
                    SqlCommand insertHeaderStyleCommand = new SqlCommand(@"
            INSERT INTO DataGridStyles (Email, Target, ForeColor, BackColor, SelectionForeColor, SelectionBackColor, FontName)
            VALUES (@Email, 'Headers', 'White', 'Black', 'Coral', 'LawnGreen', 'Arial')");
                    insertHeaderStyleCommand.Parameters.AddWithValue("@Email", email);
                    objdBAccess.executeQuery(insertHeaderStyleCommand);

                    MessageBox.Show("Sign up successful");
                    this.Hide();
                    Form2 log = new Form2();
                    log.Show();

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void na_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            { 
                ema.Focus(); 
            }
        }

        private void ema_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {

                string email = ema.Text;
                if (objdBAccess.CheckEmailExists(email))
                {
                    MessageBox.Show("Email already exists. Please use a different email.");
                    ema.Clear();
                }
                else
                {
                    pas.Focus();
                }
            }

        }

        private void pas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { sign.PerformClick(); }
        }

        private void ema_TextChanged(object sender, EventArgs e)
        {

        }
    }
}