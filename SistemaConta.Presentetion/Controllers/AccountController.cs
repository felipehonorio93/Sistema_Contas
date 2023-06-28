using ContasApp.Data.Entities;
using ContasApp.Data.Repositories;
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
            //verificando se todos os campos enviados pela model
           //passaram nas regras de validação
            if (ModelState.IsValid)
            {
                //criando um objeto usuário
                var usuario = new Usuario()
                {
                    Id = Guid.NewGuid(),
                    Nome = model.Nome,
                    Email = model.Email,
                    Senha = model.Senha
                };
               
                //gravando o usuário no banco de dados
                var usuarioRepository = new UsuarioRepository();
                usuarioRepository.Add(usuario);
                
                //gerando uma mensagem
                TempData["Mensagem"] = "Parabéns, sua conta de usuário foi criada com sucesso.";
            
                //limpar os campos do formulário
                ModelState.Clear();
            }

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
