using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InsuranceProject
{
	public partial class AdminPage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click1(object sender, EventArgs e)
		{
			var url = "~/AdminLogin.aspx";
			Response.Redirect(url);

		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			var url = "~/AdminSignUp.aspx";
			Response.Redirect(url);
		}
	}
	}

