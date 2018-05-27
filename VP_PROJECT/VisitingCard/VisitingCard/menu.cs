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
    public partial class menu : Form
    {
        public menu(string val)
        {
            InitializeComponent();
            label2.Text = val;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            searchCard obj1 = new searchCard(label2.Text);
            this.Close();
            obj1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scanCard obj = new scanCard(label2.Text);
            this.Close();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
