using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Conta
    {
        // Passo 2 — atributos (armazenados pelas propriedades autoimplementadas)
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        // Passo 3 — construtor sem parâmetro
        public Conta()
        {
            NumeroConta = 0;
            Titular = "";
            Saldo = 0;
        }

        // Passo 4 — ToString
        public override string ToString()
        {
            return "Titular: " + Titular +
                   " | Nº da conta: " + NumeroConta +
                   " | Saldo: R$ " + Saldo.ToString("F2", new CultureInfo("pt-BR"));
        }

        // Depósito: soma o valor ao saldo (somente valores positivos)
        public bool Depositar(double valor)
        {
            if (valor <= 0)
            {
                return false;
            }

            Saldo += valor;
            return true;
        }

        // Saque: só realiza se houver saldo suficiente
        // Retorna true  -> "Saque realizado com sucesso"
        // Retorna false -> "Saldo insuficiente"
        public bool Sacar(double valor)
        {
            if (valor <= 0)
            {
                return false;
            }

            if (Saldo < valor)
            {
                return false;
            }

            Saldo -= valor;
            return true;
        }
    }
}

