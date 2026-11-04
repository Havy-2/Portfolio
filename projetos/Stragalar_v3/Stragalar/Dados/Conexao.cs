using MySql.Data.MySqlClient;

namespace Stragalar.Dados
{
    /// <summary>Fábrica de conexões com o MySQL do sistema STRAGALAR.</summary>
    public static class Conexao
    {
        private const string StringConexao =
            "Server=localhost;Port=3306;Database=db_stragalar;Uid=root;Pwd=;";

        public static MySqlConnection ObterConexao()
        {
            var conexao = new MySqlConnection(StringConexao);
            conexao.Open();
            return conexao;
        }

        public static bool TestarConexao(out string mensagem)
        {
            try
            {
                using (var conexao = ObterConexao())
                {
                    mensagem = $"Conectado! MySQL {conexao.ServerVersion}";
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                mensagem = $"Falha {ex.Number}: {ex.Message}";
                return false;
            }
        }
    }
}
