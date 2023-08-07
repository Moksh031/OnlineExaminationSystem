using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class GiveTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string a1 = Session["_ans1"].ToString();
            string a2 = Session["_ans2"].ToString();
            string a3 = Session["_ans3"].ToString();
         //   string a4 = Session["_ans4"].ToString();
           // string a5 = Session["_ans5"].ToString();
            int mark = 0;

            if (RadioButtonList2.SelectedIndex > -1)
            {
                if (RadioButtonList2.SelectedItem.Text == a1)
                {
                    mark++;
                }
            }
            if (RadioButtonList3.SelectedIndex > -1)
            {
                if (RadioButtonList3.SelectedItem.Text == a2)
                {
                    mark++;
                }
            }
            if (RadioButtonList4.SelectedIndex > -1)
            {
                if (RadioButtonList4.SelectedItem.Text == a3)
                {
                    mark++;
                }
            }
           /* if (RadioButtonList5.SelectedIndex > -1)
            {
                if (RadioButtonList5.SelectedItem.Text == a4)
                {
                    mark++;
                }
            }
            if (RadioButtonList6.SelectedIndex > -1)
            {
                if (RadioButtonList6.SelectedItem.Text == a5)
                {
                    mark++;
                }
            }*/
            Session["_tMark"] = mark;
            Response.Write("Your Score is " +mark+" Out of 3");

            // for inserting marks in table
            SqlConnection con = new SqlConnection("Trusted_Connection = Yes;database = moksh; server =MOKSH");
            con.Open();
            
            SqlCommand cmd = new SqlCommand("insert into result values('"+TextBox1.Text+"'," + mark + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();

            //Server.Transfer("STUDENTDASH.aspx", true);

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Compare(DateTime.Now, DateTime.Parse(Session["Timer"].ToString())) < 0)
            {
                Label3.Text = "Time Left : " + ((Int32)DateTime.Parse(Session["Timer"].ToString()).Subtract(DateTime.Now).TotalMinutes).ToString() + " Minute " + (((Int32)DateTime.Parse(Session["Timer"].ToString()).Subtract(DateTime.Now).TotalSeconds) % 60).ToString() + " Seconds";
            }
            else
            {
                //Server.Transfer("LoginPage.aspx", true);

                Label3.Text = "Time Out!";


            }
        }
    }
}
