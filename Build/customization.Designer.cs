namespace WindowsFormsApp2
{
    partial class customization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customization));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cfg = new System.Windows.Forms.ComboBox();
            this.font = new System.Windows.Forms.ComboBox();
            this.scfg = new System.Windows.Forms.ComboBox();
            this.cbg = new System.Windows.Forms.ComboBox();
            this.scbg = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rows = new System.Windows.Forms.RadioButton();
            this.Header = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1247, 690);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(173, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customization";
            // 
            // cfg
            // 
            this.cfg.BackColor = System.Drawing.Color.Black;
            this.cfg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cfg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cfg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfg.ForeColor = System.Drawing.Color.White;
            this.cfg.FormattingEnabled = true;
            this.cfg.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Cyan",
            "Gray",
            "Green",
            "Lime",
            "Magenta",
            "Navy",
            "Orange",
            "Pink",
            "Purple",
            "Red",
            "White",
            "Yellow"});
            this.cfg.Location = new System.Drawing.Point(367, 287);
            this.cfg.Name = "cfg";
            this.cfg.Size = new System.Drawing.Size(180, 28);
            this.cfg.Sorted = true;
            this.cfg.TabIndex = 7;
            this.cfg.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // font
            // 
            this.font.BackColor = System.Drawing.Color.Black;
            this.font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.font.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.font.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.font.ForeColor = System.Drawing.Color.White;
            this.font.FormattingEnabled = true;
            this.font.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Segoe UI",
            "Arial",
            "Tahoma",
            "Verdana",
            "Times New Roman",
            "Calibri",
            "Courier New",
            "Georgia",
            "Comic Sans MS",
            "Impact",
            "Trebuchet MS",
            "Palatino Linotype",
            "Consolas",
            "Cambria"});
            this.font.Location = new System.Drawing.Point(367, 542);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(180, 28);
            this.font.TabIndex = 8;
            // 
            // scfg
            // 
            this.scfg.BackColor = System.Drawing.Color.Black;
            this.scfg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scfg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scfg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scfg.ForeColor = System.Drawing.Color.White;
            this.scfg.FormattingEnabled = true;
            this.scfg.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Cyan",
            "Magenta",
            "Gray",
            "Orange",
            "Brown",
            "Purple",
            "Pink",
            "Lime",
            "Navy"});
            this.scfg.Location = new System.Drawing.Point(367, 432);
            this.scfg.Name = "scfg";
            this.scfg.Size = new System.Drawing.Size(180, 28);
            this.scfg.TabIndex = 9;
            // 
            // cbg
            // 
            this.cbg.BackColor = System.Drawing.Color.Black;
            this.cbg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbg.ForeColor = System.Drawing.Color.White;
            this.cbg.FormattingEnabled = true;
            this.cbg.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Cyan",
            "Magenta",
            "Gray",
            "Orange",
            "Brown",
            "Purple",
            "Pink",
            "Lime",
            "Navy"});
            this.cbg.Location = new System.Drawing.Point(933, 288);
            this.cbg.Name = "cbg";
            this.cbg.Size = new System.Drawing.Size(180, 28);
            this.cbg.TabIndex = 10;
            // 
            // scbg
            // 
            this.scbg.BackColor = System.Drawing.Color.Black;
            this.scbg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scbg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scbg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scbg.ForeColor = System.Drawing.Color.White;
            this.scbg.FormattingEnabled = true;
            this.scbg.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Cyan",
            "Magenta",
            "Gray",
            "Orange",
            "Brown",
            "Purple",
            "Pink",
            "Lime",
            "Navy"});
            this.scbg.Location = new System.Drawing.Point(933, 429);
            this.scbg.Name = "scbg";
            this.scbg.Size = new System.Drawing.Size(180, 28);
            this.scbg.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(648, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Colors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(194, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Foreground:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(760, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Background:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(760, 430);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Background:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(194, 433);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Foreground:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(604, 378);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Selection Colors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 547);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Font:";
            // 
            // Rows
            // 
            this.Rows.AutoSize = true;
            this.Rows.BackColor = System.Drawing.Color.Black;
            this.Rows.Checked = true;
            this.Rows.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rows.ForeColor = System.Drawing.Color.White;
            this.Rows.Location = new System.Drawing.Point(933, 540);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(71, 24);
            this.Rows.TabIndex = 21;
            this.Rows.TabStop = true;
            this.Rows.Text = "Rows";
            this.Rows.UseVisualStyleBackColor = false;
            this.Rows.CheckedChanged += new System.EventHandler(this.Rows_CheckedChanged);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.Black;
            this.Header.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(933, 584);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(82, 24);
            this.Header.TabIndex = 22;
            this.Header.Text = "Header";
            this.Header.UseVisualStyleBackColor = false;
            this.Header.CheckedChanged += new System.EventHandler(this.Header_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(760, 547);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Selection:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1069, 598);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 24;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scbg);
            this.Controls.Add(this.cbg);
            this.Controls.Add(this.scfg);
            this.Controls.Add(this.font);
            this.Controls.Add(this.cfg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "customization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customization";
            this.Load += new System.EventHandler(this.customization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cfg;
        private System.Windows.Forms.ComboBox font;
        private System.Windows.Forms.ComboBox scfg;
        private System.Windows.Forms.ComboBox cbg;
        private System.Windows.Forms.ComboBox scbg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rows;
        private System.Windows.Forms.RadioButton Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}