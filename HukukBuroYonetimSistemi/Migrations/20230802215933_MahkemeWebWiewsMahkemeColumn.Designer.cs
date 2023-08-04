﻿// <auto-generated />
using System;
using HukukBuroYonetimSistemi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HukukBuroYonetimSistemi.Migrations
{
    [DbContext(typeof(MahkemeDbContext))]
    [Migration("20230802215933_MahkemeWebWiewsMahkemeColumn")]
    partial class MahkemeWebWiewsMahkemeColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HukukBuroYonetimSistemi.Models.Domain.GorevAtamalar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MahkemeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MahkemeId");

                    b.HasIndex("UserId");

                    b.ToTable("GorevAtamalar");
                });

            modelBuilder.Entity("HukukBuroYonetimSistemi.Models.Domain.Mahkemeler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Diger")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DosyaNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DurusmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GelenEvrakTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GelmeTarihi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Gorev")
                        .HasColumnType("datetime2");

                    b.Property<int>("GorevAtamalar")
                        .HasColumnType("int");

                    b.Property<DateTime>("HedefSureSonGun")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("IsTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mahkeme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TebligTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("TebligTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("YargiBirimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YargiTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mahkemeler");
                });

            modelBuilder.Entity("HukukBuroYonetimSistemi.Models.Domain.MahkemelerWebViews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ForForView")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdForView")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LabelForView")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameForView")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placeholder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ValueForView")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ValuesForMahkemeVewViewsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ValuesForMahkemeVewViewsId");

                    b.ToTable("MahkemelerWebViews");
                });

            modelBuilder.Entity("HukukBuroYonetimSistemi.Models.Domain.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Statu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HukukBuroYonetimSistemi.Models.Domain.ValuesForMahkemeVewViews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MahkemeWebViewId")
                        .HasColumnType("int");

                    b.Property<string>("Permission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ValuesForMahkemeVewViews");
                });

            modelBuilder.Entity("HukukBuroYonetimSistemi.Models.Domain.GorevAtamalar", b =>
                {
                    b.HasOne("HukukBuroYonetimSistemi.Models.Domain.Mahkemeler", "Mahkeme")
                        .WithMany()
                        .HasForeignKey("MahkemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HukukBuroYonetimSistemi.Models.Domain.Users", "User")
                        .WithMany("GorevAtamalar")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mahkeme");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HukukBuroYonetimSistemi.Models.Domain.MahkemelerWebViews", b =>
                {
                    b.HasOne("HukukBuroYonetimSistemi.Models.Domain.ValuesForMahkemeVewViews", null)
                        .WithMany("MahkemelerWebViews")
                        .HasForeignKey("ValuesForMahkemeVewViewsId");
                });

            modelBuilder.Entity("HukukBuroYonetimSistemi.Models.Domain.Users", b =>
                {
                    b.Navigation("GorevAtamalar");
                });

            modelBuilder.Entity("HukukBuroYonetimSistemi.Models.Domain.ValuesForMahkemeVewViews", b =>
                {
                    b.Navigation("MahkemelerWebViews");
                });
#pragma warning restore 612, 618
        }
    }
}
