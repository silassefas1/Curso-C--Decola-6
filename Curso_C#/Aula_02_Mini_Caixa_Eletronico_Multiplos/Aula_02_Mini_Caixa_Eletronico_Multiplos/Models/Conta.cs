namespace Aula_02_Mini_Caixa_Eletronico_Multiplos.Models;

public class Conta
{
    public decimal Saldo { get; private set; }
    public int NumeroConta { get; private set; }
    public string NomeTitular { get; private set; }
    
    
    public Conta(int numeroConta, string nomeTitular,decimal saldoInicial)
    {
        Saldo = saldoInicial;
        NumeroConta = numeroConta;
        NomeTitular = nomeTitular;
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
        if (valor > 0 && Saldo >= valor)
        {
            Saldo -= valor;
            return true;
        }
        return false;
    }
}