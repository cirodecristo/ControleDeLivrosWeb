using CadastroDeLivrosWeb.Data;
using CadastroDeLivrosWeb.Models;
using Microsoft.AspNetCore.Mvc;


namespace ControleDeLivrosWeb.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly AppDbContext _db;

        public CategoriaController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Categoria> objCategoriaLista = _db.Categorias.ToList();
            return View(objCategoriaLista);
        }
        public IActionResult Criar()
        {
            return View();
        }
    }
}
