using System.Collections.Generic;
using System.Linq;
using SistemaEstoqueVendas.Models;

namespace SistemaEstoqueVendas.DAO
{
    public class UsuarioDAO
    {
        //Instanciando a classe que faz conexão com o banco de dados
        private EstoqueVendaDataBase db = new EstoqueVendaDataBase();

        //Metodos CRUD
        #region Adiciona Usuarios
        public void Adiciona(Usuario usuario)
        {
            db.Usuario.Add(usuario);
            db.SaveChanges();
        }
        #endregion

        #region Lista Usuarios
        public IList<Usuario> Lista()
        {
            return db.Usuario.ToList();
        }
        #endregion

        #region Busca Usuarios por Id
        public Usuario BuscaId(int id)
        {
            return db.Usuario.Find(id);
        }
        #endregion

        #region Edita Usuarios
        public void Editar(Usuario usuario)
        {
            db.Entry(usuario).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
        #endregion

        #region Exclui Usuarios
        public void Excluir(int id)
        {
            Usuario usuario = db.Usuario.Find(id);
            db.Usuario.Remove(usuario);
            db.SaveChanges();
        }
        #endregion
    }
}