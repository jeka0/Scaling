using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Scaling
{
    public class Mask
    {
        public int[][] mask;
        public int k;
        public Mask(int k, int[][] mask)
        {
            this.k = k;
            this.mask = mask;
        }
        public static MyColor operator * (Mask mask, MyColor[][] colors)
        {
            MyColor result = new MyColor(0,0,0);
            for(int i=0;i<mask.mask.Length;i++)
            {
                for(int j=0;j<mask.mask.Length;j++)
                {
                    result += colors[i][j] * mask.mask[i][j];
                }
            }
            return result/mask.k;
        }
    }
}
