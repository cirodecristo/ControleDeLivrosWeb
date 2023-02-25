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
        //GET
        public IActionResult Criar()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Categoria obj)
        {
            if (obj.Nome == obj.OrdemMostra.ToString())
            {
                ModelState.AddModelError("Nome", "O nome da ordem de exibição não pode ser igual ao nome da categoria!");
            }
            if (ModelState.IsValid)
            {
                _db.Categorias.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //GET
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoriaDb = _db.Categorias.Find(id);
            //var categoriaDbPrimeira = _db.Categorias.FirstOrDefault(c => c.Id == id);
            if (categoriaDb == null)
            {
                return NotFound();
            }

            return View(categoriaDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Categoria obj)
        {
            if (obj.Nome == obj.OrdemMostra.ToString())
            {
                ModelState.AddModelError("Nome", "O nome da ordem de exibição não pode ser igual ao nome da categoria!");
            }
            if (ModelState.IsValid)
            {
                _db.Categorias.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //GET
        public IActionResult Deletar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoriaDb = _db.Categorias.Find(id);
            //var categoriaDbPrimeira = _db.Categorias.FirstOrDefault(c => c.Id == id);
            if (categoriaDb == null)
            {
                return NotFound();
            }

            return View(categoriaDb);
        }

        //POST
        [HttpPost, ActionName("Deletar")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletarPost(int? id)
        {
            var obj = _db.Categorias.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            {
                _db.Categorias.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
