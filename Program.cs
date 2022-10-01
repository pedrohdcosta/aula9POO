Console.Clear();

Conta contaZeColmeia = new Conta("123", "Zé Colmeia", 100);
contaZeColmeia.retirar(45, DateTime.Now, "Pagamento da agua");
contaZeColmeia.retirar(5, DateTime.Now, "Coca-cola no buteco");
contaZeColmeia.retirar(300, DateTime.Now, "escola do colmeinha");
Console.WriteLine(contaZeColmeia.mostrarExtrato());
Console.WriteLine();
Console.ReadKey();

contaEspecial contaCatatau = new contaEspecial("456", "Catatau", 100, 400);
contaCatatau.retirar(45, DateTime.Now, "Pagamento da agua");
contaCatatau.retirar(5, DateTime.Now, "Coca-cola no buteco");
contaCatatau.retirar(300, DateTime.Now, "escola do colmeinha");
Console.WriteLine(contaCatatau.mostrarExtrato());
Console.WriteLine();
Console.ReadKey();


Console.WriteLine("Contas criadas : " + Conta.quantContas);
Console.ReadKey();

