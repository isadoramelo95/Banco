namespace Domain
{
    public class Conta
    {
        private string _nomeConta;
        private double _valor;
        private EtipoConta _tipoConta;
        public double ValorConta { get; set; }
        public string NomeDaConta { get; set; }
        public EtipoConta TipoConta { get; set; }

        public Conta()
        {
        }
        public Conta(double valorConta)
        {

        }

        public Conta(string nomeConta)
        {

        }

        public string Sacar(double valor)
        {

            return "saque efetuado com sucesso!";
        }

        public string Depositar(double valor)
        {

            return "Depósito efetuado com sucesso!";
        }

        public string VerSaldoConta(double valor)
        {

            return "Seu saldo é:";
        }
        public static List<Conta> VerExtrato()
        {
            return new List<Conta>();
        }

    }
}  