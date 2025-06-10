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

    public partial class update : Form
    {
        string nam;
        string email;
        DBAccess db = new DBAccess();
        string olh; string of; DateTime ohd; string oc;
        public update(string na, string email, string habitName, string frequency, DateTime habitDate, string category)
        {
            nam = na;
            InitializeComponent();
            this.email = email;

            // Initialize form controls with the provided values
            hname.Text =olh= habitName;
            of = frequency;
            if (frequency == "Once")
            {
                Once.Checked = true;
            }
            else if (frequency == "Daily")
            {
                Daily.Checked = true;
            }
            else
            {
                weekly.Checked = true;
            }
            Tim.Value =ohd= habitDate;
            Categ.Text =oc= category;
        }

        private void update_Load(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void hname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Categ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Tim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Once_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Daily_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void weekly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string habitName = hname.Text;
            string frequency = Once.Checked ? "Once" : Daily.Checked ? "Daily" : "Weekly";
            DateTime time = Tim.Value;
            string category = Categ.Text;
            if (hname.Text == "" || frequency == "")
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }
            if (time < DateTime.Now)
            {
                MessageBox.Show("Please select a future date and time.");
                return;
            }

            string query = @"
    UPDATE habits
    SET habit_name = @HabitName, frequency = @Frequency, habit_date = @HabitDate, category_id = (SELECT category_id FROM categories WHERE category_name = @CategoryName)
    WHERE email = @Email AND habit_name = @OriginalHabitName AND frequency = @OriginalFrequency AND habit_date = @OriginalHabitDate AND category_id = (SELECT category_id FROM categories WHERE category_name = @OriginalCategoryName)";
            var parameters = new Dictionary<string, object>
    {
        { "@HabitName", habitName },
        { "@Frequency", frequency },
        { "@HabitDate", time },
        { "@CategoryName", category },
        { "@Email", email },
        { "@OriginalHabitName", olh },
        { "@OriginalFrequency", of },
        { "@OriginalHabitDate", ohd },
        { "@OriginalCategoryName", oc }
    };
            db.ExecuteQuery(query, parameters);
            MessageBox.Show("Habit updated successfully");
            this.Hide();
            mainpage ma = new mainpage(nam, email);
            ma.Show();
        }
    }
}