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
    public partial class viewAttendance : Form
    {
        public viewAttendance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            if (dept.Text == "" || sem.Text == "")
                MessageBox.Show("Nothing Searched");
            else
            {
                profile obj = new profile();
                string output = obj.viewAttendance(dept.Text, sem.Text);
                string[] arr = output.Split(' ', '\n');
                //listView1.Items.Add("Name " + "Enroll " + "semester " + "dept " + "uni " + "cgpa ");
                for (int i = 0; i < arr.Length; i++)
                {
                    listView1.Items.Add(arr[i]);
                }
            }
        }

        private void sem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
