﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP03SW2;

namespace TP03SW2.Migrations
{
    [DbContext(typeof(PortoContext))]
    [Migration("20200926154825_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TP03SW2.Models.BL", b =>
                {
                    b.Property<int>("BLId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Consignee");

                    b.Property<int>("Numero");

                    b.Property<string>("Navio");

                    b.HasKey("BLId");

                    b.ToTable("BLs");
                });

            modelBuilder.Entity("TP03SW2.Models.Container", b =>
                {
                    b.Property<int>("ContainerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BLId");

                    b.Property<int>("Numero");

                    b.Property<string>("Tamanho");

                    b.Property<string>("Tipo");

                    b.HasKey("ContainerId");

                    b.HasIndex("BLId");

                    b.ToTable("Containers");
                });

            modelBuilder.Entity("TP03SW2.Models.Container", b =>
                {
                    b.HasOne("TP03SW2.Models.BL", "BL")
                        .WithMany("Containers")
                        .HasForeignKey("BLId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
