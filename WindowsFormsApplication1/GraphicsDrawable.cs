using System.Drawing;
using ClassLibrary2;
using Rectangle = ClassLibrary2.Rectangle;

namespace WindowsFormsApplication1
{
    public class GraphicsDrawable: IDrawable
    {
        private readonly Graphics _canvas;

        public GraphicsDrawable(Graphics canvas)
        {
            _canvas = canvas;
        }
        
        public void Draw(Dot shape)
        {
            _canvas.DrawRectangle(new Pen(shape.Color), shape._pointX, shape._pointY, shape._weidth, shape._height);
        }

        public void Draw(Ellipse shape)
        {
           _canvas.DrawEllipse(new Pen(shape.Color), shape._rect);
        }

        public void Draw(Line shape)
        {
            _canvas.DrawLine(new Pen(shape.Color),shape.Start, shape.Finish);
        }

        public void Draw(Polygon shape)
        {
           _canvas.DrawPolygon(new Pen(shape.Color), shape._curvePoints);
        }

        public void Draw(Rectangle shape)
        {
            _canvas.DrawRectangle(new Pen(shape.Color), shape._startX, shape._startY, shape._width, shape._height);
        }

        public void Draw(ClassLibrary2.Trapezium shape)
        {
            _canvas.DrawLine(new Pen(shape.Color), shape._point1, shape._point2);
            _canvas.DrawLine(new Pen(shape.Color), shape._point2.X, shape._point2.Y, shape._point2.X - 10, shape._point2.Y - 20);
            _canvas.DrawLine(new Pen(shape.Color), shape._point2.X - 10, shape._point2.Y - 20, shape._point1.X + 10, shape._point1.Y - 20);
            _canvas.DrawLine(new Pen(shape.Color), shape._point1.X + 10, shape._point1.Y - 20, shape._point1.X, shape._point1.Y);
        }

        public void Draw(Triangle shape)
        {
            _canvas.DrawLine(new Pen(shape.Color), shape._frstPoint, shape._scndPoint);
            _canvas.DrawLine(new Pen(shape.Color), shape._scndPoint, shape._thrdPoint);
            _canvas.DrawLine(new Pen(shape.Color), shape._thrdPoint, shape._frstPoint);
        }
    }
}