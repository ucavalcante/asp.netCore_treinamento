﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using module4.Data;
using System;

namespace module4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180324040400_ChangeProductAndCategory")]
    partial class ChangeProductAndCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("module4.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Cat");
                });

            modelBuilder.Entity("module4.Domain.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<int?>("categoryId");

                    b.HasKey("ID");

                    b.HasIndex("categoryId");

                    b.ToTable("Prod");
                });

            modelBuilder.Entity("module4.Domain.Product", b =>
                {
                    b.HasOne("module4.Domain.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
