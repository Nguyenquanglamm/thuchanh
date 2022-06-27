using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thuchanh.Models;
using System.Web.Security;

namespace Thuchanh.Controllers
{
    public class AccountsController : Controller
    {
        public ActionResult Login(Accounts acc)
        {
            if(acc.userName == "Admin" && acc.passWord== "123456")
            {
                FormsAuthentication.SetAuthCookie(acc.userName, true);
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Accounts");
        }
        public ActionResult DangNhap(string userName, string passWord)
        {
            if (userName == "Admin" && passWord == "123456")
            {
                FormsAuthentication.SetAuthCookie(userName, true);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
