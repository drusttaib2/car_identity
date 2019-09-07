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

namespace car_identity_officers
{
    public partial class Form3 : Form
    {
        public int password;
        public Form3(int value)
        {
            InitializeComponent();
            password = value;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            Form1 ms = new Form1();

            string command = "SELECT * FROM car_identitiy.seller_app where password="+password+";";

            string data_connection = ms.conncetion();
            MySqlConnection con = new MySqlConnection(data_connection);
            con.Open();


            MySqlDataAdapter cmd = new MySqlDataAdapter(command, con);


            DataTable dtl = new DataTable();
            cmd.Fill(dtl);

            

            con.Close();
            label3.Text = "ئۆفیسی زانیاری:" + "\n" + "سەرپەرشتیاری خێزان: "+ dtl.Rows[0][1].ToString() + "\n" + "ناونیشان: "+ dtl.Rows[0][2].ToString()+"\n"+"ژمارەی مامەڵە: "+ dtl.Rows[0][3].ToString()+ "\n" + "\n" + "کارتی زانیاری:" +"\n"+ "ژمارە: " + dtl.Rows[0][4].ToString() + "\n" + "ناو: " + dtl.Rows[0][5].ToString() + "\n" + "باوک: " + dtl.Rows[0][6].ToString() + "\n" + "باپیر: " + dtl.Rows[0][7].ToString() + "\n" + "نازناو: " + dtl.Rows[0][8].ToString() + "\n" + "دایک: " + dtl.Rows[0][9].ToString() + "\n"  + "ڕەگەز: " + dtl.Rows[0][10].ToString() + "\n" + "گروپی خوێن: " + dtl.Rows[0][11].ToString();


            //buyer
            string command2 = "SELECT * FROM car_identitiy.buyer_app where password=" + password + ";";

          
            MySqlConnection con2 = new MySqlConnection(data_connection);
            con2.Open();


            MySqlDataAdapter cmd2 = new MySqlDataAdapter(command2, con2);


            DataTable dtl2 = new DataTable();
            cmd2.Fill(dtl2);



            con2.Close();
            label2.Text = "ئۆفیسی زانیاری:" + "\n" + "سەرپەرشتیاری خێزان: " + dtl2.Rows[0][1].ToString() + "\n" + "ناونیشان: " + dtl2.Rows[0][2].ToString() + "\n" + "ژمارەی مامەڵە: " + dtl2.Rows[0][3].ToString() + "\n" + "\n" + "کارتی زانیاری:" + "\n" + "ژمارە: " + dtl2.Rows[0][4].ToString() + "\n" + "ناو: " + dtl2.Rows[0][5].ToString() + "\n" + "باوک: " + dtl2.Rows[0][6].ToString() + "\n" + "باپیر: " + dtl2.Rows[0][7].ToString() + "\n" + "نازناو: " + dtl2.Rows[0][8].ToString() + "\n" + "دایک: " + dtl2.Rows[0][9].ToString() + "\n" + "ڕەگەز: " + dtl2.Rows[0][10].ToString() + "\n" + "گروپی خوێن: " + dtl2.Rows[0][11].ToString()+"\n\n"+"سەنەوی:"+"\n"+"ناوی تەواو: "+ dtl2.Rows[0][12].ToString()+"\n"+"ناونیشان: "+ dtl2.Rows[0][13].ToString()+"\n" + "مۆدێل: " + dtl2.Rows[0][14].ToString() + "\n" + "ژمارە: " + dtl2.Rows[0][15].ToString() + "\n" + "ژمارەی شاصی: " + dtl2.Rows[0][16].ToString() + "\n" + "ڕەنگ: " + dtl2.Rows[0][17].ToString() + "\n" + "بەرواری دەرچوون: " + dtl2.Rows[0][18].ToString() + "\n" + "بەرواری بەسەرچوون:" + dtl2.Rows[0][19].ToString() ;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "UPDATE `car_identitiy`.`pending` SET `tax_amount` = '"+textBox1.Text+"', `tax_enable` = '1' WHERE (`password` = '"+password+"');";
            Form1 ms = new Form1();
            string data_connection = ms.conncetion();
            MySqlConnection con = new MySqlConnection(data_connection);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(command, con);


            cmd.ExecuteNonQuery();
            con.Close();

            string command2 = "INSERT INTO `car_identitiy`.`officer_computer` (`password`) VALUES ('"+password+"');";
           
            
            MySqlConnection con2 = new MySqlConnection(data_connection);
            con2.Open();
            MySqlCommand cmd2 = new MySqlCommand(command2, con2);


            label5.Visible = true;
            cmd2.ExecuteNonQuery();
            con2.Close();
        }
    }
}
