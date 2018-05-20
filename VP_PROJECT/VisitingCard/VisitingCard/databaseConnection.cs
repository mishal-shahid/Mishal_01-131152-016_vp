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
        public bool readdata(int id)
        {
            bool val = false;
            MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM signup WHERE useid =@id", connectstr);
            cmd.Parameters.AddWithValue(@"id", id);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
                val = true;
            dr.Dispose();
            return val;

        }
        public void insert(int id, string name, string contact, string catogery, Image img)
        {
            MySqlCommand cmd = new MySqlCommand(@"insert into image (id,name,contact,catogery,image) VALUES (@ID,@NAME,@CONTACT,@CATOGERY,@IMG)", connectstr);
            cmd.Parameters.AddWithValue(@"ID", id);
            cmd.Parameters.AddWithValue(@"NAME", name);
            cmd.Parameters.AddWithValue(@"CONTACT", contact);
            cmd.Parameters.AddWithValue(@"CATOGERY", catogery);
            byte[] data = imageToByte(img);
            MySqlParameter blob = new MySqlParameter("@IMG", MySqlDbType.Blob, data.Length);
            blob.Value = data;
            cmd.Parameters.Add(blob);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("data added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void read(string query, int id, string name, DataGridView dg)
        {
            //con.Open();
            string command = query;
            MySqlCommand cmd = new MySqlCommand(@command, connectstr);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.RowTemplate.Height = 120;
            da.Fill(dt);
            dg.DataSource = dt;
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol = (DataGridViewImageColumn)dg.Columns[4];
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
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
