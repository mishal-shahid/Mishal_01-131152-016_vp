using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
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
            MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM signup WHERE useid =@id AND password=@pass", connectstr);
            cmd.Parameters.AddWithValue(@"id", id);
            cmd.Parameters.AddWithValue(@"pass", pass);
            MySqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
                val = true;
            return val;
        }

        public void read(int id,string name, DataGridView dg)
        {
            //con.Open();
            MySqlCommand cmd = new MySqlCommand(@"select * from image where id=@id AND name=@name", connectstr);
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
        public void insert(int id, string name, string contact, string catogery,Image img)
        {
            MySqlCommand cmd = new MySqlCommand(@"insert into image (id,name,contact,catogery,image) VALUES (@ID,@NAME,@CONTACT,@CATOGERY,@IMG)",connectstr);
            cmd.Parameters.AddWithValue(@"ID",id);
            cmd.Parameters.AddWithValue(@"NAME",name );
            cmd.Parameters.AddWithValue(@"CONTACT", contact);
            cmd.Parameters.AddWithValue(@"CATOGERY", catogery);
            byte[] data = imageToByte(img);
            MySqlParameter blob = new MySqlParameter("@IMG", MySqlDbType.Blob, data.Length);
            blob.Value = data;
            cmd.Parameters.Add(blob);
            if(cmd.ExecuteNonQuery()==1)
            { 
                MessageBox.Show("data added successfully");
            }
        }
        public byte[] imageToByte(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

    }
}
