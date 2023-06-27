using Microsoft.AspNetCore.Mvc;
using SistemaConta.Presentetion.Models;

namespace SistemaConta.Presentetion.Controllers
{
    public class AccountController : Controller
    {
        //GET: Account/Login
        public IActionResult Login()
        {
            return View();
        }
        //POST: Account/Login
        [HttpPost]
        public IActionResult Login(AccountLoginViewModel model)
        {
            return View();

        }

        //GET: Account/Register
        public IActionResult Register()
        {
            return View();
        }

        //POST: Account/Register
        [HttpPost]
        public IActionResult Register(AccountRegisterViewModel model)
        {
            return View();
        }

        //GET: Account/PasswordRecover
        public IActionResult PasswordRecover()
        {
            return View();
        }

        //POST: Account/PasswordRecover
        [HttpPost]
        public IActionResult PasswordRecover (AccountPasswordRecoverViewModel model)
        {
            return View();
        }
    }
}
