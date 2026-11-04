using System;
using MySql.Data.MySqlClient;

namespace CandidatoEstagio
{
    internal class Conexao
    {
        private const string StringConexao = "Server=localhost;Port=3307;Database=db_estagio;Uid=root;Pwd=;";

        public static MySqlConnection ObterConexao()
        {
            MySqlConnection conexao = new MySqlConnection(StringConexao);
            conexao.Open();
            return conexao;
        }

        public static bool TestarConexao(out string mensagem)
        {
            try
            {
                MySqlConnection conexao = ObterConexao();
                mensagem = "Conectado! MySQL " + conexao.ServerVersion;
                conexao.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                mensagem = "Falha " + ex.Number + ": " + ex.Message;
                return false;
            }
        }
    }
}
