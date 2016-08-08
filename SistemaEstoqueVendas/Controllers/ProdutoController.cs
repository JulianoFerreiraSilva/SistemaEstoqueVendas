using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaEstoqueVendas.DAO;
using SistemaEstoqueVendas.Models;

namespace SistemaEstoqueVendas.Controllers
{
    public class ProdutoController : Controller
    {
        //Estancia da classe que acessa e movimenta o banco de dados 
        private ProdutoDAO dao = new ProdutoDAO();
        private FornecedorDAO forDao = new FornecedorDAO();

        // Lista de Produtos cadastrados 
        public ActionResult Index()
        {
            IList<Produto> produto = dao.Lista();
            return View(produto);
        }

        //Executa a tela de cadastro de produtos
        public ActionResult Cadastrar()
        {
            ViewBag.Fornecedores = forDao.Lista();
            return View();
        }

        //Verifica e envia o dados do produto cadastrados no banco de dados
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                dao.Adiciona(produto);
                return RedirectToAction("Index");
            }
            ViewBag.Produto = produto;
            return View("Cadastrar", "Produto");
        }
        
        //Executa a busca de produto e mostra na tela
        public ActionResult Busca(int id)
        {
            Produto produto = dao.BuscaId(id);
            ViewBag.Produto = produto;
            return View(produto);
        }

        //Executa a tela para edicao de produtos
        public ActionResult Editar(int id)
        {
            ViewBag.Fornecedores = forDao.Lista();
            Produto produto = dao.BuscaId(id);
            ViewBag.Produto = produto;
            if(produto == null)
            {
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        //Verifica e envia a edicao do produto atualizado
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                dao.Editar(produto);
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        //Executa a tela de exclusao e verifica a disposicao do produto a ser excluido
        public ActionResult Excluir(int id)
        {
            Produto produto = dao.BuscaId(id);
            ViewBag.Produto = produto;
            if(produto == null)
            {
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(int id)
        {
            dao.Excluir(id);
            return RedirectToAction("Index", "Produto");
        }
    }
}