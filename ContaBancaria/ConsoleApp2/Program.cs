using ConsoleApp2.Entidades;

Conta conta = new Conta("012345", "010101", "Joao da Silva", 100);

conta.Sacar(0);
conta.Sacar(200);
conta.Sacar(50);

// conta.Saldo = -754375353;

Console.WriteLine(conta);

ContaPJ contaPJ = new ContaPJ("000214", "101010", "FIAP", 20000, 100000);

contaPJ.Sacar(1000);

Console.WriteLine(contaPJ);

contaPJ.Depositar(-100);
contaPJ.Depositar(10000);

Console.WriteLine(contaPJ);

contaPJ.SolicitarEmprestimo(10000000);
contaPJ.SolicitarEmprestimo(100000);