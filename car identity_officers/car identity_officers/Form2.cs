using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace car_identity_officers
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            data_refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data_refresh();
        }
        public void data_refresh()
        {
            Form1 ms = new Form1();

            string command = "SELECT * FROM car_identitiy.officer_fine;";

            string data_connection = ms.conncetion();
            MySqlConnection con = new MySqlConnection(data_connection);
            con.Open();


            MySqlDataAdapter cmd = new MySqlDataAdapter(command, con);


            DataTable dtl = new DataTable();
            cmd.Fill(dtl);

            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                listBox1.Items.Add(dtl.Rows[i][1]);
            }

            con.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = listBox1.SelectedItem.ToString();
            Form3 fm = new Form3(Int32.Parse(value));
            fm.Show();
        }
    }
}
