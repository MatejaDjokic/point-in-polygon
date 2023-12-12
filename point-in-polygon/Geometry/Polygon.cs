namespace Codes.Geometry
{
    class Polygon
    {
        private Vec2[] _points;
        private double P { get { return Area(); } }
        public List<Vec2> points { get { return _points.ToList(); } }

        public Polygon(List<Vec2> p)
        {
            _points = p.ToArray();
        }

        public void Draw(Graphics g, bool fill)
        {
            Point[] ps = new Point[points.Count];
            for (int i = 0; i < ps.Length; i++)
                ps[i] = points[i].toPoint();

            if (ps.Length > 0 && fill)
                g.FillPolygon(new SolidBrush(Color.Green), ps);

            int len = _points.Length;
            for (int i = 0; i < len; i++)
            {
                int j = i + 1;
                Vec2 p1 = _points[i % len];
                Vec2 p2 = _points[j % len];
                g.DrawLine(new Pen(Color.Black, 2), p1.toPoint(), p2.toPoint());
            }

            points.ToList().ForEach(p =>
            {
                p.Draw(g);
            });
        }
        public Triangle[] GetTrinagles(Vec2 point)
        {
            Triangle[] tris = new Triangle[_points.Length];
            for (int i = 0; i < _points.Length; i++)
            {
                int j = i + 1;
                Vec2 p1 = _points[i % _points.Length];
                Vec2 p2 = _points[j % _points.Length];
                Triangle tri = new Triangle(p1, p2, point);
                tris[i] = tri;
            }
            return tris;
        }
        public bool ContainsPoint(Vec2 point)
        {
            Triangle[] triangles = GetTrinagles(point);
            List<double> areas = triangles.ToList().Select(tri => tri.P).ToList();
            return P == areas.Sum();
        }
        public Vec2 CalculateCentroid()
        {
            double cx = 0, cy = 0;
            int count = _points.Length;

            foreach (Vec2 point in _points)
            {
                cx += point.x;
                cy += point.y;
            }

            return new Vec2(cx / count, cy / count);
        }
        private double Area()
        {
            Vec2 centroid = CalculateCentroid();
            Triangle[] triangles = GetTrinagles(centroid);
            List<double> areas = triangles.ToList().Select(tri => tri.P).ToList();
            return areas.Sum();
        }
    }
}
