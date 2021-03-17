﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SignUpGenius.Models;

namespace SignUpGenius.Migrations
{
    [DbContext(typeof(SignUpListContext))]
    partial class SignUpListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("SignUpGenius.Models.SignUpItem", b =>
                {
                    b.Property<int>("SignUpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NameOfGroup")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("SizeOfGroup")
                        .HasColumnType("INTEGER");

                    b.Property<string>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("time")
                        .HasColumnType("TEXT");

                    b.HasKey("SignUpId");

                    b.ToTable("signUps");
                });

            modelBuilder.Entity("SignUpGenius.Models.SignUpTime", b =>
                {
                    b.Property<int>("SingUpTimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SingUpTimeId");

                    b.ToTable("signUpTimes");
                });
#pragma warning restore 612, 618
        }
    }
}
