using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Scaling
{
    public class Rotate
    {
        public Bitmap image { get; private set; }
        private Bitmap newImage;
        private double corner;
        private const double pi = 3.14;
        public Rotate(Bitmap image, int corner)
        {
            this.image = image;
            this.corner = pi*corner/180;
        }
        public void rotate()
        {
            int Width = (int)Math.Round(image.Width*Math.Abs(Math.Cos(corner)) + image.Height* Math.Abs(Math.Sin(corner))),
                Height = (int)Math.Round(image.Width * Math.Abs(Math.Sin(corner)) + image.Height * Math.Abs(Math.Cos(corner)));
            newImage = new Bitmap(Width, Height);
            for(int x =0;x<Width;x++)
            {
                for(int y = 0;y<Height;y++)
                {
                    double nx = x - Width / 2.0, ny = y - Height / 2.0;
                    MyPoint newPoint = new MyPoint(nx, ny).TurnBack(corner);
                    int x2 = (int)Math.Round(newPoint.x+image.Width/2.0),
                        y2 = (int)Math.Round(newPoint.y+ image.Height/2.0);
                    if (x2 >= 0 && x2 < image.Width && y2 >= 0 && y2 < image.Height)
                    {
                        newImage.SetPixel(x,y,image.GetPixel(x2, y2));
                    }//else newImage.SetPixel(x, y, Color.Gray);
                }
            }
            image = newImage;
        }
    }
}
