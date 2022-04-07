using System;
using System.Drawing;


namespace ClassLibrary2
{
    [Serializable()]
    public class Shape
    {
        public virtual Graphics Draw(Graphics Space, Pen Color)
        {
            return Space;
        }

    }
}
