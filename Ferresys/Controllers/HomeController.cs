using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Ferresys.Models;
using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;

namespace Ferresys.Controllers
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
        // Populate dropdown lists
        ViewBag.Sexos = _context.Sexo.ToList();  
        ViewBag.RazonSocial = _context.RazonSocial.ToList();
        ViewBag.TipoClientes = _context.TipoClientes.ToList();
        ViewBag.Regiones = _context.Regiones.ToList();
        ViewBag.Comunas = _context.Comunas.ToList();

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
            
            return View("GestionarCliente");
        }
        public IActionResult gestionarEmpleado()
        {
            
            return View("gestionarEmpleado");
        }
        public IActionResult gestionarBodega()
        {
            
            return View("gestionarBodega");
        }
        public IActionResult gestionarProveedor()
        {
            
            return View("gestionarProveedor");
        }
        public IActionResult gestionarProducto()
        {
            
            return View("gestionarProducto");
        }
        public IActionResult Perfil()
        {
            
            return View("Perfil");
        }

        public IActionResult IngresarEmpleado()
        {
            var nuevoEmpleado = new EmpleadoModel();
            return View(nuevoEmpleado);
        }

        public IActionResult AgregarEmpleado(EmpleadoModel modele)
{
    if (ModelState.IsValid)
    {
        Console.WriteLine("Aqui estamos");
        _context.Empleados.Add(modele);
        _context.SaveChanges();
    }
    else
    {
        Console.WriteLine("Aqui fuimos");
        // Populate dropdown lists
        ViewBag.Sexos = _context.Sexo.ToList();  
        ViewBag.Regiones = _context.Regiones.ToList();
        ViewBag.Comunas = _context.Comunas.ToList();

        foreach (var modelStateKey in ModelState.Keys)
        {
            var modelStateVal = ModelState[modelStateKey];
            foreach (var error in modelStateVal.Errors)
            {
                Console.WriteLine($"{modelStateKey}: {error.ErrorMessage}");
            }
        }
        return View("IngresarEmpleado", modele);
    }

    return View("GestionEmpleado");
}


    }
}