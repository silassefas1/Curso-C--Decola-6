namespace Mini_Caixa_Eletronico_2.Data;

public class ContaRepositorio
{
   //emulação de uma conexão com o banco de dados, o _conta é o objeto de manipulação de dados
   private static readonly Conta _conta = new Conta(12345, 1000.00m);
   
   public Conta GetConta()
   {
      //retorna a conta que foi criada
      return _conta;
   }
}