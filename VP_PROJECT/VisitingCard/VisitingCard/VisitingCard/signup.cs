using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitingCard
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            databaseConnection dc = new databaseConnection();
            dc.open();
            if (dc.insertdata(int.Parse(textBox2.Text), textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text))
            {

                menu obj = new menu(textBox2.Text);
                obj.Show();
            }
            dc.close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }
    }
}
