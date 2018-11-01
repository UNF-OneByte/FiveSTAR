﻿// <auto-generated />
using System;
using FiveSTAR_tracking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FiveSTAR_tracking.Migrations
{
    [DbContext(typeof(ProjectsContext))]
    partial class ProjectsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FiveSTAR_tracking.Models.Projects", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("HoursWorked");

                    b.Property<string>("TaskName");

                    b.Property<decimal>("Task_Act_Cost");

                    b.Property<decimal>("Task_Est_Cost");

                    b.Property<int>("idUsers");

                    b.Property<int>("idVendor");

                    b.HasKey("ID");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
