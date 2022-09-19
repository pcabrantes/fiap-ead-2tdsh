namespace ConsoleApp2.Entidades
{
    internal class Conta
    {
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public Conta()
        {

        }

        public Conta(string numero, string agencia, string titular, double saldo)
        {
            Numero = numero;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Sacar(double valor)
        {
            if (valor > 0)
            {
                if (valor <= Saldo)
                {
                    Saldo -= valor;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente!");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }

        public override string ToString()
        {
            return $"{Agencia} | ${Numero} | ${Titular} | ${Saldo}";
        }
    }
}
