using ClassLibrary2;
using System;
using System.Drawing;

namespace WindowsFormsApplication1
{
    [Serializable()]
    class Polygon:Shape
    {
        private Point[] _curvePoints = new Point[5];
        private Point _point1;
        private Point _point2;
        private Point _point3;
        private Point _point4;
        private Point _point5;

        public Polygon(int frstX,int frstY,int scndX, int scndY,int thrdX,int thrdY,int frthX,int frthY,int ffthX,int ffthY)
        {
            _point1.X = frstX;
            _point1.Y = frstY;

            _point2.X = scndX;
            _point2.Y = scndY;

            _point3.X = thrdX;
            _point3.Y = thrdY;

            _point4.X = frthX;
            _point4.Y = frthY;

            _point5.X = ffthX;
            _point5.Y = ffthY;    
            
            
        }
        public override Graphics Draw(Graphics Space, Pen Color)
        {
            Point[] _curvePoints =
                  {
                 _point1,
                 _point2,
                 _point3,
                 _point4,
                 _point5};

            Space.DrawPolygon(Color,_curvePoints);
            return base.Draw(Space, Color);
        }
    }
}
