using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Identity.pages
{
    public partial class pending : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            main_master ms = new main_master();
            string pass = Session["password"].ToString();
            string command = "SELECT * FROM car_identitiy.pending where password=" + pass + ";";

            string data_connection = ms.conncetion();
            MySqlConnection con = new MySqlConnection(data_connection);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(command, con);
            MySqlDataReader data = cmd.ExecuteReader();


            GridView datas_grid = new GridView();
            datas_grid.DataSource = data;
            datas_grid.DataBind();
            datas_grid.Dispose();

            if (datas_grid.Rows[0].Cells[3].Text.Equals("1"))
            {
                Image1.BackColor= Color.Green;
            }
            if (datas_grid.Rows[0].Cells[4].Text.Equals("1"))
            {
                Image2.BackColor = Color.Green;
            }
            Label1.Text = "بڕی سزا: " + datas_grid.Rows[0].Cells[2].Text;
            con.Close();
        }
    }
}