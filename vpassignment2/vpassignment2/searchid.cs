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
    public partial class searchid : Form
    {
        public searchid()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
                MessageBox.Show("nothing searched");
            else
            {
                listView1.Clear();
                profile obj = new profile();
                string search = obj.search(id.Text);
                string[] arr = search.Split(' ');
                //listView1.Items.Add("Name " + "Enroll " + "semester " + "dept " + "uni " + "cgpa ");
                for (int i = 0; i < arr.Length; i++)
                {
                    listView1.Items.Add(arr[i]);
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
