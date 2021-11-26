using Aluguel.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aluguel.Models.Mapeamento
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasMaxLength(35).IsRequired();
            builder.Property(p => p.Endereco).HasMaxLength(25).IsRequired();
            builder.Property(p => p.Municipio).HasMaxLength(25).IsRequired();
            builder.Property(p => p.Idade).HasColumnType("Int").IsRequired();
            builder.Property(p => p.Email).HasMaxLength(35).IsRequired();
            builder.Property(p => p.CPF).HasMaxLength(14).IsRequired();
            builder.HasIndex(p => p.CPF).IsUnique();

            builder.HasMany(p => p.Alugueis).WithOne(p => p.NomeCliente).HasForeignKey(p => p.ClienteID).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Cliente");




            throw new NotImplementedException();
        }
    }
}
