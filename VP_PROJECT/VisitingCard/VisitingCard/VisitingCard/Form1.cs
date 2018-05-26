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
    public partial class Form1 : Form
    {
        public string text;
        public Form1()
        {
            InitializeComponent();
        }
        public string value(string text)
        {
            return text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            databaseConnection db = new databaseConnection();
            DataTable dt = new DataTable();
            db.open();
            if (db.readdata(int.Parse(textBox1.Text), (textBox2.Text))==true)
            {
               menu obj = new menu(textBox1.Text);
               obj.Show();
            }
            else
                MessageBox.Show("incorrect userID or Password");
            db.close();
            text = textBox1.Text;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            signup obj = new signup();
            obj.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            int.Parse(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
