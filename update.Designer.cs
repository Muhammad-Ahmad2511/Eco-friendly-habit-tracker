namespace WindowsFormsApp2
{
    partial class update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update));
            this.label1 = new System.Windows.Forms.Label();
            this.ecoDataSet = new WindowsFormsApp2.ecoDataSet();
            this.habitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.habitsTableAdapter = new WindowsFormsApp2.ecoDataSetTableAdapters.habitsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.weekly = new System.Windows.Forms.RadioButton();
            this.Daily = new System.Windows.Forms.RadioButton();
            this.Once = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Tim = new System.Windows.Forms.DateTimePicker();
            this.Categ = new System.Windows.Forms.ComboBox();
            this.hname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ecoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Habit";
            // 
            // ecoDataSet
            // 
            this.ecoDataSet.DataSetName = "ecoDataSet";
            this.ecoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // habitsBindingSource
            // 
            this.habitsBindingSource.DataMember = "habits";
            this.habitsBindingSource.DataSource = this.ecoDataSet;
            // 
            // habitsTableAdapter
            // 
            this.habitsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(345, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 27;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // weekly
            // 
            this.weekly.AutoSize = true;
            this.weekly.BackColor = System.Drawing.Color.Black;
            this.weekly.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekly.ForeColor = System.Drawing.Color.White;
            this.weekly.Location = new System.Drawing.Point(254, 371);
            this.weekly.Name = "weekly";
            this.weekly.Size = new System.Drawing.Size(60, 18);
            this.weekly.TabIndex = 26;
            this.weekly.TabStop = true;
            this.weekly.Text = "Weekly";
            this.weekly.UseVisualStyleBackColor = false;
            this.weekly.CheckedChanged += new System.EventHandler(this.weekly_CheckedChanged);
            // 
            // Daily
            // 
            this.Daily.AutoSize = true;
            this.Daily.BackColor = System.Drawing.Color.Black;
            this.Daily.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daily.ForeColor = System.Drawing.Color.White;
            this.Daily.Location = new System.Drawing.Point(254, 348);
            this.Daily.Name = "Daily";
            this.Daily.Size = new System.Drawing.Size(50, 18);
            this.Daily.TabIndex = 25;
            this.Daily.TabStop = true;
            this.Daily.Text = "Daily";
            this.Daily.UseVisualStyleBackColor = false;
            this.Daily.CheckedChanged += new System.EventHandler(this.Daily_CheckedChanged);
            // 
            // Once
            // 
            this.Once.AutoSize = true;
            this.Once.BackColor = System.Drawing.Color.Black;
            this.Once.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Once.ForeColor = System.Drawing.Color.White;
            this.Once.Location = new System.Drawing.Point(254, 325);
            this.Once.Name = "Once";
            this.Once.Size = new System.Drawing.Size(49, 18);
            this.Once.TabIndex = 24;
            this.Once.TabStop = true;
            this.Once.Text = "Once";
            this.Once.UseVisualStyleBackColor = false;
            this.Once.CheckedChanged += new System.EventHandler(this.Once_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(123, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Select frequency:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Tim
            // 
            this.Tim.CalendarFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tim.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Tim.Location = new System.Drawing.Point(215, 253);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(192, 21);
            this.Tim.TabIndex = 22;
            this.Tim.Value = new System.DateTime(2025, 3, 29, 1, 26, 14, 0);
            this.Tim.ValueChanged += new System.EventHandler(this.Tim_ValueChanged);
            // 
            // Categ
            // 
            this.Categ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categ.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categ.FormattingEnabled = true;
            this.Categ.Items.AddRange(new object[] {
            "Hydration",
            "Finance",
            "Work",
            "Nutrition",
            "Outdoor",
            "Study",
            "Health",
            "Quit bad habit",
            "Task",
            "Meditation",
            "Sports"});
            this.Categ.Location = new System.Drawing.Point(215, 197);
            this.Categ.Name = "Categ";
            this.Categ.Size = new System.Drawing.Size(192, 22);
            this.Categ.TabIndex = 20;
            this.Categ.SelectedIndexChanged += new System.EventHandler(this.Categ_SelectedIndexChanged);
            // 
            // hname
            // 
            this.hname.BackColor = System.Drawing.Color.White;
            this.hname.ForeColor = System.Drawing.Color.Black;
            this.hname.Location = new System.Drawing.Point(215, 157);
            this.hname.Name = "hname";
            this.hname.Size = new System.Drawing.Size(192, 20);
            this.hname.TabIndex = 18;
            this.hname.TextChanged += new System.EventHandler(this.hname_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(104, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(104, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(103, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Habit Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(484, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 75);
            this.label2.TabIndex = 32;
            this.label2.Text = "Small daily improvements are the key to \r\nstaggering long-term results; even a sm" +
    "all \r\nchange can bring peace to life. Each step 🌱 \r\nbuilds strength 💪 and ligh" +
    "ts the path to lasting \r\nchange ✨";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(508, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 26);
            this.label3.TabIndex = 31;
            this.label3.Text = "Welcome my friend!";
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(820, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.weekly);
            this.Controls.Add(this.Daily);
            this.Controls.Add(this.Once);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.Categ);
            this.Controls.Add(this.hname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ecoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ecoDataSet ecoDataSet;
        private System.Windows.Forms.BindingSource habitsBindingSource;
        private ecoDataSetTableAdapters.habitsTableAdapter habitsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton weekly;
        private System.Windows.Forms.RadioButton Daily;
        private System.Windows.Forms.RadioButton Once;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Tim;
        private System.Windows.Forms.ComboBox Categ;
        private System.Windows.Forms.TextBox hname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}