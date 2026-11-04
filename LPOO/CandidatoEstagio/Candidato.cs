using System;

namespace CandidatoEstagio
{
    public class Candidato
    {
        // Passo 3 — propriedades autoimplementadas (get e set)
        public string Nome { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public string AreaAtuacao { get; set; }
        public bool Matutino { get; set; }
        public bool Vespertino { get; set; }
        public bool Noturno { get; set; }
        public string Escolaridade { get; set; }

        // Passo 4 — construtor sem parâmetro
        public Candidato()
        {
            Nome = "";
            Dia = 0;
            Mes = 0;
            Ano = 0;
            AreaAtuacao = "";
            Matutino = false;
            Vespertino = false;
            Noturno = false;
            Escolaridade = "";
        }

        // Idade calculada em tempo de execução (não é atributo persistido)
        public int CalcularIdade()
        {
            if (Dia <= 0 || Mes <= 0 || Ano <= 0)
            {
                return 0;
            }

            DateTime nascimento;
            try
            {
                nascimento = new DateTime(Ano, Mes, Dia);
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

            return idade < 0 ? 0 : idade;
        }

        // Passo 5 — ToString
        public override string ToString()
        {
            string turnos = "";
            if (Matutino) turnos += "Matutino ";
            if (Vespertino) turnos += "Vespertino ";
            if (Noturno) turnos += "Noturno ";
            if (string.IsNullOrWhiteSpace(turnos)) turnos = "Não informado";

            return "Nome: " + Nome +
                   "\nData de nascimento: " + Dia.ToString("00") + "/" + Mes.ToString("00") + "/" + Ano +
                   "\nIdade: " + CalcularIdade() + " anos" +
                   "\nÁrea de atuação: " + AreaAtuacao +
                   "\nDisponibilidade: " + turnos.Trim() +
                   "\nEscolaridade: " + Escolaridade;
        }
    }
}
