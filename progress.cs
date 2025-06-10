using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace WindowsFormsApp2
{
    public partial class progress : Form
    {
        DBAccess db = new DBAccess();
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        string nam;
        string email;
        public progress(string nam, string email)
        {
            InitializeComponent();
            InitializeComponent3();
            this.nam = nam;
            this.email = email;
        }

        private void progress_Load(object sender, EventArgs e)
        {
            LoadPieChart();
            LoadBarChart();
        }

        private void InitializeComponent3()
        {
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();

            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();

            // Pie Chart
            this.pieChart.Location = new System.Drawing.Point(5, 100);
            this.pieChart.Size = new System.Drawing.Size(450, 450);
            this.pieChart.Name = "pieChart";
            this.Controls.Add(this.pieChart);
            // Bar Chart
            this.barChart.Location = new System.Drawing.Point(455, 100);
            this.barChart.Size = new System.Drawing.Size(450, 450);
            this.barChart.Name = "barChart";
            this.Controls.Add(this.barChart);

            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
        }
        private void LoadPieChart()
        {
            // 1) Build your query
            string query = @"
        SELECT done, COUNT(*) AS count
        FROM history
        WHERE email = @email
        GROUP BY done";

            // 2) Prepare ADO.NET objects
            DataTable pieData = new DataTable();
            using (var conn = new SqlConnection(DBAccess.strConnString)) // Use the connection string from DBAccess
            using (var cmd = new SqlCommand(query, conn))
            {
                // 3) Declare and set @email
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 256).Value = email;

                // 4) Fill your DataTable
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(pieData);
                }
            }

            // 5) Prep the chart
            pieChart.Series.Clear();
            pieChart.ChartAreas.Clear();
            pieChart.Legends.Clear();
            pieChart.ChartAreas.Add(new ChartArea());

            var series = new Series
            {
                Name = "DoneStatus",
                ChartType = SeriesChartType.Pie,
                ["PieLabelStyle"] = "Outside",
                ["PieDrawingStyle"] = "SoftEdge"
            };
            pieChart.Series.Add(series);

            // 6) Compute grand total
            int grandTotal = pieData.AsEnumerable()
                .Sum(r => r.Field<int>("count"));

            // 7) Add slices (skip zeros)
            foreach (DataRow row in pieData.Rows)
            {
                string status = row.Field<string>("done");
                int count = row.Field<int>("count");
                if (count == 0) continue;

                // Add slice and grab its DataPoint
                int idx = series.Points.AddXY(status, count);
                var dp = series.Points[idx];

                dp.LegendText = status;
                dp.Label = $"{count} ({count / (double)grandTotal:P0})";
            }

            // 8) Add legend & title
            pieChart.Legends.Add(new Legend
            {
                Docking = Docking.Right,
                LegendStyle = LegendStyle.Table
            });
            pieChart.Titles.Clear();
            pieChart.Titles.Add("Done Status (All Time)");
        }

        private void LoadBarChart()
        {
            // 1) Prepare the last 7 dates
            var last7 = Enumerable
                .Range(0, 7)
                .Select(i => DateTime.Today.AddDays(-6 + i).Date)
                .ToList();

            // 2) SQL query with @email
            string query = @"
        SELECT 
            CAST(habit_date AS DATE) AS habit_date,
            COUNT(*) AS total,
            SUM(CASE WHEN done = 'Yes' THEN 1 ELSE 0 END) AS done_yes
        FROM history
        WHERE habit_date >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE))
          AND email = @email
        GROUP BY CAST(habit_date AS DATE)
    ";

            // 3) Fill DataTable via ADO.NET
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(DBAccess.strConnString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 256)
                   .Value = email;

                using (var adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            // 4) Map results into dictionaries (default = 0)
            var totals = last7.ToDictionary(d => d, d => 0);
            var doneYes = last7.ToDictionary(d => d, d => 0);

            foreach (DataRow r in dt.Rows)
            {
                var d = ((DateTime)r["habit_date"]).Date;
                totals[d] = Convert.ToInt32(r["total"]);
                doneYes[d] = Convert.ToInt32(r["done_yes"]);
            }

            // 5) Clear & configure chart area
            barChart.Series.Clear();
            barChart.ChartAreas.Clear();
            var area = new ChartArea();
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Format = "MM‑dd";
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 10;
            area.AxisY.Interval = 1;
            barChart.ChartAreas.Add(area);

            // 6) Create the two series
            var serTotal = new Series("Total")
            {
                ChartType = SeriesChartType.Column,
                ["PointWidth"] = "0.4"
            };
            var serDone = new Series("Done (Yes)")
            {
                ChartType = SeriesChartType.Column,
                ["PointWidth"] = "0.4"
            };
            barChart.Series.Add(serTotal);
            barChart.Series.Add(serDone);

            // 7) Add data points + labels (only if >0)
            for (int i = 0; i < last7.Count; i++)
            {
                var date = last7[i];
                string lbl = date.ToString("MM‑dd");

                int t = totals[date];
                int y = doneYes[date];

                serTotal.Points.AddXY(lbl, t);
                serDone.Points.AddXY(lbl, y);

                if (t > 0)
                    serTotal.Points[i].Label = t.ToString();
                if (y > 0)
                    serDone.Points[i].Label = y.ToString();
            }

            // 8) Final styling
            barChart.Titles.Clear();
            barChart.Titles.Add("Habits in Last 7 Days");
            barChart.Legends.Clear();
            barChart.Legends.Add(new Legend());
            barChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage mp = new mainpage(nam, email);
            mp.Show();
        }
    }
}
