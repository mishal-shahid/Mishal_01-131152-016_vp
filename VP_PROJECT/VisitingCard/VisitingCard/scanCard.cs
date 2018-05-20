using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using AForge;
using AForge.Imaging.Filters;
using AForge.Imaging;
using Tesseract;
using System.Drawing.Imaging;
using System.IO;
namespace VisitingCard
{
    public partial class scanCard : Form
    {
        private FilterInfoCollection filter;
        private VideoCaptureDevice device;
        public scanCard()
        {
            InitializeComponent();
        }

        private void scanCard_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo cdevice in filter)
            {
                comboBox1.Items.Add(cdevice.Name);
            }
            comboBox1.SelectedIndex = 0;
            device = new VideoCaptureDevice();
            if (device.IsRunning == true)
                device.Stop();
            device = new VideoCaptureDevice(filter[comboBox1.SelectedIndex].MonikerString);
            device.NewFrame += new NewFrameEventHandler(device_newframe);
            device.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
            var img = new Bitmap(pictureBox2.Image);
            pictureBox1.Hide();
            comboBox1.Hide();
            button1.Hide();
            device.Stop();
            pictureBox2.Show();
            try
            {
                using (var ocr = new TesseractEngine(@"C:\Users\GMC\Desktop\tesseract-ocr-3.02.eng\tesseract-ocr\tessdata", "eng", EngineMode.TesseractAndCube))
                {
                    var page = ocr.Process(img);
                    textBox1.Text = page.GetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void device_newframe(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = video;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var img = pictureBox2.Image.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.Text = textBox1.SelectedText;
            }
            if (checkBox2.Checked)
            {
                textBox3.Text = textBox1.SelectedText;
            }
             databaseConnection db = new databaseConnection();
             db.readdata(23);
        }
        public byte[] imageToByte(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            device.Stop();
            menu obj = new menu();
            obj.Show();
        }

    }
}
