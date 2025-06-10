namespace WindowsFormsApp2
{
    partial class mainpage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainpage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Customization = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.yourname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Dat = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.datah = new System.Windows.Forms.DataGridView();
            this.ecoDataSet = new WindowsFormsApp2.ecoDataSet();
            this.ecoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.Achievment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Achievment);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.Customization);
            this.panel1.Controls.Add(this.progress);
            this.panel1.Controls.Add(this.History);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.yourname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 641);
            this.panel1.TabIndex = 0;
            // 
            // Customization
            // 
            this.Customization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customization.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customization.ForeColor = System.Drawing.Color.White;
            this.Customization.Location = new System.Drawing.Point(13, 443);
            this.Customization.Margin = new System.Windows.Forms.Padding(4);
            this.Customization.Name = "Customization";
            this.Customization.Size = new System.Drawing.Size(143, 42);
            this.Customization.TabIndex = 6;
            this.Customization.Text = "Customization";
            this.Customization.UseVisualStyleBackColor = true;
            this.Customization.Click += new System.EventHandler(this.Customization_Click);
            // 
            // progress
            // 
            this.progress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.progress.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress.ForeColor = System.Drawing.Color.White;
            this.progress.Location = new System.Drawing.Point(16, 343);
            this.progress.Margin = new System.Windows.Forms.Padding(4);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(140, 70);
            this.progress.TabIndex = 5;
            this.progress.Text = "Progress Tracking";
            this.progress.UseVisualStyleBackColor = true;
            this.progress.Click += new System.EventHandler(this.progress_Click);
            // 
            // History
            // 
            this.History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.ForeColor = System.Drawing.Color.White;
            this.History.Location = new System.Drawing.Point(16, 271);
            this.History.Margin = new System.Windows.Forms.Padding(4);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(140, 42);
            this.History.TabIndex = 4;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // category
            // 
            this.category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.White;
            this.category.Location = new System.Drawing.Point(16, 198);
            this.category.Margin = new System.Windows.Forms.Padding(4);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(140, 42);
            this.category.TabIndex = 3;
            this.category.Text = "Categories";
            this.category.UseVisualStyleBackColor = true;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(-1, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 6);
            this.label2.TabIndex = 2;
            this.label2.Text = " ";
            // 
            // yourname
            // 
            this.yourname.AutoEllipsis = true;
            this.yourname.AutoSize = true;
            this.yourname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourname.ForeColor = System.Drawing.Color.White;
            this.yourname.Location = new System.Drawing.Point(27, 145);
            this.yourname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yourname.Name = "yourname";
            this.yourname.Size = new System.Drawing.Size(103, 23);
            this.yourname.TabIndex = 1;
            this.yourname.Text = "Your Name";
            this.yourname.Click += new System.EventHandler(this.yourname_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 91);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eco-Friendly Habit Tracker";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(180, 86);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1067, 246);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Dat
            // 
            this.Dat.AutoEllipsis = true;
            this.Dat.AutoSize = true;
            this.Dat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dat.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dat.ForeColor = System.Drawing.Color.White;
            this.Dat.Location = new System.Drawing.Point(172, 293);
            this.Dat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dat.Name = "Dat";
            this.Dat.Size = new System.Drawing.Size(92, 42);
            this.Dat.TabIndex = 1;
            this.Dat.Text = "Date";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Black;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(1147, 596);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 46);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add New \r\nHabit";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // datah
            // 
            this.datah.AllowUserToOrderColumns = true;
            this.datah.AllowUserToResizeColumns = false;
            this.datah.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            this.datah.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datah.AutoGenerateColumns = false;
            this.datah.BackgroundColor = System.Drawing.Color.Black;
            this.datah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datah.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datah.ColumnHeadersHeight = 29;
            this.datah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datah.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.ecoDataSet, "habits.habit_name", true));
            this.datah.DataSource = this.ecoDataSet;
            this.datah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datah.GridColor = System.Drawing.Color.White;
            this.datah.Location = new System.Drawing.Point(180, 327);
            this.datah.Margin = new System.Windows.Forms.Padding(4);
            this.datah.Name = "datah";
            this.datah.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datah.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datah.RowHeadersVisible = false;
            this.datah.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime;
            this.datah.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datah.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datah.ShowEditingIcon = false;
            this.datah.Size = new System.Drawing.Size(1067, 314);
            this.datah.TabIndex = 4;
            this.datah.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datah_CellDoubleClick);
            // 
            // ecoDataSet
            // 
            this.ecoDataSet.DataSetName = "ecoDataSet";
            this.ecoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ecoDataSetBindingSource
            // 
            this.ecoDataSetBindingSource.DataSource = this.ecoDataSet;
            this.ecoDataSetBindingSource.Position = 0;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1016, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 115);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note:\r\n\r\nTo Update, Complete and \r\nDelete Habit Double click \r\non the respective " +
    "Habit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Logout
            // 
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(13, 577);
            this.Logout.Margin = new System.Windows.Forms.Padding(4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(143, 42);
            this.Logout.TabIndex = 7;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // Achievment
            // 
            this.Achievment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Achievment.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Achievment.ForeColor = System.Drawing.Color.White;
            this.Achievment.Location = new System.Drawing.Point(13, 509);
            this.Achievment.Margin = new System.Windows.Forms.Padding(4);
            this.Achievment.Name = "Achievment";
            this.Achievment.Size = new System.Drawing.Size(143, 42);
            this.Achievment.TabIndex = 8;
            this.Achievment.Text = "Achievment";
            this.Achievment.UseVisualStyleBackColor = true;
            this.Achievment.Click += new System.EventHandler(this.Achievment_Click);
            // 
            // mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 641);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.datah);
            this.Controls.Add(this.Dat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainpage";
            this.Load += new System.EventHandler(this.mainpage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Dat;
        private System.Windows.Forms.Label yourname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button category;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView datah;
        private System.Windows.Forms.BindingSource ecoDataSetBindingSource;
        private ecoDataSet ecoDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button progress;
        private System.Windows.Forms.Button Customization;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Achievment;
    }
}