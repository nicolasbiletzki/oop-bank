using System;
using System.Collections.Generic;
using System.Text;

namespace oop_bank.Contratos
{
    public interface IConta
    {
        void Depositar(double valor);
        bool Sacar(double valor);
        double ConsultarSaldo();
        string GetCodigoDoBanco();
        string GetNumeroAgencia();
        string GetNumeroDaConta();

    }
}
