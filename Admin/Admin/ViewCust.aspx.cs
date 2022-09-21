using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InsuranceProject.Admin
{
	public partial class ViewCust : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string sqlstring = "Select * from User_Insurance";
			string cs = System.Configuration.ConfigurationManager.ConnectionStrings["myInsurance"].ConnectionString;
			SqlConnection con = new SqlConnection(cs);
			con.Open();
			SqlCommand cmd = new SqlCommand(sqlstring, con);
			SqlDataReader sdr = cmd.ExecuteReader();
			grdView.DataSource = sdr;
			grdView.DataBind();
		}
	}
}