﻿// <auto-generated />
using System;
using CryptoApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CryptoApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250616002052_updatinginvestor1")]
    partial class updatinginvestor1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CryptoApi.Models.CoinData", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("PercentChange1h")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PercentChange24h")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PercentChange30d")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PercentChange60d")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PercentChange7d")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PercentChange90d")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TokenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Volume24h")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VolumeChange24h")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CoinDatas");
                });

            modelBuilder.Entity("CryptoApi.Models.InvestorGrade", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double?>("HoldingReturns")
                        .HasColumnType("float");

                    b.Property<double?>("QuantGrade")
                        .HasColumnType("float");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("TAGrade")
                        .HasColumnType("float");

                    b.Property<double?>("TMInvestorGrade")
                        .HasColumnType("float");

                    b.Property<double?>("TMTraderGrade")
                        .HasColumnType("float");

                    b.Property<double?>("TMTraderGrade24hPctChange")
                        .HasColumnType("float");

                    b.Property<string>("TokenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TokenTrend")
                        .HasColumnType("int");

                    b.Property<int?>("TradingSignal")
                        .HasColumnType("int");

                    b.Property<double?>("TradingSignalsReturns")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("InvestorGrades");
                });

            modelBuilder.Entity("CryptoApi.Models.Sentiment", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double?>("NegativeReddit")
                        .HasColumnType("float");

                    b.Property<double?>("NeutralReddit")
                        .HasColumnType("float");

                    b.Property<double?>("PositiveReddit")
                        .HasColumnType("float");

                    b.Property<int?>("PostCountReddit")
                        .HasColumnType("int");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Sentiments");
                });
#pragma warning restore 612, 618
        }
    }
}
