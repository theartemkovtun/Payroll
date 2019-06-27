﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Payroll.Models;

namespace Payroll.Migrations
{
    [DbContext(typeof(PayrollDbContext))]
    [Migration("20190621084614_UniqueUsername")]
    partial class UniqueUsername
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Payroll.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Payroll.Models.UserSettings", b =>
                {
                    b.Property<string>("VAT")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountNumber");

                    b.Property<int>("AddressIndex");

                    b.Property<string>("AddressStreet");

                    b.Property<DateTime>("ContractDate");

                    b.Property<int>("ContractNumber");

                    b.Property<string>("Firstname");

                    b.Property<string>("FirstnameInAblative");

                    b.Property<string>("IBAN");

                    b.Property<string>("Lastname");

                    b.Property<string>("LastnameInAblative");

                    b.Property<string>("Middlename");

                    b.Property<string>("MiddlenameInAblative");

                    b.Property<string>("RecipientBank");

                    b.Property<string>("RegisterNumber");

                    b.Property<float>("USDRate");

                    b.Property<string>("UserId");

                    b.HasKey("VAT");

                    b.HasIndex("UserId");

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("Payroll.Models.UserSettings", b =>
                {
                    b.HasOne("Payroll.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
