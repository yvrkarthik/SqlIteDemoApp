﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sqlite.Infrastructure.Data;

namespace Sqlite.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("Sqlite.Core.Entities.ExpenseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("AddedOn");

                    b.Property<DateTime?>("LastModifiedOn");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("ExpenseTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
