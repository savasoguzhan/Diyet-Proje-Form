﻿// <auto-generated />
using M_Proje.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace M_Proje.Data.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    [Migration("20230107100641_Yedi")]
    partial class Yedi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KullaniciOgun", b =>
                {
                    b.Property<int>("KullanicilarId")
                        .HasColumnType("int");

                    b.Property<int>("OgunlerId")
                        .HasColumnType("int");

                    b.HasKey("KullanicilarId", "OgunlerId");

                    b.HasIndex("OgunlerId");

                    b.ToTable("KullaniciOgun");
                });

            modelBuilder.Entity("M_Proje.Class.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId")
                        .IsUnique();

                    b.ToTable("Adminler");
                });

            modelBuilder.Entity("M_Proje.Class.Besin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Kalori")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Miktar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OgunId")
                        .HasColumnType("int");

                    b.Property<string>("ResimUrl")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("OgunId");

                    b.ToTable("Besinler");
                });

            modelBuilder.Entity("M_Proje.Class.Egitmen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Egitmenler");
                });

            modelBuilder.Entity("M_Proje.Class.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Boy")
                        .HasColumnType("float");

                    b.Property<string>("Cinsiyet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EgitmenId")
                        .HasColumnType("int");

                    b.Property<double>("Kilo")
                        .HasColumnType("float");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Yas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EgitmenId");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("M_Proje.Class.Ogun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Zaman")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ogunler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Zaman = "Sabah"
                        },
                        new
                        {
                            Id = 2,
                            Zaman = "Öğle"
                        },
                        new
                        {
                            Id = 3,
                            Zaman = "Akşam"
                        });
                });

            modelBuilder.Entity("KullaniciOgun", b =>
                {
                    b.HasOne("M_Proje.Class.Kullanici", null)
                        .WithMany()
                        .HasForeignKey("KullanicilarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("M_Proje.Class.Ogun", null)
                        .WithMany()
                        .HasForeignKey("OgunlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("M_Proje.Class.Admin", b =>
                {
                    b.HasOne("M_Proje.Class.Kullanici", "Kullanici")
                        .WithOne("Admin")
                        .HasForeignKey("M_Proje.Class.Admin", "KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("M_Proje.Class.Besin", b =>
                {
                    b.HasOne("M_Proje.Class.Ogun", "Ogun")
                        .WithMany("Besinler")
                        .HasForeignKey("OgunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogun");
                });

            modelBuilder.Entity("M_Proje.Class.Kullanici", b =>
                {
                    b.HasOne("M_Proje.Class.Egitmen", "Egitmen")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("EgitmenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Egitmen");
                });

            modelBuilder.Entity("M_Proje.Class.Egitmen", b =>
                {
                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("M_Proje.Class.Kullanici", b =>
                {
                    b.Navigation("Admin");
                });

            modelBuilder.Entity("M_Proje.Class.Ogun", b =>
                {
                    b.Navigation("Besinler");
                });
#pragma warning restore 612, 618
        }
    }
}
