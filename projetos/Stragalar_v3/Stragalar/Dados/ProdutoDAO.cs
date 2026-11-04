using System;
using System.Data;
using MySql.Data.MySqlClient;
using Stragalar.Modelos;

namespace Stragalar.Dados
{
    public class ProdutoDAO
    {
        public int Inserir(Produto p)
        {
            const string sql = @"INSERT INTO produto 
                (nomeProduto, categoria, unidadeMedida, preco, quantidadeEstoque) 
                VALUES (@nome, @cat, @un, @preco, @qtd)";

            using (var con = Conexao.ObterConexao())
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nome", p.Nome);
                cmd.Parameters.AddWithValue("@cat", p.Categoria);
                cmd.Parameters.AddWithValue("@un", p.UnidadeMedida);
                cmd.Parameters.AddWithValue("@preco", p.Preco);
                cmd.Parameters.AddWithValue("@qtd", p.QuantidadeEstoque);
                cmd.ExecuteNonQuery();
                return (int)cmd.LastInsertedId;
            }
        }

        public DataTable Listar()
        {
            const string sql = @"SELECT idProduto AS Código, nomeProduto AS Produto, 
                categoria AS Categoria, quantidadeEstoque AS Estoque, preco AS Preço 
                FROM produto WHERE ativo = TRUE ORDER BY nomeProduto";

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
