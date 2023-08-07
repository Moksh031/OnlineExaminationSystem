using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class Add_Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label9.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection("Trusted_Connection = Yes;database = moksh; server =MOKSH"))
            {
                string value = "";
                bool isChecked = RadioButton1.Checked;
                if (isChecked)
                    value = RadioButton1.Text;
                else
                    value = RadioButton2.Text;
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("Insert into student values ("+TextBox1.Text+",'"+TextBox2.Text+"','"+TextBox3.Text+"','"+value+"',"+TextBox4.Text+",'"+TextBox5.Text+"')", sqlCon);
                int i= cmd.ExecuteNonQuery();
                if (i >= 1)
                {
                    
                    Button2.Visible = true;
                    

                }
                else
                    Response.Write("wrong values inserted ");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard.aspx");
        }
    }
}