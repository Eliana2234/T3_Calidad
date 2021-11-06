using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T3ESOT.Models.Map
{
    public class CompartidoMap : IEntityTypeConfiguration<Compartido>
    {
        public void Configure(EntityTypeBuilder<Compartido> builder)
        {
            builder.ToTable("Compartido");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.Nota)
                .WithMany()
                .HasForeignKey(o => o.IdNota);

            builder.HasOne(o => o.User)
                .WithMany()
                .HasForeignKey(o => o.IdUser);
        }
    }
}
