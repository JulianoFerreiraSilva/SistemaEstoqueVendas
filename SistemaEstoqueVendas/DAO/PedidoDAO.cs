using System.Collections.Generic;
using System.Linq;
using SistemaEstoqueVendas.Models;

namespace SistemaEstoqueVendas.DAO
{
    public class PedidoDAO
    {
        //Instanciando a classe que faz conexão com o banco de dados
        private EstoqueVendaDataBase db = new EstoqueVendaDataBase();
        
        //Metodos CRUD
        #region Adiciona Pedidos
        public void Adiciona(Pedido pedido)
        {
            db.Pedido.Add(pedido);
            db.SaveChanges();
        }
        #endregion

        #region Lista de Pedidos
        public IList<Pedido>Lista()
        {
            return db.Pedido.ToList();
        }
        #endregion

        #region Busca Pedido por Id
        public Pedido BuscaId(int id)
        {
            return db.Pedido.Find(id);
        }
        #endregion

        #region Edita Dados do Pedidos
        public void Editar(Pedido pedido)
        {
            db.Entry(pedido).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
        #endregion

        #region Exclui pedidos
        public void Excluir(int id)
        {
            Pedido pedido = db.Pedido.Find(id);
            db.Pedido.Remove(pedido);
            db.SaveChanges();
        }
        #endregion
    }
}