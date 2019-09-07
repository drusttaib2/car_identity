using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Identity.pages
{
    public partial class pending_log_in : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            main_master ms = new main_master();

            


                string command = "select password from `car_identitiy`.`buyer_app` where password=" + TextBox1.Text+";";

                string data_connection = ms.conncetion();
                MySqlConnection con = new MySqlConnection(data_connection);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(command, con);
                MySqlDataReader data = cmd.ExecuteReader();
          

                GridView datas_grid = new GridView();
                datas_grid.DataSource = data;
                datas_grid.DataBind();
                datas_grid.Dispose();
                 Session["password"] = TextBox1.Text;
               
                con.Close();
                Response.Redirect("~/pages/pending.aspx");
           








        }
    }
}