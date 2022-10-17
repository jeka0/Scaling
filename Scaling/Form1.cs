using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Scaling
{
    public partial class Form1 : Form
    {
        private Image image;
        private OpenFileDialog open_dialog;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
        }

        private void but_load_Click(object sender, EventArgs e)
        {
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Image(new Bitmap(open_dialog.FileName));
                    pictureBox1.Image = image.image;
                    pictureBox1.Invalidate();
                    Update();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (image != null && double.TryParse(enterNumX.Text, out double numX) && numX > 0 && double.TryParse(enterNumY.Text, out double numY) && numY > 0)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                image.NearestNeighborMethod(numX,numY);
                pictureBox1.Image = image.image;
                stopwatch.Stop();
                labelTime.Text = stopwatch.ElapsedMilliseconds + " милисек.";
                Update();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (image != null && double.TryParse(enterNumX.Text, out double numX) && numX > 0 && double.TryParse(enterNumY.Text, out double numY) && numY > 0)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                image.IncreaseInKTimes(numX, numY);
                pictureBox1.Image = image.image;
                stopwatch.Stop();
                labelTime.Text = stopwatch.ElapsedMilliseconds + " милисек.";
                Update();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (image != null && double.TryParse(enterNumX.Text, out double numX) && numX > 0 && double.TryParse(enterNumY.Text, out double numY) && numY > 0)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                image.BilinearInterpolation(numX,numY);
                pictureBox1.Image = image.image;
                stopwatch.Stop();
                labelTime.Text = stopwatch.ElapsedMilliseconds + " милисек.";
                Update();
            }
        }
        void Update()
        {
            if (image != null)
            {
                ImageConverter converter = new ImageConverter();
                labelS.Text = image.image.Width + "x" + image.image.Height;
                labelSIZE.Text = ((byte[])converter.ConvertTo(image.image, typeof(byte[]))).Length + " байт";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            image.image.Save("img.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void enterNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') e.KeyChar = ',';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (image != null&& int.TryParse(enterCorner.Text, out int num))
            {
                image.Rotate(num);
                pictureBox1.Image = image.image;            
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (image != null && TryValidateMask(out Mask mask))
            {
                image.Filter(mask);
                pictureBox1.Image = image.image;
            }
        }
        private bool TryValidateMask(out Mask mask)
        {
            if (int.TryParse(textCell1.Text, out int cell1) && int.TryParse(textCell2.Text, out int cell2) && int.TryParse(textCell3.Text, out int cell3) &&
                int.TryParse(textCell4.Text, out int cell4) && int.TryParse(textCell5.Text, out int cell5) && int.TryParse(textCell6.Text, out int cell6) &&
                int.TryParse(textCell7.Text, out int cell7) && int.TryParse(textCell8.Text, out int cell8) && int.TryParse(textCell9.Text, out int cell9) &&
                int.TryParse(textK.Text, out int K))
            {
                int[][] mas = new int[3][];
                for (int i = 0; i < mas.Length; i++) mas[i] = new int[3];
                mas[0][0] = cell1; mas[0][1] = cell2; mas[0][2] = cell3;
                mas[1][0] = cell4; mas[1][1] = cell5; mas[1][2] = cell6;
                mas[2][0] = cell7; mas[2][1] = cell8; mas[2][2] = cell9;
                mask = new Mask(K, mas);
                return true;
            }
            mask = null;
            return false;
        }
    }
}
