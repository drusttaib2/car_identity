using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_identity_officers
{
    public partial class image : Form
    {
        string pass;
        public image(string password)
        {
            InitializeComponent();
            password = password;
        }

        private void image_Load(object sender, EventArgs e)
        {
          
            //Form1 ms = new Form1();
            //string conn = ms.conncetion();
            //MySqlConnection con = new MySqlConnection(conn);
            //con.Open();
            //MySqlCommand cmd = new MySqlCommand("select `photo` from car_identitiy.buyer_app where password ="+pass+";", con);
            //byte[] data = (byte[])cmd.ExecuteScalar();
            ////for (int i = 0; i < value.Length; i++)
            ////{
            ////    data[i] = (byte)value[i];
            ////}
            //con.Close();
            //string strBase64 = Convert.ToBase64String(data);
            //string url = "data:Image/png;base64," + strBase64;
            //pictureBox1.Image = url;
            //Image3.ImageUrl = url;
            //System.Diagnostics.Debug.WriteLine("***** imageUrl: " + url);


            //using (MemoryStream mStream = new MemoryStream(strBase64))
            //{
            //    return Image.FromStream(mStream);
            //}
        }
    }
}
