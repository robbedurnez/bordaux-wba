﻿// <auto-generated />
using System;
using BordauxWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BordauxWebApp.Migrations
{
    [DbContext(typeof(BordauxIdentityContext))]
    [Migration("20200105203757_Move_Entities")]
    partial class Move_Entities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BordauxLib.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .HasMaxLength(42);

                    b.Property<string>("LastName")
                        .HasMaxLength(42);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfilePicturePath");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "a9ff7e8c-50e8-48a2-82fc-800e48ac4b62",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6cf79976-41fe-4dc2-992a-c370988a83ae",
                            Email = "dwight.senaeve@student.howest.be",
                            EmailConfirmed = false,
                            FirstName = "Dwight",
                            LastName = "Senaeve",
                            LockoutEnabled = false,
                            NormalizedEmail = "DWIGHT.SENAEVE@STUDENT.HOWEST.BE",
                            NormalizedUserName = "DWIGHT.SENAEVE@STUDENT.HOWEST.BE",
                            PasswordHash = "AQAAAAEAACcQAAAAEDyTd4+GvAbjflpigfXVYA9v5aeECyQIwVrLovz97N22kxLSWMtaJZj8/jrbNPFgpw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "{73a68092-d39d-4d2d-a9e7-30516a725aeb}",
                            TwoFactorEnabled = false,
                            UserName = "dwight.senaeve@student.howest.be"
                        },
                        new
                        {
                            Id = "7c4ab2f0-4c4a-4321-bfea-bc4e3156728f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "643dc2ce-2aef-4d35-892c-dc3b1378f451",
                            Email = "robbe.durnez@student.howest.be",
                            EmailConfirmed = false,
                            FirstName = "Robbe",
                            LastName = "Durnez",
                            LockoutEnabled = false,
                            NormalizedEmail = "ROBBE.DURNEZ@STUDENT.HOWEST.BE",
                            NormalizedUserName = "ROBBE.DURNEZ@STUDENT.HOWEST.BE",
                            PasswordHash = "AQAAAAEAACcQAAAAEJJ8L0hmzDDmELR1Rni+LisPbVMPSvLiITsCSqtxhU/pwOnrp7w24N2U9+kP5wenEQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "{527d0020-0a8c-48bd-b6ce-1155f987150f}",
                            TwoFactorEnabled = false,
                            UserName = "robbe.durnez@student.howest.be"
                        },
                        new
                        {
                            Id = "0b7077b2-c65d-40e3-a9db-02489c748f29",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "081204e1-04ee-4155-b6c1-1bf8b993e74f",
                            Email = "john.doe@student.howest.be",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            NormalizedEmail = "JOHN.DOE@STUDENT.HOWEST.BE",
                            NormalizedUserName = "JOHN.DOE@STUDENT.HOWEST.BE",
                            PasswordHash = "AQAAAAEAACcQAAAAELA+TlC1hzAKb4Q6NTe1rWxR2XilC3BwwT0izKMBCmsAvPqQd2NrS6Jw6zlx6VnAiw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "{84a09f4d-e472-46b4-9153-fef2481f824c}",
                            TwoFactorEnabled = false,
                            UserName = "john.doe@student.howest.be"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "42de65d5-a69d-4bd2-9537-e33dcbc785f4",
                            ConcurrencyStamp = "96f8c24c-d861-4668-bd73-cdc4ff15f5b8",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "cc854072-881a-4e1f-9800-cc1d57d42d16",
                            ConcurrencyStamp = "5277c353-d634-4990-b772-401bbe5fe7b1",
                            Name = "Promotor",
                            NormalizedName = "PROMOTOR"
                        },
                        new
                        {
                            Id = "15cb2332-0933-4fa0-9f65-4bfc321235f0",
                            ConcurrencyStamp = "37ba9533-967c-4c2d-80d9-4f096c702bc0",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "a9ff7e8c-50e8-48a2-82fc-800e48ac4b62",
                            RoleId = "42de65d5-a69d-4bd2-9537-e33dcbc785f4"
                        },
                        new
                        {
                            UserId = "7c4ab2f0-4c4a-4321-bfea-bc4e3156728f",
                            RoleId = "42de65d5-a69d-4bd2-9537-e33dcbc785f4"
                        },
                        new
                        {
                            UserId = "0b7077b2-c65d-40e3-a9db-02489c748f29",
                            RoleId = "15cb2332-0933-4fa0-9f65-4bfc321235f0"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BordauxLib.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BordauxLib.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BordauxLib.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BordauxLib.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
