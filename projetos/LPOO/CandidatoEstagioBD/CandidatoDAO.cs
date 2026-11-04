using System;
using MySql.Data.MySqlClient;

namespace CandidatoEstagio
{
    internal class CandidatoDAO
    {
        public int Inserir(Candidato candidato)
        {
            const string sql = "INSERT INTO candidato (Nome, data_nascimento, area_atuacao, Matutino, Vespertino, Noturno, Escolaridade) VALUES (@nome, @dataNascimento, @areaAtuacao, @matutino, @vespertino, @noturno, @escolaridade)";

            using (MySqlConnection conexao = Conexao.ObterConexao())
            {
                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", candidato.Nome);
                    comando.Parameters.AddWithValue("@dataNascimento", candidato.DataNascimento);
                    comando.Parameters.AddWithValue("@areaAtuacao", candidato.AreaAtuacao);
                    comando.Parameters.AddWithValue("@matutino", candidato.Matutino);
                    comando.Parameters.AddWithValue("@vespertino", candidato.Vespertino);
                    comando.Parameters.AddWithValue("@noturno", candidato.Noturno);
                    comando.Parameters.AddWithValue("@escolaridade", candidato.Escolaridade);

                    int linhasAfetadas = comando.ExecuteNonQuery();
                    if (linhasAfetadas == 0)
                    {
                        throw new Exception("Nenhuma linha foi gravada na tabela candidato.");
                    }

                    candidato.Id = (int)comando.LastInsertedId;
                    return candidato.Id;
                }
            }
        }
    }
}
