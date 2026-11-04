namespace Stragalar.Modelos
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal Preco { get; set; }
        public decimal QuantidadeEstoque { get; set; }
        public bool Ativo { get; set; } = true;

        public Produto()
        {
            Nome = "";
            Categoria = "";
            UnidadeMedida = "Unidade";
        }
    }
}
