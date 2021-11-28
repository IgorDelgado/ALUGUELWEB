using Aluguel.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using Aluguel.Models.Consulta;

namespace Aluguel.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cacamba> Caçambas { get; set; }

        public DbSet<Aluga> Alugueis { get; set; }

        public DbSet<Colaborador> Colaboradores { get; set; }

        public DbSet<Aluguel.Models.Consulta.Itens> Itens { get; set; }


    }
}


