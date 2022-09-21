using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserClass;
using UserClass.Model;

namespace InsuranceProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            if (Session["CurrentUser"] != null)
            {
                 
                var userDetails = Session["CurrentUser"] as UserTable;
                return "<h1>HOME PAGE</h1><hr/>Welcome to User: " + userDetails.userFirstName;
            }
            else
                return "<h1>HOME PAGE</h1><hr/>Welcome to Anonymous User";
        }
        public ActionResult UpdateUser()
        {
            UserTable model = new UserTable();
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateUser(UserTable updateUser)
        {
            var context = new InsuranceDBEntities();
            IUserModule com = new UserComponent();

            var rec = context.UserTables.FirstOrDefault((e) => e.userId == updateUser.userId);

            try
            {
                com.UpdateUserDetails(rec.userAddress, rec.userContact.ToString(), rec.userId);
                return RedirectToAction("UpdateUser");
            }
            catch (CustomerAlreadyExistsException ex)
            {
                ModelState.AddModelError("CustomerError", ex.Message);
                return View(updateUser);
            }
        }

    }
}
