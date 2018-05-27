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
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            databaseConnection db = new databaseConnection();
            DataTable dt = new DataTable();
            db.open();
            try
            {
                if (db.readdata(int.Parse(textBox1.Text), (textBox2.Text)) == true)
                {
                    menu obj = new menu(textBox1.Text);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("invalid user id or password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.close();
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
            try
            {
                int.Parse(textBox1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
