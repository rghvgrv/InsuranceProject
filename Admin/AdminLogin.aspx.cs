using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InsuranceProject
{
	public partial class AdminLogin : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			var adminUser = AdminMail.Text;
			var adminPwd = AdminPwd.Text;
			
			string cs = System.Configuration.ConfigurationManager.ConnectionStrings["myInsurance"].ConnectionString;
			SqlConnection con = new SqlConnection(cs);
			con.Open();
			string qry = "Select *,AdminName from AdminTable where AdminEmail= '" + adminUser + "' and AdminPassword = '" + adminPwd + "'";
			 
			SqlCommand cmd = new SqlCommand(qry, con);
			SqlDataReader sdr = cmd.ExecuteReader();


			if (sdr.Read())
			{
				Response.Redirect("~/Admin/AdminHome.aspx");
			}
			else
			{
			  Label1.Text ="Wrong ID or PWD";
			}
			con.Close();

		}
	}
}