using Aula_02_Mini_Caixa_Eletronico_Multiplos.Models;

namespace Aula_02_Mini_Caixa_Eletronico_Multiplos.Data;

public class ContaRepositorio
{
    // Simula um repositório de contas, armazenando-as em memória(DB).
    private readonly List<Conta> _contas = new List<Conta>();

    public ContaRepositorio()
    {
        if (!_contas.Any())
        {
            _contas.Add(new Conta(101,"Maiara", 5000.00m));
            _contas.Add(new Conta(201,"Patricia", 3800.65m));
            _contas.Add(new Conta(301,"Manoel", 7987.23m));
        }


    }
    
    public Conta BuscarContaPorNumero(int numeroConta)
    {
        return _contas.FirstOrDefault(c => c.NumeroConta == numeroConta);
    }
}