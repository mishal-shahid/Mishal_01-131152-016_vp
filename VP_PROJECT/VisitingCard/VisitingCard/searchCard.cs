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
            databaseConnection db = new databaseConnection();
            db.open();
            try
            {
                db.read("SELECT * FROM image Where id=@id", int.Parse(label2.Text), "", dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.close();
        }
    }
}
