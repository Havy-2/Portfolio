using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Stragalar.Dados
{
    public class UsuarioDAO
    {
        public bool Validar(string login, string senha, out string nome, out string funcao)
        {
            nome = "";
            funcao = "";
            const string sql = "SELECT nomeUsuario, funcao FROM usuario WHERE login=@login AND senha=@senha AND ativo=TRUE LIMIT 1";

            using (var con = Conexao.ObterConexao())
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        nome = r["nomeUsuario"].ToString();
                        funcao = r["funcao"].ToString();
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
