using System;
using System.Collections.Generic;
using System.Text;

namespace oop_bank.Classes
{
    public abstract class Banco
    {
        public Banco()
        {
            this.NomeDoBanco = "Digital Bank";
            this.CodigoDoBanco = "012";
        }

        public string NomeDoBanco { get; private set; }
        public string CodigoDoBanco { get; private set; }
    }
}
