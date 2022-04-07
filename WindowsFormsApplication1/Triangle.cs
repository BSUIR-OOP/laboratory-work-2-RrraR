using ClassLibrary2;
using System;
using System.Drawing;

namespace WindowsFormsApplication1
{
    [Serializable()]
    class Triangle:Shape
    {
       private Point _frstPoint;
       private Point _scndPoint;
       private Point _thrdPoint;

        public Triangle(int FrstX,int FrstY, int ScndX, int ScndY, int ThrdX, int ThrdY)
        {

            _frstPoint.X = FrstX;
            _frstPoint.Y = FrstY;
            _scndPoint.X = ScndX;
            _scndPoint.Y = ScndY;
            _thrdPoint.X = ThrdX;
            _thrdPoint.Y = ThrdY;

        }
        public override Graphics Draw(Graphics Space, Pen Color)
        {
            Space.DrawLine(Color, _frstPoint,_scndPoint);
            Space.DrawLine(Color, _scndPoint, _thrdPoint);
            Space.DrawLine(Color, _thrdPoint, _frstPoint);
            return base.Draw(Space, Color);
        }
    }
}
