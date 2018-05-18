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
        public searchCard()
        {
            InitializeComponent();
        }

        private void searchCard_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = true;
        }
    }
}
