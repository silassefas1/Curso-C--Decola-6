namespace Aula_02_Mini_Caixa_Eletronico_MVC.Models;

public class Conta
{
    public decimal Saldo { get; set; }

    public Conta(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
        
    }
    
    public bool Sacar(decimal valor)
    {
        Saldo -= valor;
        return true;
        
    }
}