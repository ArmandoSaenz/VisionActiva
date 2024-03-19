using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace FiltroRGB
{
    public partial class Form1 : Form
    {
        string URLImage = String.Empty;
        string ImageFilterExtension = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|Bitmap|*.bmp|GIF|*.gif";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                URLImage = openFileDialog1.FileName;
                openFileDialog1.Filter = ImageFilterExtension;
                pbOriginalImage.Image = Image.FromFile(URLImage);
                label1.Text = Path.GetFileName(URLImage);
                BGRFilter();
            }
        }

        private void BGRFilter()
        {
            if (pbOriginalImage.Image == null)
                return;
            Mat FilterFrame = OpenCvSharp.Extensions.BitmapConverter.ToMat((Bitmap)pbOriginalImage.Image);
            if (rbBlue.Checked)
            {
                var Frame = Cv2.ImRead(URLImage);
                var Channels = Frame.Split();
                Channels[1].SetTo(0);
                Channels[2].SetTo(0);
                Cv2.Merge(Channels, FilterFrame);
                pbFilter.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(FilterFrame);
            }
            else if (rbGreen.Checked)
            {
                var Frame = Cv2.ImRead(URLImage);
                var Channels = Frame.Split();
                Channels[0].SetTo(0);
                Channels[2].SetTo(0);
                Cv2.Merge(Channels, FilterFrame);
                pbFilter.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(FilterFrame);
            }
            else if(rbRed.Checked)
            {
                var Frame = Cv2.ImRead(URLImage);
                var Channels = Frame.Split();
                Channels[0].SetTo(0);
                Channels[1].SetTo(0);
                Cv2.Merge(Channels, FilterFrame);
                pbFilter.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(FilterFrame);
            }
            else if(rbGray.Checked)
            {
                Mat GrayImage = new Mat();
                Cv2.CvtColor(FilterFrame, GrayImage, ColorConversionCodes.BGR2GRAY);
                pbFilter.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(GrayImage);
            }
        }


        private void rbGreen_Click(object sender, EventArgs e)
        {
            BGRFilter();
        }

        private void rbBlue_Click(object sender, EventArgs e)
        {
            BGRFilter();
        }

        private void rbRed_Click(object sender, EventArgs e)
        {
            BGRFilter();
        }

        private void rbGray_Click(object sender, EventArgs e)
        {
            BGRFilter();
        }
    }
}
