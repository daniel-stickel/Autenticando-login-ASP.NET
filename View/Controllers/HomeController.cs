using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using View.Models;
using BAL;
using Model;

namespace View.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Resposta res;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            res = new Resposta();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Informacao()
        {
            return View();
        }

        public IActionResult LoginPage()
        {
            return View();
        }

        public IActionResult RegisterPage()
        {            
            return View(res);
        }

        public IActionResult AuthCadastro(string email, string userLogin, string userPassword)
        {
            res = Caster.ResponseToResposta(CadastroBAL.Insert(email, userLogin, userPassword));
            if (res.Success)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("RegisterPage", "Home");
            }
        }
        [HttpPost]
        public IActionResult AuthLogin(string user, string password)
        {
            //autenticar o login
            if (user == "Admin" && password == "Admin")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}