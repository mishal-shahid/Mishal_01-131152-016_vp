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
    public partial class seachrecord : Form
    {
        public seachrecord()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchsemester obj2 = new searchsemester();
            obj2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchname obj = new searchname();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchid obj1 = new searchid();
            obj1.Show();
        }
    }
}
