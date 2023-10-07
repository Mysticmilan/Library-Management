﻿// <auto-generated />
using System;
using Library_Management.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library_Management.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231007094413_bookLevelAdd")]
    partial class bookLevelAdd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Library_Management.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublicationID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LevelId");

                    b.HasIndex("PublicationID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library_Management.Models.BookAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("Library_Management.Models.BookCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookCategories");
                });

            modelBuilder.Entity("Library_Management.Models.BookLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookLevels");
                });

            modelBuilder.Entity("Library_Management.Models.LentBook", b =>
                {
                    b.Property<int>("RequestBookId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("lentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RequestBookId");

                    b.HasIndex("UserId");

                    b.ToTable("LentBooks");
                });

            modelBuilder.Entity("Library_Management.Models.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("Library_Management.Models.RequestBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RequestStatus")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("RequestBooks");
                });

            modelBuilder.Entity("Library_Management.Models.RequestCancelledLog", b =>
                {
                    b.Property<int>("RequestBookID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CancelledDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestBookID");

                    b.ToTable("RequestCancelledLogs");
                });

            modelBuilder.Entity("Library_Management.Models.ReturnBook", b =>
                {
                    b.Property<int>("RequestBookId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("returnedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RequestBookId");

                    b.HasIndex("UserId");

                    b.ToTable("ReturnBooks");
                });

            modelBuilder.Entity("Library_Management.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faculty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Library_Management.Models.Book", b =>
                {
                    b.HasOne("Library_Management.Models.BookAuthor", "BookAuthor")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_Management.Models.BookCategory", "BookCategory")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_Management.Models.BookLevel", "BookLevel")
                        .WithMany("Books")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_Management.Models.Publication", "Publication")
                        .WithMany("Books")
                        .HasForeignKey("PublicationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookAuthor");

                    b.Navigation("BookCategory");

                    b.Navigation("BookLevel");

                    b.Navigation("Publication");
                });

            modelBuilder.Entity("Library_Management.Models.LentBook", b =>
                {
                    b.HasOne("Library_Management.Models.RequestBook", "RequestBook")
                        .WithMany("LentBook")
                        .HasForeignKey("RequestBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_Management.Models.User", null)
                        .WithMany("LentBook")
                        .HasForeignKey("UserId");

                    b.Navigation("RequestBook");
                });

            modelBuilder.Entity("Library_Management.Models.RequestBook", b =>
                {
                    b.HasOne("Library_Management.Models.Book", "Books")
                        .WithMany("RequestBook")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_Management.Models.User", "User")
                        .WithMany("RequestBook")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Books");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Library_Management.Models.RequestCancelledLog", b =>
                {
                    b.HasOne("Library_Management.Models.RequestBook", "RequestBook")
                        .WithMany("RequestCancelledLog")
                        .HasForeignKey("RequestBookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RequestBook");
                });

            modelBuilder.Entity("Library_Management.Models.ReturnBook", b =>
                {
                    b.HasOne("Library_Management.Models.RequestBook", "RequestBook")
                        .WithMany("ReturnBook")
                        .HasForeignKey("RequestBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_Management.Models.User", null)
                        .WithMany("ReturnBook")
                        .HasForeignKey("UserId");

                    b.Navigation("RequestBook");
                });

            modelBuilder.Entity("Library_Management.Models.Book", b =>
                {
                    b.Navigation("RequestBook");
                });

            modelBuilder.Entity("Library_Management.Models.BookAuthor", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library_Management.Models.BookCategory", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library_Management.Models.BookLevel", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library_Management.Models.Publication", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library_Management.Models.RequestBook", b =>
                {
                    b.Navigation("LentBook");

                    b.Navigation("RequestCancelledLog");

                    b.Navigation("ReturnBook");
                });

            modelBuilder.Entity("Library_Management.Models.User", b =>
                {
                    b.Navigation("LentBook");

                    b.Navigation("RequestBook");

                    b.Navigation("ReturnBook");
                });
#pragma warning restore 612, 618
        }
    }
}
