using System.Collections.Generic;
using System.Linq;
using SistemaEstoqueVendas.Models;

namespace SistemaEstoqueVendas.DAO
{
    public class FornecedorDAO
    {
        //Instanciando a classe que faz conexão com o banco de dados
        private EstoqueVendaDataBase db = new EstoqueVendaDataBase();

        //Metodos CRUD
        #region Adiciona Fornecedores
        public void Adiciona(Fornecedor fornecedor)
        {
            db.Fornecedor.Add(fornecedor);
            db.SaveChanges();
        }
        #endregion

        #region Lista de Fornecedores
        public IList<Fornecedor> Lista()
        {
            return db.Fornecedor.ToList();
        }
        #endregion

        #region Busca Fornecedor Por Id
        public Fornecedor BuscaId(int id)
        {
            return db.Fornecedor.Find(id);
        }
        #endregion

        #region Busca Por Nome
        public Fornecedor BuscaNome(string nome)
        {
            return db.Fornecedor.Find(nome);
        }
        #endregion

        #region Edita Dados do Fornecedor
        public void Editar(Fornecedor fornecedor)
        {
            db.Entry(fornecedor).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
        #endregion

        #region Exclui Fornecedor
        public void Exclui(int id)
        {
            Fornecedor fornecedor = db.Fornecedor.Find(id);
            db.Fornecedor.Remove(fornecedor);
            db.SaveChanges();
        }
        #endregion
    }
}