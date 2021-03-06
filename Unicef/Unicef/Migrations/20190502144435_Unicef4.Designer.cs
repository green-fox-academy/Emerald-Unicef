﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Unicef.Data;

namespace Unicef.Migrations
{
    [DbContext(typeof(ApplicatonContext))]
    [Migration("20190502144435_Unicef4")]
    partial class Unicef4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Unicef.Models.Answer", b =>
                {
                    b.Property<long>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<long?>("QuestionId");

                    b.Property<int>("Value");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Unicef.Models.Form", b =>
                {
                    b.Property<long>("FormId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QueryId");

                    b.HasKey("FormId");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("Unicef.Models.Query", b =>
                {
                    b.Property<long>("QueryId");

                    b.Property<long?>("FormId");

                    b.Property<long?>("QuizId");

                    b.HasKey("QueryId");

                    b.HasIndex("FormId");

                    b.HasIndex("QuizId");

                    b.ToTable("Queries");
                });

            modelBuilder.Entity("Unicef.Models.Question", b =>
                {
                    b.Property<long>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<long?>("FormId");

                    b.Property<long?>("QuizId");

                    b.HasKey("QuestionId");

                    b.HasIndex("FormId");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Unicef.Models.Quiz", b =>
                {
                    b.Property<long>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QueryId");

                    b.HasKey("QuizId");

                    b.ToTable("Quizes");
                });

            modelBuilder.Entity("Unicef.Models.Answer", b =>
                {
                    b.HasOne("Unicef.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("Unicef.Models.Query", b =>
                {
                    b.HasOne("Unicef.Models.Form")
                        .WithMany()
                        .HasForeignKey("FormId");

                    b.HasOne("Unicef.Models.Form", "Form")
                        .WithOne("Query")
                        .HasForeignKey("Unicef.Models.Query", "QueryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Unicef.Models.Quiz", "Quiz")
                        .WithOne("Query")
                        .HasForeignKey("Unicef.Models.Query", "QueryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Unicef.Models.Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId");
                });

            modelBuilder.Entity("Unicef.Models.Question", b =>
                {
                    b.HasOne("Unicef.Models.Form", "Form")
                        .WithMany("Questions")
                        .HasForeignKey("FormId");

                    b.HasOne("Unicef.Models.Quiz", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId");
                });
#pragma warning restore 612, 618
        }
    }
}
