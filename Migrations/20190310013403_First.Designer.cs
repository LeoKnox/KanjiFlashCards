﻿// <auto-generated />
using FlashCard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlashCard.Migrations
{
    [DbContext(typeof(FlashCardContext))]
    [Migration("20190310013403_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FlashCard.Models.Kanji", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayKanji")
                        .IsRequired();

                    b.Property<string>("DisplayWord")
                        .IsRequired();

                    b.Property<string>("Kana")
                        .IsRequired();

                    b.Property<string>("PronounceKanji")
                        .IsRequired();

                    b.HasKey("CardId");

                    b.ToTable("Kanjis");
                });
#pragma warning restore 612, 618
        }
    }
}