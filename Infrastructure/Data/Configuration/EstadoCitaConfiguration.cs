using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class EstadoCitaConfiguration : IEntityTypeConfiguration<EstadoCita>
{
    public void Configure(EntityTypeBuilder<EstadoCita> builder)
    {
        builder.ToTable("estado_cita");

        builder.Property(p=>p.id)
        .IsRequired();

        builder.Property(p=>p.nombre)
        .HasMaxLength(20)
        .IsRequired();

    }
}