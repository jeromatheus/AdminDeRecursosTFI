﻿// <auto-generated />
using System;
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(DatosContexto))]
    partial class DatosContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.Entidades.Area", b =>
                {
                    b.Property<int>("AreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("AreaId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("Dominio.Entidades.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Empresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroIdentificacion")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Dominio.Entidades.Empleado", b =>
                {
                    b.Property<int>("Legajo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AreaId")
                        .HasColumnType("int");

                    b.Property<int>("CUIT")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaDeNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PuestoId")
                        .HasColumnType("int");

                    b.Property<int?>("SueldoId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Legajo");

                    b.HasIndex("AreaId");

                    b.HasIndex("EquipoId");

                    b.HasIndex("PuestoId");

                    b.HasIndex("SueldoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Dominio.Entidades.Equipo", b =>
                {
                    b.Property<int>("EquipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.HasKey("EquipoId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Dominio.Entidades.Permiso", b =>
                {
                    b.Property<int>("OperacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("OperacionId");

                    b.ToTable("Permisos");
                });

            modelBuilder.Entity("Dominio.Entidades.Proyecto", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<float>("Costo")
                        .HasColumnType("real");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaDeFinalizacionEstimada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDeFinalizacionReal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDeInicio")
                        .HasColumnType("datetime2");

                    b.HasKey("ProyectoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EquipoId");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("Dominio.Entidades.Puesto", b =>
                {
                    b.Property<int>("PuestoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seniority")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PuestoId");

                    b.ToTable("Puestos");
                });

            modelBuilder.Entity("Dominio.Entidades.Sueldo", b =>
                {
                    b.Property<int>("SueldoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Bruto")
                        .HasColumnType("real");

                    b.Property<float>("DescuentoJubilacion")
                        .HasColumnType("real");

                    b.Property<float>("DescuentoObraSocial")
                        .HasColumnType("real");

                    b.HasKey("SueldoId");

                    b.ToTable("Sueldos");
                });

            modelBuilder.Entity("Dominio.Entidades.Tarea", b =>
                {
                    b.Property<int>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpleadoLegajo")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProyectoId")
                        .HasColumnType("int");

                    b.Property<int>("TiempoDedicacionEstimado")
                        .HasColumnType("int");

                    b.Property<int>("TiempoDedicacionReal")
                        .HasColumnType("int");

                    b.HasKey("TareaId");

                    b.HasIndex("EmpleadoLegajo");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("Dominio.Entidades.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreDeUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Dominio.Entidades.Empleado", b =>
                {
                    b.HasOne("Dominio.Entidades.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId");

                    b.HasOne("Dominio.Entidades.Equipo", null)
                        .WithMany("Empleados")
                        .HasForeignKey("EquipoId");

                    b.HasOne("Dominio.Entidades.Puesto", "Puesto")
                        .WithMany()
                        .HasForeignKey("PuestoId");

                    b.HasOne("Dominio.Entidades.Sueldo", "Sueldo")
                        .WithMany()
                        .HasForeignKey("SueldoId");

                    b.HasOne("Dominio.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Area");

                    b.Navigation("Puesto");

                    b.Navigation("Sueldo");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Dominio.Entidades.Proyecto", b =>
                {
                    b.HasOne("Dominio.Entidades.Cliente", null)
                        .WithMany("Proyectos")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Dominio.Entidades.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId");

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("Dominio.Entidades.Tarea", b =>
                {
                    b.HasOne("Dominio.Entidades.Empleado", null)
                        .WithMany("Tareas")
                        .HasForeignKey("EmpleadoLegajo");

                    b.HasOne("Dominio.Entidades.Proyecto", null)
                        .WithMany("Tareas")
                        .HasForeignKey("ProyectoId");
                });

            modelBuilder.Entity("Dominio.Entidades.Cliente", b =>
                {
                    b.Navigation("Proyectos");
                });

            modelBuilder.Entity("Dominio.Entidades.Empleado", b =>
                {
                    b.Navigation("Tareas");
                });

            modelBuilder.Entity("Dominio.Entidades.Equipo", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Dominio.Entidades.Proyecto", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
