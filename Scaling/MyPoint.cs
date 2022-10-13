using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Scaling
{
    public class MyPoint
    {
        public double x, y;
        public MyPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public MyPoint Turn(double corner)
        {
            double x2 = x * Math.Cos(corner) - y * Math.Sin(corner),
                        y2 = x * Math.Sin(corner) + y * Math.Cos(corner);
            return new MyPoint(x2, y2);
        }
        public MyPoint TurnBack(double corner)
        {
            double x2 = x * Math.Cos(corner) + y * Math.Sin(corner) ,
                        y2 = -x * Math.Sin(corner) + y * Math.Cos(corner);
            return new MyPoint(x2, y2);
        }
    }
}
