﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ContaPessoaFisica : Conta
    {
        [Required] 
        public string NomeCliente { get; set; } = string.Empty;

        [Required]
        public string CPF { get; set; } = string.Empty;
        public string Genero { get; set; }

        [Required]
        public string Endereco { get; set; }
        public string Profissao { get; set; }

        public double RendaFamiliar { get; set; }


        //construtor da classe ContaPF
        public ContaPessoaFisica()
        {

        }
        public ContaPessoaFisica(string nomeConta, ETipoConta tipoConta)
        {
            NomeConta = nomeConta;
            this.TipoConta = tipoConta;
        }

        public override void Sacar(double value) => base.Sacar(value);


        public override void Depositar(double value) => base.Depositar(value);

        public override double VerSaldo() =>
            base.VerSaldo();


        public override sealed void SetarNome(string nome) => base.SetarNome(nome);

        public override void Transferir(Conta contaPara) =>
            base.Transferir(contaPara);
    }
}
