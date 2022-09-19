namespace ConsoleApp2.Entidades
{
    internal class ContaPJ : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaPJ()
        {

        }

        public ContaPJ(string numero, string agencia, string titular, 
            double saldo, double limiteEmprestimo): base(numero, agencia, titular, saldo)
        {
            //Numero = numero;
            //Agencia = agencia;
            //Titular = Titular;
            //Saldo = saldo;
            LimiteEmprestimo = limiteEmprestimo;
        }

        public override sealed void Sacar(double valor)
        {
            base.Sacar(valor);
            Saldo -= 10;
        }

        public void SolicitarEmprestimo(double valor)
        {
            if (valor > 0)
            {
                if (valor <= LimiteEmprestimo)
                {
                    Saldo += valor;
                }
                else
                {
                    Console.WriteLine("Valor acima do limite permitido!");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }
    }
}
