using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
        builder.ToTable("medico");

        builder.Property(p=>p.nroMatriculaProfesional)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p=>p.nombreCompleto)
        .HasMaxLength(120)
        .IsRequired();

        builder.HasOne(p=>p.consultorioMedico)
        .WithMany(p => p.Medicos)
        .HasForeignKey(p => p.consultorio)
        .IsRequired();

        builder.HasOne(p=>p.especialidadMedico)
        .WithMany(p => p.Medicos)
        .HasForeignKey(p => p.especialidad)
        .IsRequired();
    }
}