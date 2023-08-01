using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BharatSharma05
{
    public partial class EmployeeData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Initial catalog=Bharat3; integrated security=true;server=VDILEWVPNTH520");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into EmployeeDetails values('" + TextBox2.Text + "','" + TextBox1.Text
                + "','" + TextBox3.Text + "','" + TextBox7.Text + "', '" + TextBox5.Text+ "', '" + TextBox4.Text
                + "','" + TextBox6.Text + "','" + "" + "','" + "" + "' )", con);
          //  Label14.Text = cmd.CommandText;
            int i = cmd.ExecuteNonQuery();
            //   Label14.Text = "Record inserted successfully " + i;
            Label10.Text = "Record inserted successfully ";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            String query = "select * from EmployeeDetails where id = '" + TextBox2.Text + "'";
            SqlConnection con = new SqlConnection("Initial catalog=Bharat3; integrated security=true;server=VDILEWVPNTH520");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if ((i >= 0) && (i < ds.Tables[0].Rows.Count))
            {
                TextBox2.Text = ds.Tables[0].Rows[i][0].ToString();
                TextBox1.Text = ds.Tables[0].Rows[i][1].ToString();
                TextBox3.Text = ds.Tables[0].Rows[i][2].ToString();
                TextBox7.Text = ds.Tables[0].Rows[i][3].ToString();
                TextBox5.Text = ds.Tables[0].Rows[i][4].ToString();
                TextBox4.Text = ds.Tables[0].Rows[i][5].ToString();
                TextBox6.Text = ds.Tables[0].Rows[i][6].ToString();
               
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Initial catalog=Bharat3; integrated security=true;server=VDILEWVPNTH520");
            con.Open();

           
            SqlCommand cmd1 = new SqlCommand("update EmployeeDetails set name = '" + TextBox1.Text + "' ," +
                " source = '" + TextBox3.Text + "'," +
                " destination = '"  + TextBox7.Text + "'," +
                " timetravel = '" + TextBox5.Text + "'," +
                " schedule = '" + TextBox4.Text + "'," +
                " feedback = '" + TextBox6.Text + "' where id = '" + TextBox2.Text + "' ", con);
            //  Label14.Text = cmd.CommandText;
            int i = cmd1.ExecuteNonQuery();
            //   Label14.Text = "Record inserted successfully " + i;
            Label10.Text = "Record updated successfully ";

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}
