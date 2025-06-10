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
    public partial class Add : Form
    {
        string name;
        string email;        
        public Add(string n,string e)
        {
            name = n;
            email = e;
            InitializeComponent();
        }

        private void hname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Categ.Focus();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Categ_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Categ.SelectedIndex != -1)
            {
                Tim.Focus();
            }
        }

        private void Tim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Once.Focus();
            }
        }

        private void Tim_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Add_Load(object sender, EventArgs e)
        {
            Tim.MinDate = DateTime.Now;
            LoadCategories();
        }
        private void LoadCategories()
        {
            DataTable categoriesTable = new DataTable();
            string query = "SELECT category_id, category_name FROM categories";
            DBAccess db = new DBAccess();
            db.readDatathroughAdapter(query, categoriesTable);

            Categ.DataSource = categoriesTable;
            Categ.DisplayMember = "category_name";
            Categ.ValueMember = "category_id";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string frequency = Once.Checked ? "Once" : Daily.Checked ? "Daily" : weekly.Checked ? "Weekly" : "";
            DateTime formattedDate = Tim.Value;

            if (hname.Text == "" || frequency == "")
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            if (formattedDate < DateTime.Now)
            {
                MessageBox.Show("Please select a future date and time.");
                return;
            }

            mainpage mp = new mainpage(name, email);

            // Add 7 copies for Daily or Weekly
            if (frequency == "Daily" || frequency == "Weekly")
            {
                for (int i = 0; i < 7; i++)
                {
                    DateTime incrementedDate = frequency == "Daily"
                        ? formattedDate.AddDays(i)  // Increment by 1 day for Daily
                        : formattedDate.AddDays(i * 7); // Increment by 7 days for Weekly

                    mp.AddRow(hname.Text, Convert.ToInt32(Categ.SelectedValue), email, frequency, incrementedDate);
                }
            }
            else
            {
                // Add a single entry for "Once"
                mp.AddRow(hname.Text, Convert.ToInt32(Categ.SelectedValue), email, frequency, formattedDate);
            }

            MessageBox.Show("Your Habit(s) have been added.");
            this.Hide();
            mp.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
