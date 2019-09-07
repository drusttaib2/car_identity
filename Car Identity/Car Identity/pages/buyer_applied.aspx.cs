using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Identity.pages
{
    public partial class buyer_applied : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            main_master ms = new main_master();
            string data_connection = ms.conncetion();
            string text = Session["car_number"].ToString();
            System.Diagnostics.Debug.WriteLine("***** text: "+text);
            //done
            MySqlConnection con2 = new MySqlConnection(data_connection);
            con2.Open();
            MySqlCommand cmd2 = new MySqlCommand("select password from `car_identitiy`.`buyer_app` where car_number=" + text + ";", con2);

            MySqlDataReader data2 = cmd2.ExecuteReader();

            GridView datas_grid = new GridView();
            datas_grid.DataSource = data2;
            datas_grid.DataBind();
            datas_grid.Dispose();

            string r_value = datas_grid.Rows[0].Cells[0].Text;
            Label1.Text = r_value;
        }
    }
}