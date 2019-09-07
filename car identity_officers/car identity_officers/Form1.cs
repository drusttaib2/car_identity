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
    public partial class Form1 : Form
    {
        public readonly string server_name = "localhost";
        public readonly string server_username = "root";
        public readonly string server_password = "drust2014";
        public readonly string server_database = "car_identitiy";
        public string conncetion()
        {
            string result = "server=" + server_name + ";userid =" + server_username + ";database=" + server_database + ";password=" + server_password + "; port = 3306; persistsecurityinfo = True";
            return result;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ls = new Form2();
            ls.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 ls = new Form4();
            ls.Show();
        }
    }
}
