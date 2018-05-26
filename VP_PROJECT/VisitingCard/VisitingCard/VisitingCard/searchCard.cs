using MySql.Data.MySqlClient;
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
    public partial class searchCard : Form
    {
        public searchCard(string text)
        {
            InitializeComponent();
            label4.Text = text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            databaseConnection db = new databaseConnection();
            db.open();
            db.read(int.Parse(label4.Text),textBox1.Text, dataGridView1);
            db.close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu obj = new menu(label4.Text);
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }
    }
}
