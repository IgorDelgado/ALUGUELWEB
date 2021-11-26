using Aluguel.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aluguel.Models.Mapeamento
{
    public class AlugaMap : IEntityTypeConfiguration<Aluga>
    {
        public void Configure(EntityTypeBuilder<Aluga> builder)
        {

            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();

            builder.ToTable("Aluga");

            throw new NotImplementedException();
        }
    }
}
