using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scaling
{
    public class CalculateArea
    {
        private double corner;
        private double cos, sin;
        public CalculateArea(double corner)
        {
            this.corner = corner;
            this.cos = Math.Cos(corner);
            this.sin = Math.Sin(corner);
        }
        public double ForTwoPoints(double x1, double x2)
        {
            return 0.5 + ((x1-x2)/(2*cos));
        }
        public double ForOnePointInDifferentAreas(double x, double y)
        {
            return x * y + 0.5 * (y * y - x * x) * (sin / cos);
        }
        public double ForOnePoint(double x)
        {
            return (2 * x * x) / (sin * cos);
        }
        public double ForTheShard(double x, double y)
        {
            return (Math.Pow(x / cos + y / sin - 1, 2) * sin * cos) / 2;
        }
    }
}
