﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using librarySytemAssignment;

namespace librarySytemAssignment.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("librarySytemAssignment.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("BarCode");

                    b.Property<int>("CopyCount");

                    b.Property<string>("Edition");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("librarySytemAssignment.IssueBook", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("bookId");

                    b.Property<string>("BookBarCode");

                    b.Property<DateTime>("IssueDate");

                    b.HasKey("StudentId", "bookId");

                    b.HasIndex("bookId");

                    b.ToTable("IssueBook");
                });

            modelBuilder.Entity("librarySytemAssignment.ReturnBook", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("BookId");

                    b.Property<string>("BookBarCode");

                    b.Property<DateTime>("ReturnDate");

                    b.HasKey("StudentId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("ReturnBooks");
                });

            modelBuilder.Entity("librarySytemAssignment.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("FineAmount");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("librarySytemAssignment.IssueBook", b =>
                {
                    b.HasOne("librarySytemAssignment.Student", "Student")
                        .WithMany("BookIssues")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("librarySytemAssignment.Book", "book")
                        .WithMany("BookIssues")
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("librarySytemAssignment.ReturnBook", b =>
                {
                    b.HasOne("librarySytemAssignment.Book", "Book")
                        .WithMany("BookReturns")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("librarySytemAssignment.Student", "Student")
                        .WithMany("BookReturns")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}