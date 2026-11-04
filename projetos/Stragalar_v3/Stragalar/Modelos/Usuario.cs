namespace Stragalar.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Funcao { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
