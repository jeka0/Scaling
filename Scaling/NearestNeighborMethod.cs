using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Scaling
{
    public class NearestNeighborMethod
    {
        public Bitmap image { get; private set; }
        public Bitmap newImage { get; private set; }
        private double kx, ky;
        public NearestNeighborMethod(Bitmap image, double kx, double ky)
        {
            this.image = image;
            this.kx = kx;
            this.ky = ky;
        }
        public void setKxy(double kx, double ky)
        {
            this.kx = kx;
            this.ky = ky;
        }
        public void Increase()
        {
            Bitmap newImage = new Bitmap((int)Math.Floor(image.Width * kx), (int)Math.Floor(image.Height * ky));
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    for (int i2 = (int)Math.Floor(i * kx); i2 < (int)Math.Floor((i + 1) * kx); i2++)
                    {
                        for (int j2 = (int)Math.Floor(j * ky); j2 < (int)Math.Floor((j + 1) * ky); j2++)
                        {
                            newImage.SetPixel(i2, j2, image.GetPixel(i, j));
                        }
                    }
                }
            }
            image = newImage;
        }

        public void Decrease()
        {
            this.newImage = new Bitmap((int)Math.Ceiling(image.Width * kx), (int)Math.Ceiling(image.Height * ky));
            double sx = 1 / kx, sy = 1 / ky;
            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    newImage.SetPixel(i, j, image.GetPixel((int)Math.Floor(i * sx), (int)Math.Floor(j * sy)));
                }
            }
            image = newImage;
        }
    }
}
