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
    }
}
