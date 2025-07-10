namespace ContaBancaria;

public class Conta
{
    protected double _saldo;
    public String Numero { get; set; }

    public String Titular { get; set; }

    public decimal Saldo { get; set; }

    public Conta(string numero, string titular)
    {
        Numero = numero;
        Titular = titular;
    }
    public Conta(string numero, string titular, decimal saldo)
    {

        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito de {valor:C} realizado com sucesso.");
    }

    //o virtual permite que este método seja sobrescrito em classes filhas. igual ao @override
    public virtual void Sacar(decimal valor)
    {
        if(valor <= 0)
        {
            throw new ArgumentException("Valopr deve ser positivo");
        }
        if (valor > Saldo)
        {
            throw new SaldoInsuficienteException("Saldo insuficiente para realizar o saque.");
        }
        Saldo -= valor;

    }


    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: {Saldo:C}");
    }
}