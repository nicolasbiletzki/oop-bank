using oop_bank.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop_bank.Classes
{
    public abstract class Conta : Banco, IConta
    {
        public Conta()
        {
            this.NumeroDaConta = "0001";
            Conta.NumeroDaContaSequencial++;
        }

        public double Saldo { get; protected set; }
        public string NumeroDaAgencia { get; private set; }
        public string NumeroDaConta { get; private set; }

        public static int NumeroDaContaSequencial { get; private set; }

        public double ConsultarSaldo()
        {
            return this.Saldo;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if(valor > this.Saldo)
            return false;


            this.Saldo -= valor;
            return true;
            
        }
        public string GetCodigoDoBanco()
        {
            return this.CodigoDoBanco;
        }

        public string GetNumeroAgencia()
        {
            return this.NumeroDaAgencia;
        }

        public string GetNumeroDaConta()
        {
            return this.NumeroDaConta;
        }


    }
}
