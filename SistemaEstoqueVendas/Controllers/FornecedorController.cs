using System.Collections.Generic;
using System.Web.Mvc;
using SistemaEstoqueVendas.DAO;
using SistemaEstoqueVendas.Models;

namespace SistemaEstoqueVendas.Controllers
{
    public class FornecedorController : Controller
    {
        FornecedorDAO dao = new FornecedorDAO();

        //Lista todos os fornecedores cadastrados no banco de dados
        public ActionResult Index()
        {
            IList<Fornecedor> fornecedor = dao.Lista();
            return View(fornecedor);
        }

        //Executa a tela de cadastro de fornecedores
        public ActionResult Cadastrar()
        {
            ViewBag.Fornecedor = new Fornecedor(); 
            return View();
        }

        //Verifica e envia os dados de cadastro do fornecedor para o banco de dados
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                dao.Adiciona(fornecedor);
                return RedirectToAction("Index");
            }
            ViewBag.Fornecedor = fornecedor;
            return View(fornecedor);
        }
        
        //Busca fornecedor e mostra os detalhes do cadastro 
        public ActionResult Busca(int id)
        {
            Fornecedor fornecedor = dao.BuscaId(id);
            ViewBag.Fornecedor = fornecedor;
            return View(fornecedor);
        }

        //Executa a tela de edição dos dados cadastrado
        public ActionResult Editar(int id)
        {
            Fornecedor fornecedor = dao.BuscaId(id);
            ViewBag.Fornecedor = fornecedor;
            if (fornecedor == null)
            {
                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }

        //Verifica e salva os dados alterados do fornecedor no banco de dados
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                dao.Editar(fornecedor);
                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }

        //Verifica e chama a tela para a exclusão de fornecedores 
        public ActionResult Excluir(int id)
        {
            Fornecedor fornecedor = dao.BuscaId(id);
            ViewBag.Fornecedor = fornecedor;
            if(fornecedor == null)
            {
                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }

        //Executa a exclusão do fornecedor selecionado
        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(int id)
        {
            dao.Exclui(id);
            return RedirectToAction("Index", "Fornecedor");
        }
    }
}