﻿// <auto-generated />
using Kfc.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kfc.Infrastructure.Data.Migrations
{
    [DbContext(typeof(KfcDbContext))]
    [Migration("20240813090341_EditIdCI")]
    partial class EditIdCI
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Kfc.Application.Enities.Combo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ComboDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComboName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ComboPrice")
                        .HasColumnType("float");

                    b.Property<int>("MenuTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuTypeId");

                    b.ToTable("Combos");
                });

            modelBuilder.Entity("Kfc.Application.Enities.ComboItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComboId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComboId");

                    b.HasIndex("ItemId");

                    b.ToTable("ComboItems");
                });

            modelBuilder.Entity("Kfc.Application.Enities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ItemPrice")
                        .HasColumnType("float");

                    b.Property<int>("MenuTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuTypeId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Kfc.Application.Enities.MenuType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MenuTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MenuTypes");
                });

            modelBuilder.Entity("Kfc.Application.Enities.Combo", b =>
                {
                    b.HasOne("Kfc.Application.Enities.MenuType", "MenuType")
                        .WithMany("Combos")
                        .HasForeignKey("MenuTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuType");
                });

            modelBuilder.Entity("Kfc.Application.Enities.ComboItem", b =>
                {
                    b.HasOne("Kfc.Application.Enities.Combo", "Combo")
                        .WithMany("ComboItem")
                        .HasForeignKey("ComboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kfc.Application.Enities.Item", "Item")
                        .WithMany("ComboItem")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Combo");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Kfc.Application.Enities.Item", b =>
                {
                    b.HasOne("Kfc.Application.Enities.MenuType", "MenuType")
                        .WithMany("Items")
                        .HasForeignKey("MenuTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuType");
                });

            modelBuilder.Entity("Kfc.Application.Enities.Combo", b =>
                {
                    b.Navigation("ComboItem");
                });

            modelBuilder.Entity("Kfc.Application.Enities.Item", b =>
                {
                    b.Navigation("ComboItem");
                });

            modelBuilder.Entity("Kfc.Application.Enities.MenuType", b =>
                {
                    b.Navigation("Combos");

                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
