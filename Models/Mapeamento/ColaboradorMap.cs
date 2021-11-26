using Aluguel.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aluguel.Models.Mapeamento
{
    public class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Colaborador> builder)
        {

            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasMaxLength(35).IsRequired();
            builder.Property(p => p.Funcao).HasMaxLength(35).IsRequired();


            builder.HasMany(p => p.Alugueis).WithOne(p => p.NomeColaborador).HasForeignKey(p => p.ColaboradorID).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Colaborador");



            throw new NotImplementedException();
        }
    }
}
