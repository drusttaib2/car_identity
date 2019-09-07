using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;
using System.IO.Ports;
namespace Car_Identity.pages
{
    public partial class seller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            main_master ms = new main_master();
            string password;
            try
            {
                string data_connection = ms.conncetion();
                MySqlConnection con = new MySqlConnection(data_connection);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select password from `car_identitiy`.`buyer_app` where password="+TextBox1.Text+";", con);
               
                MySqlDataReader data = cmd.ExecuteReader();

                GridView datas_grid = new GridView();
                datas_grid.DataSource = data;
                datas_grid.DataBind();
                datas_grid.Dispose();


                string result = datas_grid.Rows[0].Cells[0].Text;
                password = result;
                con.Close();
            }
            catch (Exception)
            {
               
                throw;
            }
            if(password=="" || password == null)
            {
                return;
            }


            string command = "INSERT INTO `car_identitiy`.`seller_app` (`office_info_family_owner`, `office_info_address`, `office_info_application_id`, `national_id_number`, `national_id_name`, `national_id_father`, `national_id_grandfather`, `national_id_surname`, `national_id_mother`, `national_id_sex`, `national_id_blood_type`,`photo`,`password`) VALUES ('" + of_family_owner.Text + "', '" + of_address.Text + "', '" + of_application_id.Text + "', '" + ni_number.Text + "', '" + ni_name.Text + "', '" + ni_father.Text + "', '" + ni_grandfather.Text + "', '" + ni_surname.Text + "', '" + ni_mother.Text + "', '" + ni_sex.Text + "', '" + ni_blood_type.Text + "', '@image_data', '" + password + "');" +
                "INSERT INTO `car_identitiy`.`pending` (`password`) VALUES ('" + password + "');"+ "INSERT INTO `car_identitiy`.`officer_fine` (`password`) VALUES ('" + password + "');";


            HttpPostedFile postedFile = FileUpload1.PostedFile;
            string fileName = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(fileName);
            int filesize = postedFile.ContentLength;

            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".bmp" || fileExtension.ToLower() == ".jpeg")
            {

                if (filesize <= 62000)
                {


                    string data_connection = ms.conncetion();
                    MySqlConnection con = new MySqlConnection(data_connection);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(command, con);

                    Stream stream = postedFile.InputStream;
                    BinaryReader binaryReader = new BinaryReader(stream);
                    byte[] bytes = binaryReader.ReadBytes((int)stream.Length);
                    cmd.Parameters.Add("@image_data", MySqlDbType.Blob).Value = bytes;
                    cmd.ExecuteNonQuery();
                    con.Close();



                    
                    System.Diagnostics.Debug.WriteLine("***** uploadImageBytes:successful");
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('بەسەرکەوتووی تۆمار کرا، ')", true);
                    Response.Redirect("~/pages/Home.aspx");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("***** uploadImage: error");
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('دەبێت وێنەکەت لە 62 کیلۆ بایت  مێگابایت زیاتر نەبێت')", true);

                }


            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}