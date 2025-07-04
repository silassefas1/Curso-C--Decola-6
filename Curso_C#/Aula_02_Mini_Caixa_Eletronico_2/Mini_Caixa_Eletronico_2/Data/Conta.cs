namespace Mini_Caixa_Eletronico_2.Data;

public class Conta
{
    public int NumeroConta { get; set; }
    public decimal Saldo { get; set; }
    
    //Construtor
    public Conta(int numeroConta, decimal saldo)
    {
        NumeroConta = numeroConta;
        Saldo = saldo;
    }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
        }
    }

    public bool Sacar(decimal valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor; //Saldo = Saldo - valor;
            return true;
        }
        else
        {
            Console.WriteLine("Valor inválido para saque.");
            return false;
        }
    }
}