using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UD : Form
    {
       

        public UD()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Yes; // Use Yes for Update
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.No; // Use No for Delete
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Use Cancel for Cancel
            this.Close();
        }

        private void UD_Load(object sender, EventArgs e)
        {

        }
    }
}