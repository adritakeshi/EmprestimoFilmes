using EmprestimoFilmes.Data;
using EmprestimoFilmes.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoFilmes.Controllers
{
    public class EmprestimoController : Controller
    {
        readonly private ApplicationDBContext _db;

        public EmprestimoController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos;

            return View(emprestimos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(EmprestimosModel emprestimos)
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimos.Add(emprestimos);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if ((id == null) || (id == 0))
            {
                return NotFound();
            }

            EmprestimosModel emprestimos = _db.Emprestimos.FirstOrDefault(x => x.Id == id);

            if (emprestimos == null)
            {
                return NotFound();
            }

            return View(emprestimos);
        }

        [HttpPost]
        public IActionResult Editar(EmprestimosModel emprestimos)
        {
            if (emprestimos == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Emprestimos.Update(emprestimos);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Edição realizada com sucesso";

            }

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if ((id == null) || (id == 0))
            {
                return NotFound();
            }

            EmprestimosModel emprestimos = _db.Emprestimos.FirstOrDefault(x => x.Id == id);

            if (emprestimos == null)
            {
                return NotFound();
            }

            return View(emprestimos);
        }

        [HttpPost]
        public IActionResult Excluir(EmprestimosModel emprestimos)
        {
            if (emprestimos == null)
            {
                return NotFound();
            }

            _db.Emprestimos.Remove(emprestimos);
            _db.SaveChanges();

            TempData["MensagemErro"] = "Exclusão realizada com sucesso";

            return RedirectToAction("Index");

        }
    }
}
    
