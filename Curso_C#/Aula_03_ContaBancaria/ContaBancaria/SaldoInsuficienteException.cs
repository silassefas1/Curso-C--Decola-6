namespace ContaBancaria;

public class SaldoInsuficienteException : Exception
{
   public SaldoInsuficienteException(string message) : base(message){}
}