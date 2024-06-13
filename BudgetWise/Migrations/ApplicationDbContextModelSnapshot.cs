﻿// <auto-generated />
using System;
using BudgetWise.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BudgetWise.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

            modelBuilder.Entity("BudgetWise.Models.PersonalUser.UserProfile", b =>
                {
                    b.HasOne("BudgetWise.Models.PersonalUser.PersonalAccount", "Account")
                        .WithOne("Profile")
                        .HasForeignKey("BudgetWise.Models.PersonalUser.UserProfile", "PersonalAccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("BudgetWise.Models.PersonalUser.PersonalAccount", b =>
                {
                    b.Navigation("Profile")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
