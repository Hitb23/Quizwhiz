﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using server.DataLayer.DataContext;

#nullable disable

namespace server.DataLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240618120800_fktocreatedbyinquizupdated")]
    partial class fktocreatedbyinquizupdated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("server.DataLayer.Models.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AnswerId"));

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("server.DataLayer.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("QuestionId"));

                    b.Property<int>("Mark")
                        .HasColumnType("integer");

                    b.Property<string>("OptionA")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OptionB")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OptionC")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OptionD")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("QuestionTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("QuizId")
                        .HasColumnType("integer");

                    b.HasKey("QuestionId");

                    b.HasIndex("QuestionTypeId");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("server.DataLayer.Models.QuestionType", b =>
                {
                    b.Property<int>("QuestionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("QuestionTypeId"));

                    b.Property<string>("QuesionTypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("QuestionTypeId");

                    b.ToTable("QuestionTypes");
                });

            modelBuilder.Entity("server.DataLayer.Models.Quiz", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("QuizId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedByUserUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean");

                    b.Property<int>("MarksPerQuestion")
                        .HasColumnType("integer");

                    b.Property<int>("MinMarks")
                        .HasColumnType("integer");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<int>("ModifiedByUserUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("NegativePerQuestion")
                        .HasColumnType("integer");

                    b.Property<string>("QuizLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("QuizStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ScheduleId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TotalMarks")
                        .HasColumnType("integer");

                    b.Property<int>("TotalQuestion")
                        .HasColumnType("integer");

                    b.Property<int?>("WinningAmount")
                        .HasColumnType("integer");

                    b.HasKey("QuizId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedByUserUserId");

                    b.HasIndex("ModifiedByUserUserId");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("server.DataLayer.Models.QuizCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("QuizCategories");
                });

            modelBuilder.Entity("server.DataLayer.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNotificationEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("NameAbbreviation")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("ResetToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("ResetTokenExpiry")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("server.DataLayer.Models.UserRole", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("server.DataLayer.Models.Answer", b =>
                {
                    b.HasOne("server.DataLayer.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("server.DataLayer.Models.Question", b =>
                {
                    b.HasOne("server.DataLayer.Models.QuestionType", "QuestionType")
                        .WithMany()
                        .HasForeignKey("QuestionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("server.DataLayer.Models.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionType");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("server.DataLayer.Models.Quiz", b =>
                {
                    b.HasOne("server.DataLayer.Models.QuizCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("server.DataLayer.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("server.DataLayer.Models.User", "ModifiedByUser")
                        .WithMany()
                        .HasForeignKey("ModifiedByUserUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("CreatedByUser");

                    b.Navigation("ModifiedByUser");
                });

            modelBuilder.Entity("server.DataLayer.Models.User", b =>
                {
                    b.HasOne("server.DataLayer.Models.UserRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("server.DataLayer.Models.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
