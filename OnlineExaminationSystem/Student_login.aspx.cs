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
    public partial class Student_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
           
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection("Trusted_Connection = Yes;database = moksh; server =MOKSH"))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM student WHERE smail='" + TextBox1.Text + "' AND pass='" + TextBox2.Text + "' ", sqlCon);


                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["username"] = TextBox1.Text.Trim();
                    Response.Write("Login Sucessfull");
                    Response.Redirect("student dashboard.aspx");

                }
                else
                {
                    Label3.Visible=true;
                }
            }

            
        }
    }
}