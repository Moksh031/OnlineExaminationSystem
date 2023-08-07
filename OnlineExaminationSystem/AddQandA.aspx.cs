using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class AddQandA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection("Trusted_Connection = Yes;database = moksh; server =MOKSH");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("insert into mcqdetails values (@ques,@op1,@op2,@op3,@op4,@ans,@qtag)", sqlcon);
            cmd.Parameters.AddWithValue("@ques", TextBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@op1", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@op2", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@op3", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@op4", TextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@ans", TextBox6.Text.Trim());
            cmd.Parameters.AddWithValue("@qtag", TextBox7.Text.Trim());

            int i = cmd.ExecuteNonQuery();
            sqlcon.Close();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";

            Response.Write("Question Added Succesfully");
        }
    }
}