using Aluguel.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aluguel.Models.Mapeamento
{
    public class CacambaMap : IEntityTypeConfiguration<Cacamba>
    {
        public void Configure(EntityTypeBuilder<Cacamba> builder)
        {


            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();

            builder.ToTable("Cacamba");


            throw new NotImplementedException();
        }
    }
}
