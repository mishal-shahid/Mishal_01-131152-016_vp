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
        public scanCard(string text)
        {
            InitializeComponent();
            label4.Text = text;
        }
        private void scanCard_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo cdevice in filter)
            {
                comboBox1.Items.Add(cdevice.Name);
            }
            comboBox1.SelectedIndex = 0;
             
            device = new VideoCaptureDevice(filter[comboBox1.SelectedIndex].MonikerString);
            device.NewFrame += new NewFrameEventHandler(device_newframe);
            device.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Hide();
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
            var img = new Bitmap(pictureBox2.Image);
            pictureBox1.Hide();
            pictureBox2.Show();
            using (var ocr = new TesseractEngine(@"C:\Users\GMC\Desktop\tesseract-ocr-3.02.eng\tesseract-ocr\tessdata", "eng", EngineMode.TesseractAndCube))
            {
                var page = ocr.Process(img);
                textBox1.Text = page.GetText();
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            databaseConnection x = new databaseConnection();
            x.open();
            x.insert(int.Parse(label4.Text), textBox2.Text, textBox3.Text, comboBox2.Text, pictureBox2.Image);
            x.close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            device.Stop();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.ReadOnly = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.Text = textBox1.SelectedText;
            }
            if (!checkBox1.Checked)
            {
                textBox2.Text = null;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox3.Text = textBox1.SelectedText;
            }
            if (!checkBox1.Checked)
            {
                textBox3.Text = null;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            device.Stop();
            Form1 obj = new Form1();
            obj.Show(); 
        }
    }
}
