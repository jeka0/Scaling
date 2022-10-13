using System;
using System.Drawing;


namespace Scaling
{
    public class IncreaseInKTimes
    {
        public Bitmap image { get; private set; }
        public Bitmap newImage { get; private set; }
        private double kx, ky;
        public IncreaseInKTimes(Bitmap image, double kx, double ky)
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
        private void FillAllBetween(Pixel pixel1, Pixel pixel2)
        {
            MyColor color1 = pixel1.color, color2 = pixel2.color;
            if (pixel1.color < pixel2.color)
            {
                color1 = pixel2.color;
                color2 = pixel1.color;
            }
            int start = pixel1.X, end = pixel2.X, k = (int)kx;
            if (pixel1.X == pixel2.X) { start = pixel1.Y; end = pixel2.Y; k = (int)ky; }
            MyColor f = (color1 - color2) / k, argb = pixel1.color;
            for (int i = start + 1; i < end; i++)
            {
                if (pixel1.color > pixel2.color) argb = argb - f; else argb = argb + f;
                if (pixel1.X == pixel2.X) newImage.SetPixel(pixel1.X, i, argb.GetColor()); else newImage.SetPixel(i, pixel1.Y, argb.GetColor());
            }
        }
        private void FillInTheLines()
        {
            for (int j = 0; j < image.Height; j++)
            {
                for (int i = 0; i < image.Width; i++)
                {
                    Color color = Color.FromArgb(image.GetPixel(i, j).ToArgb());
                    newImage.SetPixel((int)Math.Floor(i * kx), (int)Math.Floor(j * ky), color);
                    if (i != 0)
                    {
                        Color color1 = image.GetPixel(i - 1, j), color2 = image.GetPixel(i, j);
                        Pixel pixel1 = new Pixel((int)Math.Floor((i - 1) * kx), (int)Math.Floor(j * ky), new MyColor(color1)), pixel2 = new Pixel((int)Math.Floor(i * kx), (int)Math.Floor(j * ky), new MyColor(color2));
                        FillAllBetween(pixel1, pixel2);
                    }
                }
            }
        }
        private void FillOnAColumn()
        {
            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    if (j != 0)
                    {
                        Color color1 = newImage.GetPixel(i, (int)Math.Floor((j - 1) * ky)), color2 = newImage.GetPixel(i, (int)Math.Floor(j * ky));
                        Pixel pixel1 = new Pixel(i, (int)Math.Floor((j - 1) * ky), new MyColor(color1)), pixel2 = new Pixel(i, (int)Math.Floor(j * ky), new MyColor(color2));
                        FillAllBetween(pixel1, pixel2);
                    }
                }
            }
        }

        public void Increase()
        {
            this.newImage = new Bitmap((int)Math.Floor(image.Width * kx - kx + 1), (int)Math.Floor(image.Height * ky - ky + 1));
            FillInTheLines();
            FillOnAColumn();
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
