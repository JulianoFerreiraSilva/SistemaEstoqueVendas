using System.Collections.Generic;
using System.Linq;
using SistemaEstoqueVendas.Models;

namespace SistemaEstoqueVendas.DAO
{
    public class ProdutoDAO
    {
        //Instanciando a classe que faz conexão com o banco de dados
        private EstoqueVendaDataBase db = new EstoqueVendaDataBase();

        //Metodos CRUD
        #region Adiciona Produtos
        public void Adiciona(Produto produto)
        {
            db.Produto.Add(produto);
            db.SaveChanges();
        }
        #endregion

        #region Lista Produtos
        public IList<Produto>Lista()
        {
            return db.Produto.ToList();
        }
        #endregion

        #region Busca Produto por Id
        public Produto BuscaId(int id)
        {
            return db.Produto.Find(id);
        }
        #endregion

        #region Edita Produtos
        public void Editar(Produto produto)
        {
            db.Entry(produto).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
        #endregion

        #region Excluir produtos
        public void Excluir(int id)
        {
            Produto produto = db.Produto.Find(id);
            db.Produto.Remove(produto);
            db.SaveChanges();
        }
        #endregion
    }
}