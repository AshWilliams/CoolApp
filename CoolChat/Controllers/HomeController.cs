﻿using System.Web.Mvc;

namespace CoolChat.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
       
        private bool _IsAuthenticated;
        private string _LoggedUser;

        public ActionResult Index()
        {
            _IsAuthenticated = Request.IsAuthenticated;
            if (_IsAuthenticated)
            {
                _LoggedUser = HttpContext.User.Identity.Name;
                return RedirectToAction("Index", "Chat");
            }

            return RedirectToAction("Login", "Account");
        }
       
       
    }
}
