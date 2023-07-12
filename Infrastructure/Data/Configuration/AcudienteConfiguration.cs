using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class AcudienteConfiguration : IEntityTypeConfiguration<Acudiente>
{
    public void Configure(EntityTypeBuilder<Acudiente> builder)
    {
        builder.ToTable("acudiente");

        builder.Property(p=>p.id)
        .IsRequired();

        builder.Property(p=>p.nombreCompleto)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p=>p.telefono)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p=>p.direccion)
        .HasMaxLength(200)
        .IsRequired();
    }
}
