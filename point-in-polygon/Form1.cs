using Codes.Geometry;
using System.Xml.Serialization;

namespace point_in_polygon
{
    public partial class Form1 : Form
    {

        const String TB_POINTS_NO_POINTS_TEXT = "NO POINTS";

        const int START_X = 250;
        const int START_Y = 10;
        const int WIDTH = 500;
        const int HEIGHT = 410;
        const int CENTER_X = 270;
        const int CENTER_Y = 200;

        Graphics g;
        Polygon polygon;
        int n_gone = 0;
        int radius = 50;
        bool cursor = true;

        private void Triangle(object sender, EventArgs e) =>
            tb_points.Text = "200,75\r\n150, 200\r\n400, 250";
        private void Square(object sender, EventArgs e) =>
            tb_points.Text = $"100, 100\r\n300, 100\r\n300, 300\r\n100, 300";
        private void Pentagon(object sender, EventArgs e) =>
            tb_points.Text = "250, 145\r\n175, 200\r\n200, 275\r\n300, 275\r\n325,200";
        private void Hexagon(object sender, EventArgs e) =>
            tb_points.Text = "100, 200\r\n150, 125\r\n250, 125\r\n300, 200\r\n250, 275\r\n150, 275";
        private void Octagon(object sender, EventArgs e) =>
            tb_points.Text = "100, 100\r\n200, 50\r\n300, 100\r\n350, 200\r\n300, 300\r\n200, 350\r\n100, 300\r\n50, 200";

        public Form1()
        {
            InitializeComponent();
            this.MouseMove += OnMouseMove;
            polygon = new Polygon(new List<Vec2>() { });
        }

        private void Form1Load(object sender, EventArgs e)
        {
            g = CreateGraphics();

            tb_points.Text = TB_POINTS_NO_POINTS_TEXT;
            ngone.Text = "N = 0";
        }

        private void OnMouseMove(object sender, MouseEventArgs e) => move(e);

        private void move(MouseEventArgs e)
        {

            g.Clear(Color.White);
            DrawCoordinateSystem();

            bool fill = false;
            if (e != null)
            {
                Vec2 mouse = new Vec2(e.X, e.Y);
                fill = polygon.ContainsPoint(mouse);

            }
            if (tb_points.Text != TB_POINTS_NO_POINTS_TEXT && polygon.points.Count > 2)
            {
                if (fill)
                {
                    text.Text = "Point is inside the polygon!";
                    text.BackColor = Color.Green;
                }
                else
                {
                    text.Text = "Point is not inside the polygon!";
                    text.BackColor = Color.Red;
                }
            }
            else
            {
                text.Text = "No points yet!";
                text.BackColor = Color.White;
            }

            polygon.Draw(g, fill);
        }

        private void DrawCoordinateSystem()
        {
            Point start = new Point(START_X, START_Y);
            Point end_x = new Point(START_X + WIDTH, START_Y);
            Point end_y = new Point(START_X, START_Y + HEIGHT);
            Point text_x = new Point(end_x.X + 5, end_x.Y - 5);
            Point text_y = new Point(end_y.X - 5, end_y.Y + 5);

            g.DrawLine(new Pen(Color.Black), start, end_x);
            g.DrawLine(new Pen(Color.Black), start, end_y);

            g.DrawString("X", this.Font, new SolidBrush(Color.Black), text_x);
            g.DrawString("Y", this.Font, new SolidBrush(Color.Black), text_y);
        }

        private void tb_points_TextChanged(object sender, EventArgs e)
        {
            List<Vec2> points = new List<Vec2>();
            try
            {
                String[] lines = tb_points.Text.Split("\r\n");
                foreach (String line in lines)
                {
                    String[] split = line.Trim().Split(",");
                    int x = int.Parse(split.First());
                    int y = int.Parse(split.Last());
                    Vec2 vec2 = new Vec2(x + START_X, y + START_Y);
                    points.Add(vec2);
                }
            }
            catch (Exception ex) { }
            if (points.Count >= 3)
                polygon = new Polygon(new Polygon(points).ConvexHull());
            move(null);
        }

        private void ngone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n_gone = int.Parse(ngone.Text.Replace("N = ", "").Trim());
            }
            catch (Exception ex) { }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            String poly = String.Empty;
            if (n_gone > 2)
            {
                for (int i = 0; i < n_gone; i++)
                {
                    double angle = 2 * Math.PI * i / n_gone;
                    double x = CENTER_X + radius * Math.Cos(angle);
                    double y = CENTER_Y + radius * Math.Sin(angle);
                    poly += $"{(int)x}, {(int)y}\r\n";
                }
                tb_points.Text = poly;
                move(null);
            }
            else
                MessageBox.Show("Number of points must be 3 or more.");
        }

        private void rad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                radius = int.Parse(rad.Text.Replace("R = ", "").Trim());
            }
            catch (Exception ex) { }
        }
    }
}