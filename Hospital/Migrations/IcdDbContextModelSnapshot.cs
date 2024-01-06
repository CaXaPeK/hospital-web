﻿// <auto-generated />
using System;
using Hospital.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hospital.Migrations
{
    [DbContext(typeof(IcdDbContext))]
    partial class IcdDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Hospital.Database.TableModels.Diagnosis", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Actual")
                        .HasColumnType("boolean");

                    b.Property<int?>("AddlCode")
                        .HasColumnType("integer");

                    b.Property<DateOnly?>("Date")
                        .HasColumnType("date");

                    b.Property<string>("MkbCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MkbName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid");

                    b.Property<string>("RecCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RootCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Diagnoses");
                });
#pragma warning restore 612, 618
        }
    }
}
