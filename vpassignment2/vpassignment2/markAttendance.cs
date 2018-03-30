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
    public partial class markAttendance : Form
    {
        public markAttendance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sem.Text == "" || dept.Text == "")
                MessageBox.Show("please fill all fields");
            else
            {
                profile obj = new profile();
                obj.attendance(dept.Text, sem.Text);
            }

        }
    }
}
