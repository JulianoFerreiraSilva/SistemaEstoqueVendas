using System.Collections.Generic;
using System.Linq;
using SistemaEstoqueVendas.Models;

namespace SistemaEstoqueVendas.DAO
{
    public class ClienteDAO
    {
        //Instanciando a classe que faz conexão com o banco de dados
        private EstoqueVendaDataBase db = new EstoqueVendaDataBase();

        //Metodos CRUD
        #region Adiciona Cliente
        public void Adiciona(Cliente cliente)
        {         
            db.Cliente.Add(cliente);
            db.SaveChanges();
        }
        #endregion

        #region Lista de Clientes
        public IList<Cliente> Lista()
        {
            return db.Cliente.ToList();
        }
        #endregion

        #region Busca Cliente por Id
        public Cliente BuscaId(int id)
        {
            return db.Cliente.Find(id);
        }
        #endregion

        #region Edita Dados do Cliente
        public void Editar(Cliente cliente)
        {
            db.Entry(cliente).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
        #endregion

        #region Exclui Cliente
        public void Excluir(int id)
        {
            Cliente cliente = db.Cliente.Find(id);
            db.Cliente.Remove(cliente);
            db.SaveChanges();
        }
        #endregion
    }
}