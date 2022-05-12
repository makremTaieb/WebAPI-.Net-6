﻿// <auto-generated />
using System;
using Digital.BackOffice.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Digital.BackOffice.Migrations
{
    [DbContext(typeof(DigitalDbContext))]
    [Migration("20220511175056_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Digital.BackOffice.Model.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("CDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("CUser")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("RIB")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("TierId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime?>("UDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("UUSer")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("TierId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Digital.BackOffice.Model.Relation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("CUser")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("DigitalId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Segment")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime?>("UDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("UUSer")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Relations");
                });

            modelBuilder.Entity("Digital.BackOffice.Model.Tier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("CUser")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("DigitalId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Scope")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime?>("UDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("UUSer")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Tiers");
                });

            modelBuilder.Entity("RelationTier", b =>
                {
                    b.Property<int>("RelationsId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("TiersId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("RelationsId", "TiersId");

                    b.HasIndex("TiersId");

                    b.ToTable("RelationTier");
                });

            modelBuilder.Entity("Digital.BackOffice.Model.Account", b =>
                {
                    b.HasOne("Digital.BackOffice.Model.Tier", null)
                        .WithMany("Accounts")
                        .HasForeignKey("TierId");
                });

            modelBuilder.Entity("RelationTier", b =>
                {
                    b.HasOne("Digital.BackOffice.Model.Relation", null)
                        .WithMany()
                        .HasForeignKey("RelationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digital.BackOffice.Model.Tier", null)
                        .WithMany()
                        .HasForeignKey("TiersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Digital.BackOffice.Model.Tier", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}