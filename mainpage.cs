using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class mainpage : Form
    {
        string nam;
        string email;
        DBAccess db = new DBAccess();
        private NotifyIcon notifyIcon;
        private Timer notificationTimer;
        public mainpage(string na, string email)
        {
            nam = na;
            this.email = email;
            InitializeComponent();
            InitializeComponent1();

            notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = true
            };
            notificationTimer = new Timer
            {
                Interval = 60000 // Check every 60 seconds
            };
            notificationTimer.Tick += NotificationTimer_Tick;
            notificationTimer.Start();
        }
        private void ShowNotification(string title, string message)
        {
            notifyIcon.BalloonTipTitle = title; // Set the title of the notification
            notifyIcon.BalloonTipText = message; // Set the message of the notification
            notifyIcon.ShowBalloonTip(3000); // Show the notification for 3 seconds
        }
        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            string query = @"
        SELECT habit_name, habit_date
        FROM habits
        WHERE email = @Email
        AND done = 'No'
        AND DATEDIFF(MINUTE, habit_date, GETDATE()) BETWEEN 0 AND 1"; // Check if the habit is due within the last minute

            DataTable dueHabits = new DataTable();
            var parameters = new Dictionary<string, object>
    {
        { "@Email", email }
    };

            db.readDatathroughAdapter(query, dueHabits, parameters);

            foreach (DataRow row in dueHabits.Rows)
            {
                string habitName = row["habit_name"].ToString();
                DateTime habitDate = Convert.ToDateTime(row["habit_date"]);

                // Show a notification
                ShowNotification("Habit Reminder", $"It's time for your habit: {habitName} (Scheduled at {habitDate})");

                // Optionally, mark the habit as "done" in the database
                UpdateDoneStatus(habitName, "Daily", habitDate, "CategoryName", "Yes"); // Replace "CategoryName" with the actual category
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Dispose of the NotifyIcon
            if (notifyIcon != null)
            {
                notifyIcon.Visible = false;
                notifyIcon.Dispose();
            }
        }
        private void InitializeComponent1()
        {
            string query = @"
        SELECT Target, ForeColor, BackColor, SelectionForeColor, SelectionBackColor, FontName
        FROM DataGridStyles
        WHERE Email = @Email";

            var parameters = new Dictionary<string, object>
    {    
                { "@Email", email }
    };

            DataTable stylesTable = new DataTable();
            db.readDatathroughAdapter(query, stylesTable, parameters);

            foreach (DataRow row in stylesTable.Rows)
            {
                string target = row["Target"].ToString();
                Color foreColor = Color.FromName(row["ForeColor"].ToString());
                Color backColor = Color.FromName(row["BackColor"].ToString());
                Color selectionForeColor = Color.FromName(row["SelectionForeColor"].ToString());
                Color selectionBackColor = Color.FromName(row["SelectionBackColor"].ToString());
                string fontName = row["FontName"].ToString();

                if (target == "Rows")
                {
                    datah.RowsDefaultCellStyle.ForeColor = datah.AlternatingRowsDefaultCellStyle.ForeColor = foreColor;
                    datah.RowsDefaultCellStyle.BackColor = datah.AlternatingRowsDefaultCellStyle.BackColor = backColor;
                    datah.RowsDefaultCellStyle.SelectionForeColor = datah.AlternatingRowsDefaultCellStyle.SelectionForeColor = selectionForeColor;
                    datah.RowsDefaultCellStyle.SelectionBackColor = datah.AlternatingRowsDefaultCellStyle.SelectionBackColor = selectionBackColor;
                    datah.RowsDefaultCellStyle.Font = datah.AlternatingRowsDefaultCellStyle.Font = new Font(fontName, 9,FontStyle.Regular);
                }
                else if (target == "Headers")
                {
                    datah.EnableHeadersVisualStyles = false;
                    datah.ColumnHeadersDefaultCellStyle.ForeColor = foreColor;
                    datah.ColumnHeadersDefaultCellStyle.BackColor = backColor;
                    datah.ColumnHeadersDefaultCellStyle.SelectionForeColor = selectionForeColor;
                    datah.ColumnHeadersDefaultCellStyle.SelectionBackColor = selectionBackColor;
                    datah.ColumnHeadersDefaultCellStyle.Font = new Font(fontName, 9, FontStyle.Bold);
                }
            }
        ((System.ComponentModel.ISupportInitialize)(this.datah)).BeginInit();
            this.SuspendLayout();
            this.datah.AutoGenerateColumns = false;
            this.datah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datah.Location = new System.Drawing.Point(135, 266);
            this.datah.Size = new System.Drawing.Size(725, 255);
            this.datah.TabIndex = 0;
            this.datah.AllowUserToResizeColumns = false;
            this.datah.AllowUserToResizeRows = false;

            this.datah.GridColor = Color.Black;
            this.datah.BackgroundColor = Color.White;

            this.datah.ScrollBars = ScrollBars.Both;
            this.datah.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            this.datah.Columns.AddRange(new DataGridViewColumn[]
            {
        habitNameColumn,
        frequencyColumn,
        habitDateColumn,
        categoryNameColumn,
        doneColumn
            });

            this.Controls.Add(this.datah);
            this.datah.Visible = true;
        }
        private void LoadUserImage()
        {
            DBAccess objdBAccess = new DBAccess();
            byte[] imageBytes = objdBAccess.GetImage(email);
            if (imageBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to upload?", "Pic selection", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Image image = new Bitmap(ofd.FileName);
                        pictureBox1.Image = image;

                        // Convert image to byte array
                        byte[] imageBytes;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            image.Save(ms, image.RawFormat);
                            imageBytes = ms.ToArray();
                        }
                        DBAccess objdBAccess = new DBAccess();
                        objdBAccess.SaveImage(email, imageBytes);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Image not uploaded");
            }
        }
        private void EnsureDailyAndWeeklyCopies()
        {
            try
            {
                DateTime today = DateTime.Today;
                DateTime tomorrow = today.AddDays(1);

                // Step 1: Get all habits for today with Daily or Weekly frequency
                string query = @"
    SELECT habit_name, frequency, category_id
    FROM habits
    WHERE email = @Email 
    AND CAST(habit_date AS DATE) = @Today 
    AND (frequency = 'Daily' OR frequency = 'Weekly')";

                var habitsTable = new DataTable();
                var parameters = new Dictionary<string, object>
                {
                    ["@Email"] = email,
                    ["@Today"] = today
                };
                db.readDatathroughAdapter(query, habitsTable, parameters);

                foreach (DataRow row in habitsTable.Rows)
                {
                    string habitName = row["habit_name"].ToString();
                    string frequency = row["frequency"].ToString();
                    int categoryId = Convert.ToInt32(row["category_id"]);

                    // Step 2: Check if a copy exists for tomorrow
                    string checkQuery = @"
                SELECT COUNT(*)
                FROM habits
                WHERE email = @Email AND habit_name = @HabitName AND habit_date = @HabitDate";

                    var checkParams = new Dictionary<string, object>
                    {
                        ["@Email"] = email,
                        ["@HabitName"] = habitName,
                        ["@HabitDate"] = tomorrow
                    };

                    int count = 0;
                    using (SqlDataReader reader = db.readDatathroughReader(checkQuery, checkParams))
                    {
                        if (reader.Read())
                            count = Convert.ToInt32(reader[0]);
                        reader.Close();
                    }


                    if (count > 0)
                    {
                        // Tomorrow’s copy already exists — skip
                        continue;
                    }

                    // Step 3: Add 7 future copies starting from tomorrow
                    for (int i = 1; i <= 7; i++)
                    {
                        DateTime newDate = frequency == "Daily"
                            ? today.AddDays(i)
                            : today.AddDays(i * 7);


                        AddRow(habitName, categoryId, email, frequency, newDate);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ensuring daily and weekly copies: {ex.Message}");
            }
        }
        private void MoveDataToHistory()
        {
            string insertQuery = @"
        INSERT INTO history (habit_name, email, frequency, habit_date, category_name, done)
        SELECT h.habit_name, h.email, h.frequency, h.habit_date, c.category_name, h.done
        FROM habits h
        JOIN categories c ON h.category_id = c.category_id
        WHERE h.email = @Email AND h.habit_date < GETDATE()";

            var parameters = new Dictionary<string, object>
    {
        { "@Email", email }
    };

            db.ExecuteQuery(insertQuery, parameters);

            // Delete the moved data from the habits table
            string deleteQuery = @"
        DELETE FROM habits
        WHERE email = @Email AND habit_date < GETDATE()";

            db.ExecuteQuery(deleteQuery, parameters);
        }
        private void mainpage_Load(object sender, EventArgs e)
        {
            EnsureDailyAndWeeklyCopies();
            MoveDataToHistory();
            LoadUserImage();
            Dat.Text = DateTime.Now.ToLongDateString();
            yourname.Text = nam;
            LoadDataGridView();
        }
        public void AddRow(string column1Value, int column2Value, string email, string frequency, DateTime habitDate) // Add parameters as needed
        {
            string query = "INSERT INTO habits (habit_name, category_id, email, frequency, habit_date) VALUES (@Column1, @Column2, @Email, @Frequency, @HabitDate)"; // Replace with your actual column names
            var parameters = new Dictionary<string, object>
    {
        { "@Column1", column1Value },
        { "@Column2", column2Value },
        { "@Email", email },
        { "@Frequency", frequency },
        { "@HabitDate", habitDate }
    };
            db.ExecuteQuery(query, parameters);
            LoadDataGridView();
        }

        private void yourname_Click(object sender, EventArgs e)
        {

        }

        private void category_Click(object sender, EventArgs e)
        {
            this.Hide();
            category cat = new category(nam,email);
            cat.Show();
        }

        private void LoadDataGridView()
        {
            DataTable dataTable = new DataTable();
            string query = @"
        SELECT h.habit_name, h.frequency, h.habit_date, c.category_name,h.done
FROM habits h
JOIN categories c ON h.category_id = c.category_id
WHERE h.email = @Email
AND CAST(h.habit_date AS DATE) = CAST(GETDATE() AS DATE)";
            var parameters = new Dictionary<string, object>
    {
        { "@Email", email }
    };
            db.readDatathroughAdapter(query, dataTable, parameters);

            // Debug statement to check the number of rows

            datah.DataSource = dataTable;

            // Check if there is no data and clear the DataGridView if empty
            if (dataTable.Rows.Count == 0)
            {
                datah.DataSource = null;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add ad = new Add(nam, email);
            ad.Show();
        }

        private void DeleteRow(string habitName, string frequency, DateTime habitDate, string category,string done)
        {
            string query = @"
    DELETE FROM habits
    WHERE habit_name = @HabitName AND frequency = @Frequency AND habit_date = @HabitDate AND category_id = (SELECT category_id FROM categories WHERE category_name = @CategoryName) AND email = @Email and done=@done";
            var parameters = new Dictionary<string, object>
    {
        { "@HabitName", habitName },
        { "@Frequency", frequency },
        { "@HabitDate", habitDate },
        { "@CategoryName", category },
        { "@Email", email },
        { "@done", done }
    };
            db.ExecuteQuery(query, parameters);

        }
        private void UpdateDoneStatus(string habitName, string frequency, DateTime habitDate, string category, string doneStatus)
        {
            string query = @"
        UPDATE habits
        SET done = @DoneStatus
        WHERE habit_name = @HabitName 
          AND frequency = @Frequency 
          AND habit_date = @HabitDate 
          AND category_id = (SELECT category_id FROM categories WHERE category_name = @CategoryName)
          AND email = @Email";

            var parameters = new Dictionary<string, object>
    {
        { "@DoneStatus", doneStatus },
        { "@HabitName", habitName },
        { "@Frequency", frequency },
        { "@HabitDate", habitDate },
        { "@CategoryName", category },
        { "@Email", email }
    };

            db.ExecuteQuery(query, parameters);
        }
        private void datah_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && datah.Rows[e.RowIndex].Cells[0].Value != null && !string.IsNullOrWhiteSpace(datah.Rows[e.RowIndex].Cells[0].Value.ToString())) // Ensure a valid row is selected
            {
                DataGridViewRow row = datah.Rows[e.RowIndex];

                // Get the selected habit details
                string habitName = row.Cells["habit_name"].Value.ToString();
                string frequency = row.Cells["frequency"].Value.ToString();
                DateTime habitDate = Convert.ToDateTime(row.Cells["habit_date"].Value);
                string category = row.Cells["category_name"].Value.ToString();
                string done = row.Cells["done"].Value.ToString();
                // Show the UD form
                using (UD uD = new UD())
                {
                    DialogResult result = uD.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        // Close the UD form and open the update form
                        this.Hide();
                        update up = new update(nam, email, habitName, frequency, habitDate, category);
                        up.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        DeleteRow(habitName, frequency, habitDate, category,done);
                        uD.Close();
                        LoadDataGridView();
                    }
                    else
                    {
                        DateTime hD = Convert.ToDateTime(datah.Rows[e.RowIndex].Cells["habit_date"].Value);
                        DateTime currentTime = DateTime.Now;

                        // Calculate the time difference
                        TimeSpan timeDifference = currentTime - hD;
                        if(datah.Rows[e.RowIndex].Cells["done"].Value.ToString() == "Yes")
                        {
                            MessageBox.Show("You have already completed this habit.");
                            return;
                        }
                        if (timeDifference.TotalMinutes > 30)
                        {
                            MessageBox.Show("Time is up!");
                        }
                        else if (timeDifference.TotalMinutes >= 0)
                        {
                            MessageBox.Show("Congratulations my friend, you have achieved your goal.");
                            UpdateDoneStatus(habitName, frequency, habitDate, category, "Yes");
                            LoadDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("It's not the time yet.");
                        }
                    }
                }
            }
        }

        private void History_Click(object sender, EventArgs e)
        {
            this.Hide();
            history h = new history(nam, email);
            h.Show();
        }

        private void progress_Click(object sender, EventArgs e)
        {
            this.Hide();
            progress p = new progress(nam, email);
            p.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Customization_Click(object sender, EventArgs e)
        {
            this.Hide();
            customization c = new customization(nam, email);
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Achievment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Achievment a = new Achievment(nam, email);
            a.Show();
        }
    }
}
