using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Conta
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {
            this.NumeroConta = 0;
            this.Saldo = 0;
            this.Titular = "";
        }
        public override string ToString()
        {
            return Titular+ " "+NumeroConta+ " "+Saldo;
        }

    }
}
