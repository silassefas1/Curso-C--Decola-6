namespace ContaBancaria;

public class ContaCorrente : Conta, ITributavel 
{
    public decimal LimiteChequeEspecial { get; private set; }
    
    
    // Esta classe não tem atributos ou métodos extras por enquanto.
    // Ela simplesmente reutiliza tudo da classe-mãe.

    // O construtor apenas repassa os dados para o construtor da classe-mãe.
    public ContaCorrente(string numero, string titular, decimal saldo, decimal limiteChequeEspecial)
        : base(numero, titular, saldo)
    {
        LimiteChequeEspecial = limiteChequeEspecial;    
    }

    public override void Sacar(decimal valor) {
        
        Console.WriteLine($"Tentativa de saque valor: {valor:C} na conta {this.GetType().Name} de {this.Titular}");
        if (valor <= Saldo + (decimal)LimiteChequeEspecial)
        {
            Saldo -= (decimal)valor;
            LimiteChequeEspecial -= Math.Abs(Saldo < 0 ? Saldo : 0);
            Saldo = Saldo < 0 ? 0 : Saldo;
            Console.WriteLine("+---------------------------------------------------+");
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso, usando limite do cheque especial.");
            Console.WriteLine($"Limite do cheque especial restante: {LimiteChequeEspecial:C}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque, incluindo o limite do cheque especial.");
        }
    }

    public double CalcularImposto()
    {
        return (double)Saldo * 0.02; // Exemplo de cálculo de imposto: 2% do saldo
    }
}