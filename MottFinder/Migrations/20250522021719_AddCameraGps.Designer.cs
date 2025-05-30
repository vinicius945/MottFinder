﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MottFinder.Infrastructure.Data.AppData;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace MottFinder.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20250522021719_AddCameraGps")]
    partial class AddCameraGps
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MottFinder.Domain.Entities.Camera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_CAMERA");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdMoto")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_MOTO");

                    b.Property<string>("Posicao")
                        .IsRequired()
                        .HasColumnType("VARCHAR2(100)")
                        .HasColumnName("DS_POSICAO");

                    b.HasKey("Id");

                    b.ToTable("TB_CAMERA");
                });

            modelBuilder.Entity("MottFinder.Domain.Entities.Gps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_GPS");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdMoto")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_MOTO");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("VARCHAR2(50)")
                        .HasColumnName("NR_LATITUDE");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("VARCHAR2(50)")
                        .HasColumnName("NR_LONGITUDE");

                    b.HasKey("Id");

                    b.ToTable("TB_GPS");
                });

            modelBuilder.Entity("MottFinder.Domain.Entities.Moto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_MOTO");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Localizacao")
                        .IsRequired()
                        .HasColumnType("VARCHAR2(100)")
                        .HasColumnName("DS_LOCALIZACAO");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("VARCHAR2(100)")
                        .HasColumnName("NM_MODELO");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("ST_MOTO");

                    b.HasKey("Id");

                    b.ToTable("TB_MOTO");
                });
#pragma warning restore 612, 618
        }
    }
}
