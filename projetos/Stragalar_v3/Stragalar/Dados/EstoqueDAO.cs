using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Stragalar.Dados
{
    public class EstoqueDAO
    {
        public bool RegistrarMovimentacao(int idProduto, int idUsuario, string tipo, decimal quantidade, string motivo)
        {
            using (var con = Conexao.ObterConexao())
            using (var tx = con.BeginTransaction())
            {
                try
                {
                    const string sqlMov = @"INSERT INTO movimentacaoEstoque 
                        (idUsuario, idProduto, tipo, quantidade, motivo) 
                        VALUES (@usuario, @produto, @tipo, @qtd, @motivo)";

                    using (var cmd = new MySqlCommand(sqlMov, con, tx))
                    {
                        cmd.Parameters.AddWithValue("@usuario", idUsuario);
                        cmd.Parameters.AddWithValue("@produto", idProduto);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@qtd", quantidade);
                        cmd.Parameters.AddWithValue("@motivo", motivo ?? "");
                        cmd.ExecuteNonQuery();
                    }

                    string sinal = tipo == "Entrada" ? "+" : "-";
                    string sqlEst = $"UPDATE produto SET quantidadeEstoque = quantidadeEstoque {sinal} @qtd WHERE idProduto = @produto";

                    using (var cmd = new MySqlCommand(sqlEst, con, tx))
                    {
                        cmd.Parameters.AddWithValue("@qtd", quantidade);
                        cmd.Parameters.AddWithValue("@produto", idProduto);
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return true;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public DataTable ListarProdutos()
        {
            const string sql = "SELECT idProduto, nomeProduto, quantidadeEstoque FROM produto WHERE ativo = TRUE ORDER BY nomeProduto";
            using (var con = Conexao.ObterConexao())
            using (var da = new MySqlDataAdapter(sql, con))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ListarMovimentacoes()
        {
            const string sql = @"SELECT m.idMovimentacaoEstoque AS Código, p.nomeProduto AS Produto, 
                m.tipo AS Tipo, m.quantidade AS Quantidade, m.motivo AS Motivo, m.dataMovimentacao AS Data
                FROM movimentacaoEstoque m
                INNER JOIN produto p ON m.idProduto = p.idProduto
                ORDER BY m.dataMovimentacao DESC";

            using (var con = Conexao.ObterConexao())
            using (var da = new MySqlDataAdapter(sql, con))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
