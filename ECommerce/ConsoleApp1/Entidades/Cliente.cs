namespace ConsoleApp1.Entidades
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Nome} | {Email} | {Cpf}";
        }
    }
}
