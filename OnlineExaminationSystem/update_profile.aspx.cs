using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class update_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection("Trusted_Connection = Yes;database = moksh; server =LAPT"))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM student WHERE stuid='" + TextBox1.Text + "'", sqlCon);


                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label7.Visible = true;
                    TextBox3.Visible = true;
                    TextBox2.Visible = true;
                    TextBox4.Visible = true;
                    Button3.Visible = true;


                }
                else
                {
                    Label8.Visible = true;
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection("Trusted_Connection = Yes;database = online_exam; server =LAPTOP-NK42R28Q"))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(" update student set sname='" + TextBox2.Text + "',smail='" + TextBox3.Text + "',mobno=" + TextBox4.Text + " where stuid= '" + TextBox1.Text + "'", sqlCon);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {

                    Button4.Visible = true;
                    Label9.Visible = true;

                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("student dashboard.aspx");
        }
    }
}