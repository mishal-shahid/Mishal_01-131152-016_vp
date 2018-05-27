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
    public partial class searchByCatogery : Form
    {
        public searchByCatogery(string text)
        {
            InitializeComponent();
            label2.Text = text;
        }

        private void searchByCatogery_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            databaseConnection db = new databaseConnection();
            db.open();
            try
            {
                db.read("Select * from image where id =@id and catogery=@name", int.Parse(label2.Text), comboBox1.Text, dataGridView1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            searchCard obj = new searchCard(label2.Text);
            this.Close();
            obj.Show();
        }
    }
}
