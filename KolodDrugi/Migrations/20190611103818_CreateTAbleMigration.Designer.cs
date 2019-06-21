﻿// <auto-generated />
using KolodDrugi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace KolodDrugi.Migrations
{
    [DbContext(typeof(RentsDbContext))]
    [Migration("20190611103818_CreateTAbleMigration")]
    partial class CreateTAbleMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KolodDrugi.Models.Car", b =>
                {
                    b.Property<int>("IdCar")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("RegisterNumber");

                    b.HasKey("IdCar");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("KolodDrugi.Models.Rent", b =>
                {
                    b.Property<int>("IdRent")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Client")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DateFrom");

                    b.Property<DateTime>("DateTo");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("IdCar");

                    b.HasKey("IdRent");

                    b.HasIndex("IdCar");

                    b.ToTable("Rents");
                });

            modelBuilder.Entity("KolodDrugi.Models.Rent", b =>
                {
                    b.HasOne("KolodDrugi.Models.Car", "Car")
                        .WithMany("Rents")
                        .HasForeignKey("IdCar")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
