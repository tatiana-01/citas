
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class TipoDocConfiguration : IEntityTypeConfiguration<TipoDoc>
{
    public void Configure(EntityTypeBuilder<TipoDoc> builder)
    {
        builder.ToTable("tipo_documento");

        builder.Property(p=>p.id)
        .IsRequired();

        builder.Property(p=>p.nombre)
        .HasMaxLength(20)
        .IsRequired();

        builder.Property(p=>p.abreviatura)
        .HasMaxLength(20)
        .IsRequired();
    }
}
