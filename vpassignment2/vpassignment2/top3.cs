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
    public partial class top3 : Form
    {
        public top3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profile obj = new profile();
            string output=obj.max();
            string[] arr = output.Split(' ');
            //listView1.Items.Add("Name " + "Enroll " + "semester " + "dept " + "uni " + "cgpa ");
            for (int i = 0; i < arr.Length; i++)
            {
                listView1.Items.Add(arr[i]);
            }
        }
    }
}
