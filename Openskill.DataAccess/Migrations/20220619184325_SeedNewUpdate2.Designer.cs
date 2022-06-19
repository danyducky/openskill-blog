﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Openskill.DataAccess;

#nullable disable

namespace Openskill.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220619184325_SeedNewUpdate2")]
    partial class SeedNewUpdate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Openskill.Domain.Entities.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VideoPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Modules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "<ul><li>понятия проблемных коммуникаций</li><li>формы и виды проблемных коммуникаций</li><li>факторы, определяющие специфику проблемных коммуникаций</li><li>основные приёмы преодоления проблемных коммуникаций</li></ul>",
                            Title = "О модуле",
                            VideoPath = "content/videos/IMG_1802.mp4"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Проблемная коммуникация – это экстремальное проявление обычной организационной коммуникации",
                            Title = "Теоретические основы. Часть 1",
                            VideoPath = "content/videos/IMG_2143.mp4"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Проблемная коммуникация состоит из:<br><ul><li>Адресат</li><li>Реципиент</li></ul><br><br>Каналы проблемной коммуникации бывают: устные, цифровые, неформальные",
                            Title = "Теоретические основы. Часть 2",
                            VideoPath = "content/videos/IMG_2151.mp4"
                        },
                        new
                        {
                            Id = 4,
                            Content = "Основные методы решения проблемных коммуникаций<br>МЕТОД 1. Личностная диагностика<br>МЕТОД 2. Невербальный тренинг<br>МЕТОД 3. Социально-психологические практики",
                            Title = "Решаем проблемные коммуникации",
                            VideoPath = "content/videos/IMG_2154.mp4"
                        },
                        new
                        {
                            Id = 5,
                            Content = "Жизнь каждого из нас состоит из нескольких важных сфер, в которых мы балансируем изо дня в день. Часто случается так, что мы фокусируемся только на одной или двух, при этом забывая заботиться об улучшении остальных.<br><br>Колесо баланса — это методика, с помощью которой оценивается наполненность различных сфер жизни человека. Она помогает сделать анализ всех аспектов, рассчитать время и силы, выбрать правильный вектор движения.<br><br>Ответы присылайте на почту <b>openskills.ranepa@yandex.ru</b>",
                            Title = "Колесо баланса",
                            VideoPath = "content/videos/IMG_2159.mp4"
                        },
                        new
                        {
                            Id = 6,
                            Content = "Диагностика личности – это совокупность принципов и методов определения наиболее существенных (для решения проблемных коммуникаций) особенностей личности.<br><br>Ответы присылайте на почту <b>openskills.ranepa@yandex.ru</b>",
                            Title = "Самодиагностика",
                            VideoPath = "content/videos/IMG_2163.mp4"
                        },
                        new
                        {
                            Id = 7,
                            Content = "У каждого из нас есть свои проблемы. Некоторые из них мы должны принять и жить с ними так, как можем. Но к счастью, многие наши проблемы могут быть решены, если мы сможем представить их для себя в виде целей, которых хотели бы достичь.<br><br>Для визуализации цели Вы можете воспользоваться виртуальной онлайн-доской, которая представлена ниже.<br><br>Ответы присылайте на почту <b>openskills.ranepa@yandex.ru</b>",
                            Title = "Проблема – Цель",
                            VideoPath = "content/videos/IMG_2165.mp4"
                        },
                        new
                        {
                            Id = 8,
                            Content = "С Вами было интересно заниматься! Переходите на следующий модуль трека openskills.",
                            Title = "Итоги модуля",
                            VideoPath = "content/videos/IMG_2167.mp4"
                        });
                });

            modelBuilder.Entity("Openskill.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "09959a79-17de-4207-8171-b2f1e506a655",
                            Name = "General",
                            NormalizedName = "GENERAL"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "50db0baf-9dfe-4cce-a589-b9268db004df",
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "d52c0a3b-b396-4a14-aed2-3ebc4471a2d9",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Openskill.Domain.Entities.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAdditional")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Добро пожаловать на модуль «Проблемные коммуникации»!<br><br>Основная цель модуля - приобретение навыков проблемной коммуникации: умение определять проблему, исследовать, рассуждать и производить знания.<br><br>Модуль состоит из восьми блоков. Каждый блок занимает от двух до десяти минут.<br><br><b>Преподаватель модуля «Проблемные коммуникации»</b>: Никитина Алёна Сергеевна, кандидат социологических наук, доцент кафедры управления персоналом<br><br>Длительность обучения: шестьдесят минут",
                            IsAdditional = false,
                            Title = "Проблемные коммуникации"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Рассчитан для госслужащих, которым необходимо поддерживать цифровую трансформацию государства.",
                            IsAdditional = false,
                            Title = "Цифровая грамотность"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Направлен на развитие навыков в деловых переговорах.",
                            IsAdditional = false,
                            Title = "Договоримся?"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Помогает поддерживать русский язык в тонусе.",
                            IsAdditional = true,
                            Title = "Русский язык"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Позволит снизить стрессоустойчивость и повысить работоспособность.",
                            IsAdditional = true,
                            Title = "На вершине или как работать в напряженных условиях"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Направлен на работу в командах.",
                            IsAdditional = true,
                            Title = "Вместе"
                        });
                });

            modelBuilder.Entity("Openskill.Domain.Entities.TrackModule", b =>
                {
                    b.Property<int>("TrackId")
                        .HasColumnType("integer");

                    b.Property<int>("ModuleId")
                        .HasColumnType("integer");

                    b.HasKey("TrackId", "ModuleId");

                    b.HasIndex("ModuleId");

                    b.ToTable("TrackModules");

                    b.HasData(
                        new
                        {
                            TrackId = 1,
                            ModuleId = 1
                        },
                        new
                        {
                            TrackId = 1,
                            ModuleId = 2
                        },
                        new
                        {
                            TrackId = 1,
                            ModuleId = 3
                        },
                        new
                        {
                            TrackId = 1,
                            ModuleId = 4
                        },
                        new
                        {
                            TrackId = 1,
                            ModuleId = 5
                        },
                        new
                        {
                            TrackId = 1,
                            ModuleId = 6
                        },
                        new
                        {
                            TrackId = 1,
                            ModuleId = 7
                        },
                        new
                        {
                            TrackId = 1,
                            ModuleId = 8
                        });
                });

            modelBuilder.Entity("Openskill.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.UserLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.UserToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.RoleClaim", b =>
                {
                    b.HasOne("Openskill.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.TrackModule", b =>
                {
                    b.HasOne("Openskill.Domain.Entities.Module", "Module")
                        .WithMany("TrackModules")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Openskill.Domain.Entities.Track", "Track")
                        .WithMany("TrackModules")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.UserClaim", b =>
                {
                    b.HasOne("Openskill.Domain.Entities.User", "User")
                        .WithMany("UserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.UserLogin", b =>
                {
                    b.HasOne("Openskill.Domain.Entities.User", "User")
                        .WithMany("UserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.UserRole", b =>
                {
                    b.HasOne("Openskill.Domain.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Openskill.Domain.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.UserToken", b =>
                {
                    b.HasOne("Openskill.Domain.Entities.User", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.Module", b =>
                {
                    b.Navigation("TrackModules");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.Track", b =>
                {
                    b.Navigation("TrackModules");
                });

            modelBuilder.Entity("Openskill.Domain.Entities.User", b =>
                {
                    b.Navigation("UserClaims");

                    b.Navigation("UserLogins");

                    b.Navigation("UserRoles");

                    b.Navigation("UserTokens");
                });
#pragma warning restore 612, 618
        }
    }
}