using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Identity.pages
{
    public partial class buyer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            main_master ms = new main_master();
            Random r_num = new Random();
            
            string command = "INSERT INTO `car_identitiy`.`buyer_app` (`office_info_family_owner`, `office_info_address`, `office_info_application_id`, `national_id_number`, `national_id_name`, `national_id_father`, `national_id_grandfather`, `national_id_surname`, `national_id_mother`, `national_id_sex`, `national_id_blood_type`,`car_name`,`car_address`,`car_model`,`car_number`,`car_shasi_number`,`car_color`,`car_start_date`,`car_end_date`)" +
                                                             " VALUES ('" + of_family_owner.Text + "', '" + of_address.Text + "', '" + of_application_id.Text + "', '" + ni_number.Text + "', '" + ni_name.Text + "', '" + ni_father.Text + "', '" + ni_grandfather.Text + "', '" + ni_surname.Text + "', '" + ni_mother.Text + "', '" + ni_sex.Text + "', '" + ni_blood_type.Text + "', '" + c_full_name.Text+"','" + c_address.Text + "', '" +c_model.Text + "','"+c_number.Text + "','"+c_shasi.Text + "','"+c_color.Text + "','"+c_started.Text + "','"+c_ends.Text + "'); ";

            string data_connection = ms.conncetion();
            MySqlConnection con = new MySqlConnection(data_connection);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(command, con);


           
            cmd.ExecuteNonQuery();
            con.Close();


           
            Session["car_number"] = c_number.Text;
            System.Diagnostics.Debug.WriteLine("***** uploadImageBytes:successful");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('بەسەرکەوتووی تۆمار کرا، ')", true);
            Response.Redirect("~/pages/buyer_applied.aspx");
           






        }
    }
}