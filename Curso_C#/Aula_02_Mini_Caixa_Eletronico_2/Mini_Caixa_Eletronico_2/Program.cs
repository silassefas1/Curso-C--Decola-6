using Mini_Caixa_Eletronico_2.Businness;

bool continuar = true;
var contaService = new ContaService();


while (continuar) {
    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Bem vindo ao Mini Ciaxa Eletrônico");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Saldo Inicial: R$ " + contaService.VerSaldo().ToString("F2"));
    Console.WriteLine("Selecione Uma Opção");
    Console.WriteLine("1 - Ver Saldo Detalhado");
    Console.WriteLine("2 - Fazer um Depósito");
    Console.WriteLine("3 - Realizar um Saque");
    Console.WriteLine("4 - Sair");
    Console.Write("Opção: ");
    string? opcao = Console.ReadLine(); // le a linha do console para capturar a opção do usuario
    Console.Clear();
    if (opcao == "4")
    {
        continuar = false;
    }
    
}
Console.WriteLine("Até mais...");
