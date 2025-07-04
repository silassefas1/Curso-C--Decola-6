namespace Mini_Caixa_Eletronico;

internal class Program
{
    static void Main(string[] args)
    {
        decimal saldo = 1500.78m; //m indicia que é um decimal
        bool continuar = true;//valor booleano

        while (continuar) {
            Console.Clear();
            Console.WriteLine("Bem vindo ao Mini Ciaxa Eletrônico");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Saldo Inicial: R$ " + saldo.ToString("C"));
            Console.WriteLine("Selecione Uma Opção");
            Console.WriteLine("1 - Ver Saldo Detalhado");
            Console.WriteLine("2 - Fazer um Depósito");
            Console.WriteLine("3 - Realizar um Saque");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine(); // le a linha do console para capturar a opção do usuario
            if (opcao == "4") { 
                continuar = false;
            }
        }
        Console.WriteLine("Até mais...");
    }
}
