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
    public partial class category : Form
    {
        string nam;
        string email;
        public category(string na, string email)
        {
            nam = na;
            InitializeComponent();
            this.email = email;
        }

        private void Back_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            mainpage mp = new mainpage(nam,email);
            mp.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {

        }
    }
}
