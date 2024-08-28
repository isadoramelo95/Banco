using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IConta
    {
        //properties
        string Agencia { get; set; }
        string NumeroConta { get; set; }
        string Digito { get; set; }
        string? Pix { get; set; }
        double ValorConta { get; set; }
        ETipoConta TipoConta { get; set; }
        string NomeConta { get; set; }

        //métodos
        void Sacar(double valor);
        void Depositar(double valor);
        double VerSaldo();
        void SetarNome(string nome);
    }
}
