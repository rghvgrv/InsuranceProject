using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InsuranceProject
{
	public partial class AdminSignUp : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}
		protected void signBtn_Click(object sender, EventArgs e)
		{

					var adminName = AdminName.Text;
					var adminEmail = AdminEmail.Text;
					var adminCont = AdminCon.Text;
					var adminPwd = AdminPwd.Text;
					string sqlstring = $"Insert into AdminTable values('{adminName}', '{adminEmail}','{adminPwd}',{adminCont})";
					string cs = System.Configuration.ConfigurationManager.ConnectionStrings["myInsurance"].ConnectionString;
					SqlConnection con = new SqlConnection(cs);
					SqlCommand cmd = new SqlCommand(sqlstring,con);
					con.Open();
					cmd.ExecuteNonQuery();
					con.Close();
		}
	}
}