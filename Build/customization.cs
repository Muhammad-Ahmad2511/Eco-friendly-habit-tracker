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
    public partial class customization : Form
    {
        string nam;
        string email;
        public customization(string nam, string email)
        {
            InitializeComponent();
            this.nam = nam;
            this.email = email;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void customization_Load(object sender, EventArgs e)
        {
            cfg.SelectedIndex = 0;
            cbg.SelectedIndex = 0;
            scfg.SelectedIndex = 0;
            scbg.SelectedIndex = 0;
            font.SelectedIndex = 0;
        }

        private void Header_CheckedChanged(object sender, EventArgs e)
        {
            cfg.SelectedIndex = 0;
            cbg.SelectedIndex = 0;
            scfg.SelectedIndex = 0;
            scbg.SelectedIndex = 0;
            font.SelectedIndex = 0;
        }

        private void Rows_CheckedChanged(object sender, EventArgs e)
        {
            cfg.SelectedIndex = 0;
            cbg.SelectedIndex = 0;
            scfg.SelectedIndex = 0;
            scbg.SelectedIndex = 0;
            font.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Determine the target (Rows or Headers)
            string target = Header.Checked ? "Headers" : Rows.Checked ? "Rows" : null;

            if (target == null)
            {
                MessageBox.Show("Please select either 'Header' or 'Rows' to update.");
                return;
            }

            // Retrieve selected values from combo boxes
            string foreColor = cfg.SelectedItem.ToString();
            string backColor = cbg.SelectedItem.ToString();
            string selectionForeColor = scfg.SelectedItem.ToString();
            string selectionBackColor = scbg.SelectedItem.ToString();
            string fontName = font.SelectedItem.ToString();
            
            // Update the database
            string query = @"
        UPDATE DataGridStyles
        SET ForeColor = @ForeColor,
            BackColor = @BackColor,
            SelectionForeColor = @SelectionForeColor,
            SelectionBackColor = @SelectionBackColor,
            FontName = @FontName
        WHERE Email = @Email AND Target = @Target";

            var parameters = new Dictionary<string, object>
    {
        { "@ForeColor", foreColor },
        { "@BackColor", backColor },
        { "@SelectionForeColor", selectionForeColor },
        { "@SelectionBackColor", selectionBackColor },
        { "@FontName", fontName },
        { "@Email", email },
        { "@Target", target }
    };

            DBAccess db = new DBAccess();
            db.ExecuteQuery(query, parameters);

            MessageBox.Show($"{target} styles updated successfully.");
            this.Close();
            mainpage mainPage = new mainpage(nam, email);
            mainPage.Show();
        }
    }
}
