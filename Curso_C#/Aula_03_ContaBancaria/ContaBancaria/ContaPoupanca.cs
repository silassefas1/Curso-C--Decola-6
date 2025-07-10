namespace ContaBancaria;

public class ContaPoupanca: Conta
{
    public decimal TaxaJuros { get; set; }
    
    private const double TAXA_SAQUE = 2.78; // Taxa de juros padrão de 2.78%

    public ContaPoupanca(string numero, string titular, decimal saldo, decimal taxaJuros)
        : base(numero, titular, saldo)
    {
        TaxaJuros = taxaJuros;
    }
    
    public void AdicionarJuros()
    {
        decimal juros = (decimal)Saldo * (decimal)TaxaJuros / 100;
        Saldo += juros;
        Console.WriteLine($"Juros de {TaxaJuros}% adicionados. Novo saldo: {Saldo:C}");

    }

    public override void Sacar(decimal valor)
    {
        Console.WriteLine($"Tentativa de saque valor: {valor:C} na conta {this.GetType().Name} de {this.Titular}");

        if (valor <= 0) { 
            Console.WriteLine("Valor de saque inválido. O valor deve ser maior que zero.");
            return;
        }

        //nova regra de saque
        if (valor + (decimal)TAXA_SAQUE <= Saldo)
        {
            Saldo -= (valor + (decimal)TAXA_SAQUE);
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Novo saldo: {Saldo:C}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque, incluindo a taxa de saque.");
        }

    }

}
