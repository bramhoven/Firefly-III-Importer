﻿// <auto-generated />
using System;
using Luciferin.DataLayer.Storage.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Luciferin.DataLayer.Storage.Mysql.Migrations
{
    [DbContext(typeof(StorageContext))]
    partial class StorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Luciferin.DataLayer.Storage.Entities.ImportStatistic", b =>
                {
                    b.Property<DateTime>("ImportDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ExistingTransactionsFiltered")
                        .HasColumnType("int");

                    b.Property<int>("NewTransactions")
                        .HasColumnType("int");

                    b.Property<bool>("StartingBalanceSet")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("TotalAccounts")
                        .HasColumnType("int");

                    b.Property<int>("TotalFireflyTransactions")
                        .HasColumnType("int");

                    b.Property<int>("TotalRetrievedTransactions")
                        .HasColumnType("int");

                    b.Property<int>("TransfersFiltered")
                        .HasColumnType("int");

                    b.HasKey("ImportDate");

                    b.ToTable("ImportStatistics", (string)null);
                });

            modelBuilder.Entity("Luciferin.DataLayer.Storage.Entities.Setting", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnOrder(0);

                    b.Property<bool?>("BooleanValue")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("IntValue")
                        .HasColumnType("int");

                    b.Property<string>("StringValue")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<TimeSpan?>("TimeSpanValue")
                        .HasColumnType("time(6)");

                    b.Property<string>("ValueType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnOrder(1);

                    b.HasKey("Key");

                    b.ToTable("Settings", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
