namespace Codes.Geometry
{
    class Vec2
    {
        double _x, _y;
        public double x { get { return _x; } }
        public double y { get { return _y; } }
        
        public Vec2(double x, double y)
        {
            _x = x;
            _y = y;
        }
     
        public void Draw(Graphics g)
        {
            int WIDTH = 8;
            Rectangle rect = new Rectangle((int)this.x - WIDTH / 2, (int)this.y - WIDTH / 2, WIDTH, WIDTH);
            g.FillEllipse(new SolidBrush(Color.Black), rect);
        }
        public Point toPoint() => new Point((int)this.x, (int)this.y);
    }
}