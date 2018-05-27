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




        private void button2_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            SerachByName obj = new SerachByName(label4.Text);
            this.Close();
            obj.Show();
        }

        private void searchCard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            searchAll obj = new searchAll(label4.Text);
            this.Close();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            searchByCatogery obj = new searchByCatogery(label4.Text);
            this.Close();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu obj = new menu(label4.Text);
            this.Close();
            obj.Show();
        }
    }
}
