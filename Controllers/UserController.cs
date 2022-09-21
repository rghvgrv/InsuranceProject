using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UserClass;
using UserClass.Model;

namespace InsuranceProjectMVC.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var com = new UserComponent();
            var user = com.ValidateUser(email, password);
            if (user == null)
            {
                ModelState.AddModelError("LoginFailure", "Login failed for the user");
                return View();
            }
            Session["CurrentUser"] = user;
            FormsAuthentication.SetAuthCookie(user.userEmail, false);
            FormsAuthentication.RedirectFromLoginPage(user.userEmail, false);
            return RedirectToAction("Index", "Home");
        }
        public ActionResult RegisterNew()
        {
            UserTable model = new UserTable();
            return View(model);
        }
        [HttpPost]
        public ActionResult RegisterNew(UserTable postedData)
        {
            IUserModule com = new UserComponent();
            try
            {
                com.RegisterUser(postedData);
                return RedirectToAction("Login");
            }
            catch (CustomerAlreadyExistsException ex)
            {
                ModelState.AddModelError("CustomerError", ex.Message);
                return View(postedData);
            }
        }

        


    }
}