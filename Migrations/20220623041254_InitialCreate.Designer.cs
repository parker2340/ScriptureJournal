﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ScriptureJournal.Migrations
{
    [DbContext(typeof(ScriptureJournalContext))]
    [Migration("20220623041254_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("RazorPagesMovie.Models.Scriptures", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Book")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Chaper")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Verse")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Scriptures");
                });
#pragma warning restore 612, 618
        }
    }
}
