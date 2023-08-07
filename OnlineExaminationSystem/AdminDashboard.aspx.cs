using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("change_password.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Students.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_Student.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("AddQandA.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewResult.aspx");
        }
    }
}