using System.Drawing;

namespace Scaling
{
    public class MyColor
    {
        public int R, G, B, RGB;
        public MyColor(int R, int G, int B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.RGB = R + B + G;
        }
        public MyColor(Color color)
        {
            this.R = color.R;
            this.G = color.G;
            this.B = color.B;
            this.RGB = color.ToArgb();
        }
        public static MyColor operator -(MyColor cl1, MyColor cl2)
        {
            return new MyColor(cl1.R - cl2.R, cl1.G - cl2.G, cl1.B - cl2.B);
        }
        public static MyColor operator +(MyColor cl1, MyColor cl2)
        {
            return new MyColor(cl1.R + cl2.R, cl1.G + cl2.G, cl1.B + cl2.B);
        }
        public static MyColor operator /(MyColor cl1, int k)
        {
            return new MyColor(cl1.R / k, cl1.G / k, cl1.B / k);
        }
        public static MyColor operator *(MyColor cl1, int k)
        {
            return new MyColor(cl1.R * k, cl1.G * k, cl1.B * k);
        }
        public static bool operator >(MyColor cl1, MyColor cl2)
        {
            int count = 0;
            MyColor color = cl1 - cl2;
            if (color.R < 0) count++;
            if (color.G < 0) count++;
            if (color.B < 0) count++;
            return count <= 1;
        }
        public Color GetColor()
        {
            return Color.FromArgb(R, G, B);
        }
        public static bool operator <(MyColor cl1, MyColor cl2)
        {
            int count = 0;
            MyColor color = cl1 - cl2;
            if (color.R < 0) count++;
            if (color.G < 0) count++;
            if (color.B < 0) count++;
            return count > 1;
        }
    }
}
