﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Scaling
{
    public class Filter
    {
        public Bitmap image { get; private set; }
        private Bitmap newImage;
        private Mask mask;
        public Filter(Bitmap image, Mask mask)
        {
            this.image = image;
            newImage = new Bitmap(image.Width, image.Height);
            this.mask = mask;
        }
        public void filter()
        {
            for(int i=0;i<image.Width;i++)
            {
                for(int j=0;j<image.Height;j++)
                {
                    newImage.SetPixel(i, j, (mask * getMasColors(i, j)).GetColor());
                }
            }
            image = newImage;
        }
        private MyColor[][] getMasColors(int x,int y)
        {
            MyColor[][] mas = new MyColor[3][];
            for (int i=0; i < 3; i++)
            {
                mas[i] = new MyColor[3];
                for (int j = 0; j < 3; j++)
                {
                    mas[i][j] = getColorFromPixel(x - 1 + i, y - 1 + j);
                }
            }
            return mas;
        }
        private MyColor getColorFromPixel(int x,int y)
        {
            if (x < 0 || x >= image.Width || y < 0 || y >= image.Height) return new MyColor(Color.White);
            return new MyColor(image.GetPixel(x, y));
        }
    }
}
