﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T3ESOT.Models.Map
{
    public class EtiquetaNotaMap : IEntityTypeConfiguration<EtiquetaNota>
    {
        public void Configure(EntityTypeBuilder<EtiquetaNota> builder)
        {
            builder.ToTable("EtiquetaNota");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.Etiqueta).
                WithMany().
                HasForeignKey(o => o.IdEtiqueta);

            builder.HasOne(o => o.Nota).
                WithMany().
                HasForeignKey(o => o.IdNota);
        }
    }
}
