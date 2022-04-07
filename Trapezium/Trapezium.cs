using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using System.Drawing;

namespace Trapezium
{
    [Serializable()]
    public class Trapezium:Shape
    {
        private Point _point1;
        private Point _point2;
        public Trapezium(int x1, int y1,int x2,int y2)
        {
            _point1.X = x1;
            _point1.Y = y1;
            _point2.X = x2;
            _point2.Y = y2;
        }
        public override Graphics Draw(System.Drawing.Graphics Space, System.Drawing.Pen Color)
        {
            Space.DrawLine(Color, _point1,_point2);
            Space.DrawLine(Color, _point2.X, _point2.Y, _point2.X - 10, _point2.Y - 20);
            Space.DrawLine(Color, _point2.X - 10, _point2.Y - 20, _point1.X + 10, _point1.Y -20);
            Space.DrawLine(Color, _point1.X + 10, _point1.Y - 20, _point1.X, _point1.Y);

            return base.Draw(Space, Color);
        }


    }
}
