using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class CitaConfiguration : IEntityTypeConfiguration<Cita>
{
    public void Configure(EntityTypeBuilder<Cita> builder)
    {
        builder.ToTable("cita");

        builder.Property(p=>p.id)
        .IsRequired();

        builder.Property(p=>p.fecha)
        .HasColumnType("date")
        .IsRequired();

        builder.HasOne(p=>p.medicoCita)
        .WithMany(p=>p.Citas)
        .HasForeignKey(p=>p.medico)
        .IsRequired();

        builder.HasOne(p=>p.usuarioCita)
        .WithMany(p=>p.Citas)
        .HasForeignKey(p=>p.datosUsuario)
        .IsRequired();

        builder.HasOne(p=>p.EstadoCita)
        .WithMany(p=>p.Citas)
        .HasForeignKey(p=>p.estadoCita)
        .IsRequired();

    }
}