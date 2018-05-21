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
        public menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchCard obj1 = new searchCard();
            obj1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scanCard obj = new scanCard();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
