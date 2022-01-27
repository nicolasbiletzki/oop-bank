using System;
using System.Collections.Generic;
using System.Text;

namespace oop_bank.Classes
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
            this.NumeroDaConta = "00" + Conta.NumeroDaContaSequencial;
        }
    }
}
