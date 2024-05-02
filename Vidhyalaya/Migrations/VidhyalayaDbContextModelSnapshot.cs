﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Vidhyalaya.Migrations
{
    [DbContext(typeof(VidhyalayaDbContext))]
    partial class VidhyalayaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Grade", b =>
                {
                    b.Property<int>("Label")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassTeacher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Medium")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Session")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Label");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("Guardian", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Guardian");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("TEXT");

                    b.Property<string>("GuardianDetailsName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.HasIndex("GuardianDetailsName");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.HasOne("Guardian", "GuardianDetails")
                        .WithMany()
                        .HasForeignKey("GuardianDetailsName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GuardianDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
