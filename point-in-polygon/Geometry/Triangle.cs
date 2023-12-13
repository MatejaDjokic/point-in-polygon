using System.ComponentModel.Design;

namespace Codes.Geometry
{
    class Triangle
    {
        // tacke trougla
        private Vec2[] _points = new Vec2[3];
        // povrsina trougla
        private double _P;
        public double P { get { return _P; } }
        public Vec2[] points { get { return _points; } }

        public Triangle(Vec2 A, Vec2 B, Vec2 C)
        {
            // TEMENA
            _points = new Vec2[3] { A, B, C };

            // POVRSINA
            _P = Math.Abs(A.x * B.y + B.x * C.y + C.x * A.y
                - A.x * C.y - C.x * B.y - B.x * A.y) / 2.0;
        }
        public Triangle(Vec2[] points)
        {
            // TEMENA
            _points = points;

            Vec2 A = points[0];
            Vec2 B = points[1];
            Vec2 C = points[2];

            // POVRSINA
            _P = Math.Abs(A.x * B.y + B.x * C.y + C.x * A.y
                - A.x * C.y - C.x * B.y - B.x * A.y) / 2.0;
        }
        public bool ContainsPoint(Vec2 P)
        {
            double EPS = 1e-6;

            double P1 = new Triangle(points[0], points[1], P).P;
            double P2 = new Triangle(points[0], points[2], P).P;
            double P3 = new Triangle(points[1], points[2], P).P;

            double zbirP = P1 + P2 + P3;
            double diff = Math.Abs(this.P - zbirP);
            return diff < EPS;

        }
        public Vec2 CalculateCentroid()
        {
            double cx = 0, cy = 0;
            int count = points.Length;

            foreach (Vec2 point in _points)
            {
                cx += point.x;
                cy += point.y;
            }

            return new Vec2(cx / count, cy / count);
        }
    }
}
