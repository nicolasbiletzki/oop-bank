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
            this.NumeroDaAgencia = "0001";
            Conta.NumeroDaContaSequencial++;
            this.Movimentacoes = new List<Extrato>();
        }

        public double Saldo { get; protected set; }
        public string NumeroDaAgencia { get; private set; }
        public string NumeroDaConta { get; protected set; }

        public static int NumeroDaContaSequencial { get; private set; }

        private List<Extrato> Movimentacoes;


        public double ConsultarSaldo()
        {
            return this.Saldo;
        }

        public void Depositar(double valor)
        {
            DateTime dataAtual = DateTime.Now;
            this.Movimentacoes.Add(new Extrato(dataAtual, "Depósito ", valor));
            
            this.Saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if(valor > this.ConsultarSaldo())
            return false;

            DateTime dataAtual = DateTime.Now;
            this.Movimentacoes.Add(new Extrato(dataAtual, "Saque ", -valor));


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

        public List<Extrato> Extrato()
        {
            return this.Movimentacoes;
        }
    }
}
