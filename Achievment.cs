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
    public partial class Achievment : Form
    {
        string nam;
        string email;
        public Achievment(string nam, string email)
        {
            InitializeComponent();
            this.nam = nam;
            this.email = email;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private PointF[] GetStarPoints(int numPoints, PointF center, float outerRadius, float innerRadius)
        {
            List<PointF> points = new List<PointF>();
            double angleStep = Math.PI / numPoints;

            for (int i = 0; i < numPoints * 2; i++)
            {
                double angle = i * angleStep - Math.PI / 2;
                float radius = (i % 2 == 0) ? outerRadius : innerRadius;
                float x = center.X + (float)(radius * Math.Cos(angle));
                float y = center.Y + (float)(radius * Math.Sin(angle));
                points.Add(new PointF(x, y));
            }

            return points.ToArray();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;

            float outerR = 60f;            // outer radius
            float innerR = 25f;            // inner radius
            float diameter = outerR * 2f;    // full width of a star

            // Layout: 2 rows × 3 cols
            int rows = 2, cols = 3;

            // Spacing: 2.5× diameter horizontally, 2× diameter vertically
            float hSpacing = diameter * 2.5f;
            float vSpacing = diameter * 2f;

            // Starting center for the first star
            float startX = 150f;
            float startY = 150f;

            // How many habits the user has completed
            int total_habits_Done = GetTotalHabitsDone(email);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    // Compute this star’s “milestone”: (index + 1) * 25
                    int index = row * cols + col;      // 0..5
                    int milestone = (index + 1) * 25;      // 25, 50, …, 150

                    // Determine fill brush: gold if reached, else light gray
                    Brush fill = (total_habits_Done >= milestone)
                                 ? Brushes.Gold
                                 : Brushes.LightGray;

                    // Compute center point
                    float cx = startX + col * hSpacing;
                    float cy = startY + row * vSpacing;
                    var center = new PointF(cx, cy);

                    // Build and draw the star
                    PointF[] pts = GetStarPoints(5, center, outerR, innerR);
                    g.FillPolygon(fill, pts);
                    g.DrawPolygon(Pens.Black, pts);
                }
            }
        }



        private int GetTotalHabitsDone(string email)
        {
            int count = 0;
            string query = @"
        SELECT COUNT(*)
        FROM history
        WHERE email = @Email AND done = 'Yes'";

            var parameters = new Dictionary<string, object>
    {
        { "@Email", email }
    };

            DBAccess db = new DBAccess();
            DataTable result = new DataTable();
            db.readDatathroughAdapter(query, result, parameters);

            if (result.Rows.Count > 0)
            {
                count = Convert.ToInt32(result.Rows[0][0]);
            }

            return count;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            mainpage main = new mainpage(nam, email);
            main.Show();
        }
    }
}
