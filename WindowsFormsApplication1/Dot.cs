using ClassLibrary2;
using System;
using System.Drawing;

namespace WindowsFormsApplication1
{
    [Serializable()]
    public class Dot: Shape
    {
        private Point _point;

        public Dot(int x,int y)
        {
            _point.X = x;
            _point.Y = y;
        }      

        public override Graphics Draw(Graphics Space, Pen Color)
        {
            Space.DrawRectangle(Color,_point.X,_point.Y,1,1);
            return base.Draw(Space, Color);
        }
    }
}
