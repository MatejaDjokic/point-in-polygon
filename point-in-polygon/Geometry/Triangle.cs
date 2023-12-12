namespace Codes.Geometry
{
    class Triangle
    {
        private Vec2[] _points = new Vec2[3];
        private double _P;
        public double P { get { return _P; } }
        
        public Vec2[] points { get { return _points; } }

        public Triangle(Vec2 A, Vec2 B, Vec2 C)
        {
            _points = new Vec2[3] { A, B, C };
            _P = Math.Abs(A.x * B.y + B.x * C.y + C.x * A.y
                - A.x * C.y - C.x * B.y - B.x * A.y) / 2.0;
        }
        public Triangle(Vec2[] points)
        {
            _points = points;

            Vec2 A = points[0];
            Vec2 B = points[1];
            Vec2 C = points[2];

            _P = Math.Abs(A.x * B.y + B.x * C.y + C.x * A.y
                - A.x * C.y - C.x * B.y - B.x * A.y) / 2.0;
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
