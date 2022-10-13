using System;
using System.Drawing;

namespace Scaling
{
    public class Image
    {
        public Bitmap image { private set; get; }
        private Bitmap baseImage;
        public Image(Bitmap image)
        {
            this.image = image;
            this.baseImage = image;
        }
        public void NearestNeighborMethod(double kx, double ky)
        {
            NearestNeighborMethod nearestNeighborMethod = new NearestNeighborMethod(image, kx, ky);
            if (kx >= 1 && ky >= 1) nearestNeighborMethod.Increase();
            else
                if (kx < 1 && ky < 1) nearestNeighborMethod.Decrease();
            else
            {
                if (kx < 1) nearestNeighborMethod.setKxy(1.0, ky); else nearestNeighborMethod.setKxy(kx, 1.0);
                nearestNeighborMethod.Increase();
                if (kx < 1) nearestNeighborMethod.setKxy(kx, 1.0); else nearestNeighborMethod.setKxy(1.0, ky);
                nearestNeighborMethod.Decrease();
            }
            image = nearestNeighborMethod.image;
            baseImage = image;
        }
        public void IncreaseInKTimes(double kx, double ky)
        {
            IncreaseInKTimes increaseInK = new IncreaseInKTimes(image, kx, ky);
            if (kx >= 1 && ky >= 1) increaseInK.Increase();
            else
                if (kx < 1 && ky < 1) increaseInK.Decrease();
            else
            {
                if (kx < 1) increaseInK.setKxy(1.0, ky); else increaseInK.setKxy(kx, 1.0);
                increaseInK.Increase();
                if (kx < 1) increaseInK.setKxy(kx, 1.0); else increaseInK.setKxy(1.0, ky);
                increaseInK.Decrease();
            }
            image = increaseInK.image;
            baseImage = image;
        }
        public void BilinearInterpolation(double kx, double ky)
        {
            BilinearInterpolation bilinearInterpolation = new BilinearInterpolation(image, kx ,ky);
            if (kx >= 1 && ky >= 1) bilinearInterpolation.Increase();
            else
                if (kx < 1 && ky < 1) bilinearInterpolation.Decrease();
            else
            {
                if (kx < 1) bilinearInterpolation.setKxy(1.0, ky); else bilinearInterpolation.setKxy(kx, 1.0);
                bilinearInterpolation.Increase();
                if (kx < 1) bilinearInterpolation.setKxy(kx, 1.0); else bilinearInterpolation.setKxy(1.0, ky);
                bilinearInterpolation.Decrease();
            }
            image = bilinearInterpolation.image;
            baseImage = image;
        }
        public void Rotate(int corner)
        {
            Rotate rotate = new Rotate(baseImage, corner);
            rotate.rotate();
            image = rotate.image;
        }
    }
}
