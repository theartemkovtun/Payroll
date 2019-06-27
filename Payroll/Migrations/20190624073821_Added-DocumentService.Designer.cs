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
    [Migration("20190624073821_Added-DocumentService")]
    partial class AddedDocumentService
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Payroll.Models.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("CreatorUsername");

                    b.HasKey("DocumentId");

                    b.HasIndex("CreatorUsername");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Payroll.Models.DocumentService", b =>
                {
                    b.Property<int>("DocumentId");

                    b.Property<int>("ServiceId");

                    b.HasKey("DocumentId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("DocumentService");
                });

            modelBuilder.Entity("Payroll.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<float>("Hours");

                    b.Property<string>("Name");

                    b.Property<string>("Username");

                    b.HasKey("ServiceId");

                    b.HasIndex("Username");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Payroll.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Payroll.Models.UserProfile", b =>
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

                    b.Property<string>("Username");

                    b.HasKey("VAT");

                    b.HasIndex("Username");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("Payroll.Models.Document", b =>
                {
                    b.HasOne("Payroll.Models.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorUsername");
                });

            modelBuilder.Entity("Payroll.Models.DocumentService", b =>
                {
                    b.HasOne("Payroll.Models.Document", "Document")
                        .WithMany("Services")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Payroll.Models.Service", "Service")
                        .WithMany("Documents")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Payroll.Models.Service", b =>
                {
                    b.HasOne("Payroll.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Username");
                });

            modelBuilder.Entity("Payroll.Models.UserProfile", b =>
                {
                    b.HasOne("Payroll.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Username");
                });
#pragma warning restore 612, 618
        }
    }
}
