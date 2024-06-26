﻿// <auto-generated />
using System;
using BudgetWise.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BudgetWise.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240625214929_AddTargetsTable")]
    partial class AddTargetsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BudgetWise.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BudgetWise.Models.IncomeStream", b =>
                {
                    b.Property<int>("IncomeStreamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IncomeStreamID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalAccountID")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IncomeStreamID");

                    b.HasIndex("PersonalAccountID");

                    b.ToTable("IncomeStreams");
                });

            modelBuilder.Entity("BudgetWise.Models.PersonalUser.PersonalAccount", b =>
                {
                    b.Property<int>("PersonalAccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonalAccountID"));

                    b.Property<string>("AuthSecret")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalAccountID");

                    b.ToTable("PersonalAccounts");
                });

            modelBuilder.Entity("BudgetWise.Models.PersonalUser.UserProfile", b =>
                {
                    b.Property<int>("ProfileID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileID"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalAccountID")
                        .HasColumnType("int");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfileID");

                    b.HasIndex("PersonalAccountID")
                        .IsUnique();

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("BudgetWise.Models.Targets", b =>
                {
                    b.Property<int>("TargetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TargetID"));

                    b.Property<decimal>("Future")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Luxuries")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Necessities")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PersonalAccountID")
                        .HasColumnType("int");

                    b.HasKey("TargetID");

                    b.HasIndex("PersonalAccountID");

                    b.ToTable("Targets");
                });

            modelBuilder.Entity("BudgetWise.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateEntered")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonalAccountID")
                        .HasColumnType("int");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("PersonalAccountID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("BudgetWise.Models.IncomeStream", b =>
                {
                    b.HasOne("BudgetWise.Models.PersonalUser.PersonalAccount", "Account")
                        .WithMany("IncomeStreams")
                        .HasForeignKey("PersonalAccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("BudgetWise.Models.PersonalUser.UserProfile", b =>
                {
                    b.HasOne("BudgetWise.Models.PersonalUser.PersonalAccount", "Account")
                        .WithOne("Profile")
                        .HasForeignKey("BudgetWise.Models.PersonalUser.UserProfile", "PersonalAccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("BudgetWise.Models.Targets", b =>
                {
                    b.HasOne("BudgetWise.Models.PersonalUser.PersonalAccount", "Account")
                        .WithMany()
                        .HasForeignKey("PersonalAccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("BudgetWise.Models.Transaction", b =>
                {
                    b.HasOne("BudgetWise.Models.Category", "Category")
                        .WithMany("Transactions")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BudgetWise.Models.PersonalUser.PersonalAccount", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("PersonalAccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BudgetWise.Models.Category", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("BudgetWise.Models.PersonalUser.PersonalAccount", b =>
                {
                    b.Navigation("IncomeStreams");

                    b.Navigation("Profile")
                        .IsRequired();

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
