using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace VisitingCard
{
    class databaseConnection
    {
        MySqlConnection connectstr = new MySqlConnection("server=localhost;user id=root;database=login;SSLmode = none; pwd = flame1234");
        public void open()
        {
            connectstr.Open();
        }
        public void close()
        {
            connectstr.Close();

        }
        public bool readdata(int id, string pass)
        {
            bool val = false;
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from signup where useid=" + (id) /*"and password="+pass*/ ,connectstr);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count ==1)
                val = true;
            return val;
        }
        public bool insertdata(int id, string name, string email, string contact, string password)
        {
            bool val = false;
            if (readdata(id, password) == true)
            {
                MessageBox.Show("already exsist");
            }
            else
            {
                //bool val = false;
                MySqlCommand com = new MySqlCommand("INSERT INTO signup(useid,name,email,contact,password) VALUES('" + id + "','" + name + "','" + email + "','" + contact + "','" + password + "')", connectstr);
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("data successfully added");
                    val = true;
                }
                else
                    MessageBox.Show("error");
            }
            return val;
        }
    }
}
