using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Stragalar.Dados
{
    public class VendaDAO
    {
        public int AbrirVenda(int idUsuario)
        {
            const string sql = "INSERT INTO venda (idUsuario, status) VALUES (@usuario, FALSE)";
            using (var con = Conexao.ObterConexao())
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@usuario", idUsuario);
                cmd.ExecuteNonQuery();
                return (int)cmd.LastInsertedId;
            }
        }

        public bool AdicionarItem(int idVenda, int idProduto, decimal quantidade, decimal precoUnitario)
        {
            decimal subtotal = quantidade * precoUnitario;
            const string sql = @"INSERT INTO itemVenda (idVenda, idProduto, quantidade, precoUnitario, subtotal) 
                VALUES (@venda, @produto, @qtd, @preco, @sub)";

            using (var con = Conexao.ObterConexao())
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@venda", idVenda);
                cmd.Parameters.AddWithValue("@produto", idProduto);
                cmd.Parameters.AddWithValue("@qtd", quantidade);
                cmd.Parameters.AddWithValue("@preco", precoUnitario);
                cmd.Parameters.AddWithValue("@sub", subtotal);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool FinalizarVenda(int idVenda, string formaPagamento, decimal valorTotal)
        {
            const string sql = @"UPDATE venda SET status = TRUE, formaPagamento = @forma, valorTotal = @total 
                WHERE idVenda = @id";

            using (var con = Conexao.ObterConexao())
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@forma", formaPagamento);
                cmd.Parameters.AddWithValue("@total", valorTotal);
                cmd.Parameters.AddWithValue("@id", idVenda);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable ListarProdutos()
        {
            const string sql = "SELECT idProduto, nomeProduto, preco, quantidadeEstoque FROM produto WHERE ativo = TRUE ORDER BY nomeProduto";
            using (var con = Conexao.ObterConexao())
            using (var da = new MySqlDataAdapter(sql, con))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ListarItensDaVenda(int idVenda)
        {
            const string sql = @"SELECT i.idItemVenda AS Código, p.nomeProduto AS Produto, 
                i.quantidade AS Qtd, i.precoUnitario AS Preço, i.subtotal AS Subtotal
                FROM itemVenda i
                INNER JOIN produto p ON i.idProduto = p.idProduto
                WHERE i.idVenda = @id";

            using (var con = Conexao.ObterConexao())
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idVenda);
                using (var da = new MySqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable ListarVendasDoDia()
        {
            const string sql = @"SELECT idVenda AS Código, dataVenda AS Data, valorTotal AS Total, 
                formaPagamento AS Pagamento
                FROM venda WHERE DATE(dataVenda) = CURDATE() AND status = TRUE
                ORDER BY dataVenda DESC";

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
