using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Position
    {
        public Position(double top, double bottom, double left, double right)
        {
            Top = top;
            Bottom = bottom;
            Left = left;
            Right = right;
        }
        public Position(Position position)
        {
            Top = position.Top;
            Bottom = position.Bottom;
            Left = position.Left;
            Right = position.Right;
        }
    
        public double Top { get; set; }
        public double Bottom { get; set; }
        public double Left { get; set; }
        public double Right { get; set; }

        public double MiddleOfX()
        {
            return (Left + Right) / 2;
        }

        public double MiddleOfY()
        {
            return (Bottom + Top) / 2;
        }
    }
}
