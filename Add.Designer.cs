namespace WindowsFormsApp2
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Categ = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tim = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Once = new System.Windows.Forms.RadioButton();
            this.Daily = new System.Windows.Forms.RadioButton();
            this.weekly = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(925, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(551, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome my friend!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(519, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 95);
            this.label2.TabIndex = 2;
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
            this.label3.Location = new System.Drawing.Point(108, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add Habit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(108, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Habit Name:";
            // 
            // hname
            // 
            this.hname.Location = new System.Drawing.Point(231, 155);
            this.hname.Margin = new System.Windows.Forms.Padding(4);
            this.hname.Name = "hname";
            this.hname.Size = new System.Drawing.Size(255, 22);
            this.hname.TabIndex = 5;
            this.hname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hname_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(109, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Category:";
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
            this.Categ.Location = new System.Drawing.Point(231, 204);
            this.Categ.Margin = new System.Windows.Forms.Padding(4);
            this.Categ.Name = "Categ";
            this.Categ.Size = new System.Drawing.Size(255, 24);
            this.Categ.TabIndex = 7;
            this.Categ.SelectedIndexChanged += new System.EventHandler(this.Categ_SelectedValueChanged);
            this.Categ.SelectedValueChanged += new System.EventHandler(this.Categ_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(109, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Time:";
            // 
            // Tim
            // 
            this.Tim.CalendarFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tim.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Tim.Location = new System.Drawing.Point(231, 273);
            this.Tim.Margin = new System.Windows.Forms.Padding(4);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(255, 25);
            this.Tim.TabIndex = 11;
            this.Tim.Value = new System.DateTime(2025, 3, 29, 1, 26, 14, 0);
            this.Tim.ValueChanged += new System.EventHandler(this.Tim_ValueChanged);
            this.Tim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tim_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(108, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Select frequency:";
            // 
            // Once
            // 
            this.Once.AutoSize = true;
            this.Once.BackColor = System.Drawing.Color.Black;
            this.Once.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Once.ForeColor = System.Drawing.Color.White;
            this.Once.Location = new System.Drawing.Point(283, 362);
            this.Once.Margin = new System.Windows.Forms.Padding(4);
            this.Once.Name = "Once";
            this.Once.Size = new System.Drawing.Size(58, 20);
            this.Once.TabIndex = 13;
            this.Once.TabStop = true;
            this.Once.Text = "Once";
            this.Once.UseVisualStyleBackColor = false;
            // 
            // Daily
            // 
            this.Daily.AutoSize = true;
            this.Daily.BackColor = System.Drawing.Color.Black;
            this.Daily.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daily.ForeColor = System.Drawing.Color.White;
            this.Daily.Location = new System.Drawing.Point(283, 390);
            this.Daily.Margin = new System.Windows.Forms.Padding(4);
            this.Daily.Name = "Daily";
            this.Daily.Size = new System.Drawing.Size(57, 20);
            this.Daily.TabIndex = 14;
            this.Daily.TabStop = true;
            this.Daily.Text = "Daily";
            this.Daily.UseVisualStyleBackColor = false;
            // 
            // weekly
            // 
            this.weekly.AutoSize = true;
            this.weekly.BackColor = System.Drawing.Color.Black;
            this.weekly.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekly.ForeColor = System.Drawing.Color.White;
            this.weekly.Location = new System.Drawing.Point(283, 418);
            this.weekly.Margin = new System.Windows.Forms.Padding(4);
            this.weekly.Name = "weekly";
            this.weekly.Size = new System.Drawing.Size(69, 20);
            this.weekly.TabIndex = 15;
            this.weekly.TabStop = true;
            this.weekly.Text = "Weekly";
            this.weekly.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(404, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.weekly);
            this.Controls.Add(this.Daily);
            this.Controls.Add(this.Once);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Categ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Categ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Tim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Once;
        private System.Windows.Forms.RadioButton Daily;
        private System.Windows.Forms.RadioButton weekly;
        private System.Windows.Forms.Button button1;
    }
}