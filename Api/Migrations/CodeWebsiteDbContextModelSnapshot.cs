﻿// <auto-generated />
using System;
using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(CodeWebsiteDbContext))]
    partial class CodeWebsiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api.Models.Domain.BlogPost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeaturedImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlHandle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"),
                            Author = "Taurius Antanevicius",
                            Content = "",
                            FeaturedImageUrl = "",
                            Heading = "API MVC course Review",
                            PageTitle = "Best intermediate programmer API course",
                            PublishedDate = new DateTime(2024, 5, 31, 13, 4, 42, 283, DateTimeKind.Local).AddTicks(5866),
                            ShortDescription = "",
                            UrlHandle = "",
                            Visible = true
                        });
                });

            modelBuilder.Entity("Api.Models.Domain.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5035a2a2-54f1-4e6a-81b6-40e0b589f637"),
                            DisplayName = "Review",
                            Name = "Review"
                        },
                        new
                        {
                            Id = new Guid("dad9b2fa-3bb1-4dde-97f9-e2f6e0dc949b"),
                            DisplayName = "Guide",
                            Name = "Guide"
                        },
                        new
                        {
                            Id = new Guid("2fa42358-a83b-412d-8048-c2356e8ccb2a"),
                            DisplayName = "Projects",
                            Name = "Projects"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
