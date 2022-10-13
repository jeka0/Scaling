namespace Scaling
{
    public class Pixel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public MyColor color { get; }
        public Pixel(int x, int y, MyColor color)
        {

            this.X = x;
            this.Y = y;
            this.color = color;
        }
    }
}
