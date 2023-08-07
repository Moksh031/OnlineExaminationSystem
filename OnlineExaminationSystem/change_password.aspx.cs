using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class change_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection("Trusted_Connection = Yes;database = moksh; server =MOKSH"))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(" update student set pass='" + TextBox3.Text + "' where smail= '" + TextBox1.Text + "'", sqlCon);
                int i = cmd.ExecuteNonQuery();

                if(i == 1) { 
                Response.Write("Passsword Changed succesfully");
                    Button2.Visible = true;
                    Label4.Visible = false;

                }
                else
                {
                    Label8.Visible = true;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("student dashboard.aspx");

        }
    }
}