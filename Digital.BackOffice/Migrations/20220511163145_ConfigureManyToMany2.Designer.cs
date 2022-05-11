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
    [Migration("20220511163145_ConfigureManyToMany2")]
    partial class ConfigureManyToMany2
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

            modelBuilder.Entity("Digital.BackOffice.Model.RelationTiers", b =>
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("NUMBER(1)");

                    b.Property<int?>("RelationId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("TierId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime?>("UDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("UUSer")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("RelationId");

                    b.HasIndex("TierId");

                    b.ToTable("RT");
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

            modelBuilder.Entity("Digital.BackOffice.Model.Account", b =>
                {
                    b.HasOne("Digital.BackOffice.Model.Tier", null)
                        .WithMany("Accounts")
                        .HasForeignKey("TierId");
                });

            modelBuilder.Entity("Digital.BackOffice.Model.RelationTiers", b =>
                {
                    b.HasOne("Digital.BackOffice.Model.Relation", "Relation")
                        .WithMany("RTiers")
                        .HasForeignKey("RelationId");

                    b.HasOne("Digital.BackOffice.Model.Tier", "Tier")
                        .WithMany("RTiers")
                        .HasForeignKey("TierId");

                    b.Navigation("Relation");

                    b.Navigation("Tier");
                });

            modelBuilder.Entity("Digital.BackOffice.Model.Relation", b =>
                {
                    b.Navigation("RTiers");
                });

            modelBuilder.Entity("Digital.BackOffice.Model.Tier", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("RTiers");
                });
#pragma warning restore 612, 618
        }
    }
}
