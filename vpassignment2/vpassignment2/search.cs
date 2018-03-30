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
    public partial class createProfile : Form
    {
        public createProfile()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float.Parse(cgpa.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profile obj = new profile();
            if (name.Text == "" || id.Text == "" || sem.Text == "" || dept.Text == "" || uni.Text == "" || cgpa.Text == "")
                MessageBox.Show("Please fill all fields");
            else
            obj.createprofile(name.Text, id.Text, sem.Text, dept.Text, uni.Text, float.Parse(cgpa.Text),"absent");
        }
    }
}
