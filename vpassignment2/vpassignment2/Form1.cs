using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vpassignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            createProfile obj1 = new createProfile();
            obj1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seachrecord obj = new seachrecord();
            obj.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete obj = new delete();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            top3 obj = new top3();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            viewAttendance obj = new viewAttendance();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            markAttendance obj = new markAttendance();
            obj.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
