using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceProject.Models
{
	public class Admin
	{
		public int AdminId { get; set; }
		public string AdminName { get; set; }
		public string AdminEmail { get; set; }
		public string Password { get; set; }
		public int AdminContact { get; set; }
	}

	public static class AdminRepo
	{
		private static List<Admin> admin = new List<Admin>();
		static AdminRepo()
		{
			admin.Add(new Admin { AdminId = 1, AdminName="Grv",AdminEmail="grv@gmail.com", AdminContact=1234567,Password="123" });
		}

		public static List<Admin> admins = admin;
	}


}