﻿// <auto-generated />
using Accounting.DataLayer2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Accounting.DataLayer2.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20200812122802_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Accounting.DataLayer2.Models.DbGeographicalPoints", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Gpoint");

                    b.Property<int>("JPersen");

                    b.Property<double>("Lat1");

                    b.Property<double>("Lat2");

                    b.Property<double>("Lon1");

                    b.Property<double>("Lon2");

                    b.HasKey("ID");

                    b.HasIndex("JPersen");

                    b.ToTable("DbGeographicalPoints");
                });

            modelBuilder.Entity("Accounting.DataLayer2.Models.Persen", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.ToTable("Persen");
                });

            modelBuilder.Entity("Accounting.DataLayer2.Models.DbGeographicalPoints", b =>
                {
                    b.HasOne("Accounting.DataLayer2.Models.Persen", "Persen")
                        .WithMany("DbGeographicalPoints")
                        .HasForeignKey("JPersen")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
