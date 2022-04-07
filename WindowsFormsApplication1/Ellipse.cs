using ClassLibrary2;
using System;
using System.Drawing;

namespace WindowsFormsApplication1
{
    [Serializable()]
    public class Ellipse : Shape
    {
        private RectangleF _rect;

        public Ellipse(int StartX, int StartY, int Width, int Height)
        {
            _rect.X = StartX;
            _rect.Y = StartY;
            _rect.Width = Width;
            _rect.Height = Height;
        }

        public override Graphics Draw(Graphics Space, Pen Color)
        {
            Space.DrawEllipse(Color, _rect);
            return base.Draw(Space, Color);
        }
    }
}