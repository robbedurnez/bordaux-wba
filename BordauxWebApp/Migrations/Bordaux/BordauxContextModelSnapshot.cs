﻿// <auto-generated />
using System;
using BordauxWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BordauxWebApp.Migrations.Bordaux
{
    [DbContext(typeof(BordauxContext))]
    partial class BordauxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BordauxLib.Entities.Act", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Acts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8d2ac1e7-2e7c-4b88-a4e7-b73339c3a393"),
                            Name = "Bordaux"
                        },
                        new
                        {
                            Id = new Guid("4bbc7c85-f3d4-4727-939f-e4244c894072"),
                            Name = "Justified"
                        },
                        new
                        {
                            Id = new Guid("b19274b5-6d5d-435c-a508-5cd46e74efc7"),
                            Name = "DwightLight"
                        });
                });

            modelBuilder.Entity("BordauxLib.Entities.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine");

                    b.Property<string>("City");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("EndDate");

                    b.Property<TimeSpan>("EndTime");

                    b.Property<string>("Name");

                    b.Property<int>("PostalCode");

                    b.Property<string>("PromotorId");

                    b.Property<DateTime>("StartDate");

                    b.Property<TimeSpan>("StartTime");

                    b.HasKey("Id");

                    b.HasIndex("PromotorId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f040a0ba-5117-45be-9687-581d7e8d3ece"),
                            AddressLine = "Stationsstraat 19",
                            City = "Torhout",
                            DateCreated = new DateTime(2020, 9, 18, 10, 27, 0, 147, DateTimeKind.Local).AddTicks(7310),
                            EndDate = new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 4, 0, 0, 0),
                            Name = "2Fish invites Bordaux",
                            PostalCode = 8840,
                            PromotorId = "a11f645a-a580-47c4-87fb-6a57b8e16f68",
                            StartDate = new DateTime(2019, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new TimeSpan(0, 18, 0, 0, 0)
                        },
                        new
                        {
                            Id = new Guid("4ef55508-b915-4da1-828a-dc54aa848e2a"),
                            AddressLine = "Kuipersstraat 13",
                            City = "Brugge",
                            DateCreated = new DateTime(2020, 9, 18, 10, 27, 0, 152, DateTimeKind.Local).AddTicks(8020),
                            EndDate = new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 5, 0, 0, 0),
                            Name = "Club NEO invites Bordaux",
                            PostalCode = 8840,
                            PromotorId = "a11f645a-a580-47c4-87fb-6a57b8e16f68",
                            StartDate = new DateTime(2019, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new TimeSpan(0, 23, 0, 0, 0)
                        },
                        new
                        {
                            Id = new Guid("26cc2bff-8fc2-44a8-83a3-8b84efa28a0c"),
                            AddressLine = "Stationsstraat 10",
                            City = "Torhout",
                            DateCreated = new DateTime(2020, 9, 18, 10, 27, 0, 152, DateTimeKind.Local).AddTicks(8050),
                            EndDate = new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 4, 0, 0, 0),
                            Name = "2Fish invites Bordaux pt 2",
                            PostalCode = 8840,
                            PromotorId = "a11f645a-a580-47c4-87fb-6a57b8e16f68",
                            StartDate = new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new TimeSpan(0, 18, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("BordauxLib.Entities.EventAct", b =>
                {
                    b.Property<Guid>("EventId");

                    b.Property<Guid>("ActId");

                    b.HasKey("EventId", "ActId");

                    b.HasIndex("ActId");

                    b.ToTable("EventActs");

                    b.HasData(
                        new
                        {
                            EventId = new Guid("f040a0ba-5117-45be-9687-581d7e8d3ece"),
                            ActId = new Guid("4bbc7c85-f3d4-4727-939f-e4244c894072")
                        },
                        new
                        {
                            EventId = new Guid("f040a0ba-5117-45be-9687-581d7e8d3ece"),
                            ActId = new Guid("8d2ac1e7-2e7c-4b88-a4e7-b73339c3a393")
                        },
                        new
                        {
                            EventId = new Guid("4ef55508-b915-4da1-828a-dc54aa848e2a"),
                            ActId = new Guid("b19274b5-6d5d-435c-a508-5cd46e74efc7")
                        },
                        new
                        {
                            EventId = new Guid("26cc2bff-8fc2-44a8-83a3-8b84efa28a0c"),
                            ActId = new Guid("8d2ac1e7-2e7c-4b88-a4e7-b73339c3a393")
                        },
                        new
                        {
                            EventId = new Guid("26cc2bff-8fc2-44a8-83a3-8b84efa28a0c"),
                            ActId = new Guid("4bbc7c85-f3d4-4727-939f-e4244c894072")
                        });
                });

            modelBuilder.Entity("BordauxLib.Entities.Promotor", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.HasKey("Id");

                    b.ToTable("Promotors");

                    b.HasData(
                        new
                        {
                            Id = "a11f645a-a580-47c4-87fb-6a57b8e16f68",
                            Email = "robbe.durnez@student.howest.be"
                        });
                });

            modelBuilder.Entity("BordauxLib.Entities.Event", b =>
                {
                    b.HasOne("BordauxLib.Entities.Promotor", "Promotor")
                        .WithMany("Events")
                        .HasForeignKey("PromotorId");
                });

            modelBuilder.Entity("BordauxLib.Entities.EventAct", b =>
                {
                    b.HasOne("BordauxLib.Entities.Act", "Act")
                        .WithMany("Events")
                        .HasForeignKey("ActId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BordauxLib.Entities.Event", "Event")
                        .WithMany("Acts")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
