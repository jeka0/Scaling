using System;
using System.Drawing;

namespace Scaling
{
    public class BilinearInterpolation
    {
        public Bitmap image { get; private set; }
        public Bitmap newImage { get; private set; }
        private double kx, ky;
        public void setKxy(double kx, double ky)
        {
            this.kx = kx;
            this.ky = ky;
        }
        public BilinearInterpolation(Bitmap image, double kx, double ky)
        {
            this.image = image;
            this.kx = kx;
            this.ky = ky;
        }
        public void Increase()
        {
            this.newImage = new Bitmap((int)Math.Round(image.Width * kx - kx + 1), (int)Math.Round(image.Height * ky - ky + 1));
            ArrangePoints();
            FillAll();
            image = newImage;
        }
        public void Decrease()
        {
            this.newImage = new Bitmap((int)Math.Ceiling(image.Width * kx), (int)Math.Ceiling(image.Height * ky));
            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    newImage.SetPixel(i, j, image.GetPixel((int)Math.Round(CoordinateTranslation(i, newImage.Width, image.Width)), (int)Math.Round(CoordinateTranslation(j, newImage.Height, image.Height))));
                }
            }
            image = newImage;
        }
        private void FillAll()
        {
            for (int i = 0; i < image.Width - 1; i++)
            {
                for (int j = 0; j < image.Height - 1; j++)
                {
                    int i1 = (int)Math.Round(CoordinateTranslation(i, image.Width, newImage.Width)), i2 = (int)Math.Round(CoordinateTranslation(i + 1, image.Width, newImage.Width)),
                        j1 = (int)Math.Round(CoordinateTranslation(j, image.Height, newImage.Height)), j2 = (int)Math.Round(CoordinateTranslation(j + 1, image.Height, newImage.Height));
                    Interpolation(i1, i2, j1, j2);
                }
            }
        }
        private double CoordinateTranslation(int i, int val1, int val2)
        {
            return (i + 0.5) * ((double)val2 / val1) - 0.5;
        }
        private MyColor LinearInterpolation(int i, int j, Pixel F1, Pixel F2)
        {
            int xy1 = F1.X, xy2 = F2.X, xy = i;
            if (F1.X == F2.X) { xy1 = F1.Y; xy2 = F2.Y; xy = j; }
            return (F1.color * (xy2 - xy)) / (xy2 - xy1) + (F2.color * (xy - xy1)) / (xy2 - xy1);
        }
        private void Interpolation(int i1, int i2, int j1, int j2)
        {
            for (int i = i1; i <= i2; i++)
            {
                for (int j = j1; j <= j2; j++)
                {
                    if ((i != i1 || j != j1) && (i != i1 || j != j2) && (i != i2 || j != j1) && (i != i2 || j != j2))
                    {
                        MyColor F11 = new MyColor(newImage.GetPixel(i1, j1)), F12 = new MyColor(newImage.GetPixel(i1, j2)), F21 = new MyColor(newImage.GetPixel(i2, j1)), F22 = new MyColor(newImage.GetPixel(i2, j2));
                        if (i1 == i2) { newImage.SetPixel(i, j, LinearInterpolation(i, j, new Pixel(i1, j1, F11), new Pixel(i2, j2, F22)).GetColor()); continue; }
                        MyColor P1 = LinearInterpolation(i, j, new Pixel(i1, j1, F11), new Pixel(i2, j1, F21));
                        if (j1 == j2) { newImage.SetPixel(i, j, P1.GetColor()); continue; }
                        MyColor P2 = LinearInterpolation(i, j, new Pixel(i1, j2, F12), new Pixel(i2, j2, F22));
                        newImage.SetPixel(i, j, LinearInterpolation(i, j, new Pixel(i, j1, P1), new Pixel(i, j2, P2)).GetColor());
                    }
                }
            }
        }
        private void ArrangePoints()
        {
            for (int j = 0; j < image.Height; j++)
            {
                for (int i = 0; i < image.Width; i++)
                {
                    Color color = Color.FromArgb(image.GetPixel(i, j).ToArgb());
                    newImage.SetPixel((int)Math.Round(CoordinateTranslation(i, image.Width, newImage.Width)), (int)Math.Round(CoordinateTranslation(j, image.Height, newImage.Height)), color);
                }
            }
        }
    }
}
