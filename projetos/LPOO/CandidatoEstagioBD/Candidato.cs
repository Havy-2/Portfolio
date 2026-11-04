using System;

namespace CandidatoEstagio
{
    public class Candidato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public string AreaAtuacao { get; set; }
        public bool Matutino { get; set; }
        public bool Vespertino { get; set; }
        public bool Noturno { get; set; }
        public string Escolaridade { get; set; }

        public DateTime DataNascimento
        {
            get
            {
                return new DateTime(this.Ano, this.Mes, this.Dia);
            }
        }

        public Candidato()
        {
            this.Id = 0;
            this.Nome = "";
            this.Dia = 0;
            this.Mes = 0;
            this.Ano = 0;
            this.AreaAtuacao = "";
            this.Matutino = false;
            this.Vespertino = false;
            this.Noturno = false;
            this.Escolaridade = "";
        }

        public int CalcularIdade()
        {
            if (this.Dia <= 0 || this.Mes <= 0 || this.Ano <= 0)
            {
                return 0;
            }

            DateTime nascimento;
            try
            {
                nascimento = this.DataNascimento;
            }
            catch
            {
                return 0;
            }

            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - nascimento.Year;

            if (hoje.Month < nascimento.Month ||
                (hoje.Month == nascimento.Month && hoje.Day < nascimento.Day))
            {
                idade--;
            }

            if (idade < 0)
            {
                return 0;
            }
            return idade;
        }

        public override string ToString()
        {
            string turnos = "";
            if (this.Matutino)
            {
                turnos = turnos + "Matutino ";
            }
            if (this.Vespertino)
            {
                turnos = turnos + "Vespertino ";
            }
            if (this.Noturno)
            {
                turnos = turnos + "Noturno ";
            }
            if (turnos == "")
            {
                turnos = "Não informado";
            }

            return "Nome: " + this.Nome +
                   "\nData de nascimento: " + this.Dia + "/" + this.Mes + "/" + this.Ano +
                   "\nIdade: " + this.CalcularIdade() + " anos" +
                   "\nÁrea de atuação: " + this.AreaAtuacao +
                   "\nDisponibilidade: " + turnos.Trim() +
                   "\nEscolaridade: " + this.Escolaridade;
        }
    }
}
