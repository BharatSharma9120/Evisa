using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BharatSharma05
{
    public partial class HRLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Initial catalog=Bharat3; integrated security=true;server=VDILEWVPNTH520");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into hr values('" + TextBox3.Text + "','" + TextBox1.Text
                + "','" + TextBox2.Text + "' )", con);
            Label4.Text = cmd.CommandText;
            int i = cmd.ExecuteNonQuery();
            Label4.Text = "Sign Up Successfully You can now login";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Initial catalog=Bharat3; integrated security=true;server=VDILEWVPNTH520");
            con.Open();


            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM hr WHERE id ='" + TextBox3.Text + "'And UserName='" + TextBox1.Text + "'And Password='" + TextBox2.Text + "'", con);
            /*cmd.Parameters.AddWithValue("@username", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@password", TextBox2.Text.Trim()); */
            int count;
            count = Convert.ToInt32(cmd.ExecuteScalar());
            Response.Write(count);
            if (count == 1)
            {
                Session["@username"] = TextBox1.Text;
                Response.Redirect("HRdata.aspx");
                // Response.Redirect("ADMINDASH.aspx");
            }
            else
                Label4.Text = "Invalid Credentials";

        }
    }
}