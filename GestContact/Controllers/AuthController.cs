using GestContact.Models.Auth;
using GestContact.Models.Client.Data;
using System;
using System.Web.Mvc;
using GestContact.Models.Client.Services;
using GestContact.Infrastructure;
using GestContact.Infrastructure.Attributes;

namespace GestContact.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }

        [AnonymousRequired]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AnonymousRequired]
        public ActionResult Login(LoginForm loginForm)
        {
            if (ModelState.IsValid)
                try
                {
                    User u = ServiceLocator.Instance.AuthService.Login(loginForm.Email, loginForm.Pwd);
                    if (!(u is null))
                    {
                        SessionManager.User = u;
                        return RedirectToAction("Index", "Home");
                    }
                    ViewBag.Error = "La combinaison email et mot de passe n'est pas valide.";
                }
                catch (Exception e)
                {
                    ViewBag.Error = e.Message;
                }
            return View(loginForm);
        }

        [AnonymousRequired]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AnonymousRequired]
        public ActionResult Register(RegisterForm registerForm)
        {
            if (ModelState.IsValid)
                try
                {
                    User u = new User(registerForm.Fname, registerForm.Lname, registerForm.Email, registerForm.Passwd);
                    ServiceLocator.Instance.AuthService.Register(u);
                    return RedirectToAction("Login");
                }
                catch (Exception e)
                {
                    ViewBag.Error = e.Message;
                }
            return View(registerForm);
        }

        [AuthenticatedRequired]
        public ActionResult LogOut()
        {
            SessionManager.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}