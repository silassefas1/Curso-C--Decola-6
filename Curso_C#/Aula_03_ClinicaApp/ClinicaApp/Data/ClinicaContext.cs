using ClinicaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaApp.Data;

//minha classe de conexão com o banco de dados
public class ClinicaContext : DbContext
{
    public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options)
    {
    }
    
    //todas as tabelas do banco de dados
    public DbSet<Cliente> Clientes { get; set; }

    public DbSet<Agendamento> Agendamentos { get; set; }
}