using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp2
{
    public partial class history : Form
    {
        string nam;
        string email;
        DBAccess db = new DBAccess();
        public history(string nam, string email)
        {
            InitializeComponent();
            InitializeComponent2();
            this.nam = nam;
            this.email = email;
        }
        private void InitializeComponent2()
        {
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.TabIndex = 0;
            this.dgv.DefaultCellStyle.ForeColor = Color.White; // Set the font color to black
            this.dgv.DefaultCellStyle.BackColor = Color.Black;
            this.dgv.ScrollBars = ScrollBars.Both;
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var habitNameColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "habit_name",
                HeaderText = "Habit Name",
                Name = "habit_name"
            };
            var frequencyColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "frequency",
                HeaderText = "Frequency",
                Name = "frequency"
            };
            var habitDateColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "habit_date",
                HeaderText = "Habit Date",
                Name = "habit_date"
            };
            var categoryNameColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "category_name",
                HeaderText = "Category Name",
                Name = "category_name"
            };
            var doneColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "done",
                HeaderText = "Done",
                Name = "done"
            };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("habit_name", typeof(string));
            dataTable.Columns.Add("frequency", typeof(string));
            dataTable.Columns.Add("habit_date", typeof(DateTime));
            dataTable.Columns.Add("category_name", typeof(string));
            dataTable.Columns.Add("done", typeof(string));
            this.dgv.Columns.AddRange(new DataGridViewColumn[]
            {
        habitNameColumn,
        frequencyColumn,
        habitDateColumn,
        categoryNameColumn,
        doneColumn
            });

            this.Controls.Add(this.dgv);
            this.dgv.Visible = true;
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage mp = new mainpage(nam, email);
            mp.Show();
        }
        private void LoadDataGridView()
        {
            DataTable dataTable = new DataTable();
            string query = @"
        SELECT h.habit_name, h.frequency, h.habit_date, h.category_name,h.done
FROM history h where email=@email";
            var parameters = new Dictionary<string, object>
    {
        { "@Email", email }
    };
            db.readDatathroughAdapter(query, dataTable, parameters);

            // Debug statement to check the number of rows

            dgv.DataSource = dataTable;

            // Check if there is no data and clear the DataGridView if empty
            if (dataTable.Rows.Count == 0)
            {
                dgv.DataSource = null;
            }
        }

        private void history_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
