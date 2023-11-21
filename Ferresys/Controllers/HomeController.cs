using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Ferresys.Models;
using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;

namespace AppWeb_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult IniciarSesion(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                bool credencialesValidas = ValidarCredenciales(login.Email, login.Password);

                if (credencialesValidas)
                {
                    return RedirectToAction("Home", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Credenciales no válidas");
                }
            }

            return View(login);
        }

        private bool ValidarCredenciales(string usuario, string password)
        {
            var usuarioEncontrado = _context.Usuarios.FirstOrDefault(u => u.Usuario == usuario && u.Password == password);

            return usuarioEncontrado != null;
        }

        public IActionResult IngresarCliente()
        {
            var nuevoCliente = new ClienteModel();
            return View(nuevoCliente);
        }

        [HttpPost]
public IActionResult AgregarCliente(ClienteModel model)
{
    if (ModelState.IsValid)
    {
        Console.WriteLine("Aqui estamos");
        _context.Clientes.Add(model);
        _context.SaveChanges();
    }
    else
    {
        Console.WriteLine("Aqui fuimos");
        foreach (var modelStateKey in ModelState.Keys)
        {
            var modelStateVal = ModelState[modelStateKey];
            foreach (var error in modelStateVal.Errors)
            {
                Console.WriteLine($"{modelStateKey}: {error.ErrorMessage}");
            }
        }
        return View("IngresarCliente", model);
    }

    return View("GestionCliente");
}


        public IActionResult GestionCliente()
        {
            var listaClientes = _context.Clientes.ToList();
            return View(listaClientes);
        }


    }
}