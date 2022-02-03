using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDProject
{
    public partial class CaptureImage : Form
    {
        VideoCaptureDevice videoSource;
        FilterInfoCollection videoDevices;
        ResizeNearestNeighbor size = new ResizeNearestNeighbor(100, 100);
        public static Bitmap imagepic, imagesig,b1,b2;
        public static PictureBox picimage = null;
        public static bool isdone = false;

        public CaptureImage()
        {
            InitializeComponent();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[comboBox3.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
        }
        void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            videoSource.Stop();
            b1 = (Bitmap)pictureBox1.Image.Clone();
            pictureBox1.Image = (Bitmap)pictureBox1.Image.Clone();

            imagepic = (Bitmap)pictureBox1.Image.Clone();
            imagepic = size.Apply(imagepic);
            //photofilename = txtid.Text + "_photo" + ".png";
            //imagepic.Save(photofilename);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            isdone = true;
            this.Close();
        }

        private void CaptureImage_Load(object sender, EventArgs e)
        {

            comboBox3.Items.Add(Camera.getDevices());
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                comboBox3.Items.Add(device.Name);
            }
            comboBox3.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }
    }
}
