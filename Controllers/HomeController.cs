using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using variables.Models;

namespace variables.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<ClientesModel> _listaCliente = new List<ClientesModel>(); // Lista estática

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            // Solo inicializa la lista si está vacía
            if (!_listaCliente.Any())
            {
                for (int i = 1; i <= 10; i++)
                {
                    _listaCliente.Add(new ClientesModel
                    {
                        Id = i,
                        Apellido = $"Apellido {i}",
                        Cedula_Ruc = $"180000000{i}",
                        Direccion = "Ambato",
                        Edad = 18 + i,
                        Genero = true,
                        Nombre = $"Cliente {i}",
                        Telefono = $"09876543{i}"
                    });
                }
            }
        }

        public IActionResult Index()
        {
            return View(_listaCliente);
        }

        public IActionResult Eliminar(int id)
        {
            var cliente = _listaCliente.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                _listaCliente.Remove(cliente);
            }
            return RedirectToAction("Index"); // Redirige para mostrar la lista actualizada
        }

        [HttpPost]
        public IActionResult Actualizar(ClientesModel clienteActualizado)
        {
            var cliente = _listaCliente.FirstOrDefault(c => c.Id == clienteActualizado.Id);
            if (cliente != null)
            {
                cliente.Nombre = clienteActualizado.Nombre;
                cliente.Apellido = clienteActualizado.Apellido;
                cliente.Cedula_Ruc = clienteActualizado.Cedula_Ruc;
                cliente.Edad = clienteActualizado.Edad;
                cliente.Telefono = clienteActualizado.Telefono;
            }
            return RedirectToAction("Index"); // Redirige para mostrar la lista actualizada
        }

        public IActionResult Privacy(string nombre, string apellido, int edad, int? estado)
        {
            int _estado = estado == null ? 0 : (int)estado;

            var cliente = new ClientesModel
            {
                Apellido = apellido,
                Cedula_Ruc = "1803971373011",
                Direccion = "Ambato",
                Edad = edad,
                Genero = true,
                Nombre = nombre,
                Telefono = "098765432",
                Id = 1
            };
            return View(cliente);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
