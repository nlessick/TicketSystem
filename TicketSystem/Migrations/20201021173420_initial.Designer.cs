﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketSystem.Models;

namespace TicketSystem.Migrations
{
    [DbContext(typeof(TicketContext))]
    [Migration("20201021173420_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicketSystem.Models.Name", b =>
                {
                    b.Property<string>("NameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActualName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NameId");

                    b.ToTable("Names");

                    b.HasData(
                        new
                        {
                            NameId = "work",
                            ActualName = "Work"
                        },
                        new
                        {
                            NameId = "home",
                            ActualName = "Home"
                        },
                        new
                        {
                            NameId = "cell",
                            ActualName = "Cell"
                        });
                });

            modelBuilder.Entity("TicketSystem.Models.Status", b =>
                {
                    b.Property<string>("StatusID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActualName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusID = "todo",
                            ActualName = "To Do"
                        },
                        new
                        {
                            StatusID = "inprogress",
                            ActualName = "In Progress"
                        },
                        new
                        {
                            StatusID = "qa",
                            ActualName = "Quality Assurance"
                        },
                        new
                        {
                            StatusID = "done",
                            ActualName = "Done"
                        });
                });

            modelBuilder.Entity("TicketSystem.Models.Ticket", b =>
                {
                    b.Property<int>("SprintNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("NameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SprintNumber");

                    b.HasIndex("NameId");

                    b.HasIndex("StatusId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TicketSystem.Models.Ticket", b =>
                {
                    b.HasOne("TicketSystem.Models.Name", "Name")
                        .WithMany()
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketSystem.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
