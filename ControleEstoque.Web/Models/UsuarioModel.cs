using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ControleEstoque.Web.Models
{
    public class UsuarioModel
    {
      
        public static bool ValidarUsuario(String login, String senha)
        {
            var ret = false;
            using (var conexao = new SqlConnection())
            {
                conexao.ConnectionString = "Data Source=localhost; Initial Catalog=controle-estoque;User Id=admin,Password=123";
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = string.Format(
                        "SELECT COUNT(*) FROM usuario where login='{0}' and senha='{1}'",login,senha);
                   ret = ((int)comando.ExecuteScalar() > 0);
                }
            }
            return ret;
        }

        private static IDisposable SqlCommand()
        {
            throw new NotImplementedException();
        }
    }
}