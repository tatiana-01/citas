using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("usuario");

        builder.Property(p=>p.id)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p=>p.nombre)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p=>p.segdo_nombre)
        .HasMaxLength(45)
        .IsRequired();

        builder.Property(p=>p.primer_apellido)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p=>p.segundo_apellido)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p=>p.telefono)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p=>p.direccion)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p=>p.email)
        .HasMaxLength(100)
        .IsRequired();

        builder.HasOne(p=>p.Acudiente)
        .WithMany(p=>p.Usuarios)
        .HasForeignKey(p=>p.acudiente)
        .IsRequired();

        builder.HasOne(p=>p.Genero)
        .WithMany(p=>p.Usuarios)
        .HasForeignKey(p=>p.genero)
        .IsRequired();

        builder.HasOne(p=>p.TipoDoc)
        .WithMany(p=>p.Usuarios)
        .HasForeignKey(p=>p.tipodoc)
        .IsRequired();
    }
}
