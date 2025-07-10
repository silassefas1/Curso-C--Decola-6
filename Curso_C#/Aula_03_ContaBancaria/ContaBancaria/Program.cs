using ContaBancaria;

Console.WriteLine("Bem vinda ao sistema de Conta Bancaria");

List<Conta> todasAsContas = new List<Conta>();

todasAsContas.Add(new ContaCorrente("001","Silas Sefas", 7000.00m,20000.00m));
todasAsContas.Add(new ContaPoupanca("002", "Maria Silva", 50000.00m,5.0m));

double valorSaque = 15000;

foreach (Conta conta in todasAsContas)
{
    Console.WriteLine($"==================={conta.GetType().Name}====================");
    conta.ExibirSaldo();
    conta.Sacar((decimal)valorSaque);
    conta.ExibirSaldo();

}

//Criar os objetos
ContaCorrente contaCorrente = new ContaCorrente("CC-001", "João Silva", 1000m, 500);
ContaPoupanca contaPoupanca = new ContaPoupanca("CP-002", "Maria Oliveira", 2000m, 5.0m);

var seguro = new SeguroDeVida();

//lista do tipo interface
List<ITributavel> listaDeTributaveis = new List<ITributavel>();

listaDeTributaveis.Add(contaCorrente);
listaDeTributaveis.Add(seguro);
//listaDeTributaveis.Add(contaPoupanca);

Console.WriteLine("+------------------------------------------+");
Console.WriteLine("Calculando impostos de todos os tributáveis:");
double totalImpostos = 0;
foreach (var item in listaDeTributaveis)
{
    double tributodoItem = item.CalcularImposto();
    totalImpostos += tributodoItem;
    Console.WriteLine($"Tributo apra o item {item.GetType().Name} : {tributodoItem}");
}
Console.WriteLine($"Total de impostos: {totalImpostos}");




