using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InsuranceProject.Admin
{
	public partial class AddUser : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}
		protected void GenerateCode(object sender , EventArgs e)
		{
			string selected = addDrop.SelectedItem.Value;
			string code = string.Empty;
			if (selected == "Life Insurance")
			{
				addAmt.Text = "1000";
			}
			else if (selected == "Health Insurance")
			{
				addAmt.Text = "500";
			}
			else if (selected == "Travel Insurance")
			{
				addAmt.Text = "200";
			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			List<string> insurance = new List<string>();
			insurance.Add(addDrop.Text);
			foreach (var item in insurance)
			{
				Label1.Text = item;
			}
			
		}

		protected void registerBtn_Click(object sender, EventArgs e)
		{
			var addFirstName = addFirst.Text;
			var addLastName = addLast.Text;
			var addEmailUser = addEmail.Text;
			var addUserDob = txtdob.Text;
			var addUserCon = addCon.Text;
			var addUserAdd = addAdd.Text;
			var addUserPwd = addPwd.Text;
			var userInsurance1 = addDrop.SelectedValue;
			string cs = System.Configuration.ConfigurationManager.ConnectionStrings["myInsurance"].ConnectionString;
			//string sqlstring = $"Insert into UserTable values('{addFirstName}', '{addLastName}', '{addEmailUser}','{addUserDob}',{addUserCon}, '{addUserAdd}', '{addUserPwd}', '{1}')";
			string sqlstring = $"Insert into User_Insurance values('{addFirstName}', '{addLastName}', '{addEmailUser}','{addUserDob}',{addUserCon}, '{addUserAdd}', '{userInsurance1}')";
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand(sqlstring, con);
			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();

		}
	}
} 