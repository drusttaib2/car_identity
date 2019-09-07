using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Identity.pages
{
    public partial class main_master : System.Web.UI.MasterPage
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (Menu1.SelectedValue)
            {
                case "1":
                    Response.Redirect("~/pages/Home.aspx");
                    break;
                case "2":
                    Response.Redirect("~/pages/pending_log_in.aspx");
                    break;
                case "3":
                    Response.Redirect("~/pages/buyer.aspx");
                    break;
                case "4":
                    Response.Redirect("~/pages/seller.aspx");
                    break;
                case "5":
                    Response.Redirect("#");
                    break;
                default:
                    break;
            }
        }
    }
}