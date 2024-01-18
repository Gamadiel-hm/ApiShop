﻿// <auto-generated />
using System;
using ApiShopDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiShopDb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiShopModel.Entities.UserInfo", b =>
                {
                    b.Property<Guid>("UserInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserInfoId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("UserInfos");
                });

            modelBuilder.Entity("ApiShopModel.Entities.UserInfoUserRol", b =>
                {
                    b.Property<int>("UserInfoId")
                        .HasColumnType("int");

                    b.Property<int>("UserRolId")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserInfoId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserInfoId", "UserRolId");

                    b.HasIndex("UserInfoId1");

                    b.HasIndex("UserRolId");

                    b.ToTable("UserInfoUserRols");
                });

            modelBuilder.Entity("ApiShopModel.Entities.UserRol", b =>
                {
                    b.Property<int>("UserRolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserRolId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserRolId");

                    b.ToTable("UserRols");
                });

            modelBuilder.Entity("ApiShopModel.Entities.UserSecurity", b =>
                {
                    b.Property<Guid>("UserInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CancelAccount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("FailedRegister")
                        .HasColumnType("int");

                    b.Property<int>("NumberAttempts")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("UserInfoId");

                    b.ToTable("UserSecurities");
                });

            modelBuilder.Entity("ApiShopModel.Entities.UserInfo", b =>
                {
                    b.HasOne("ApiShopModel.Entities.UserSecurity", null)
                        .WithOne("UserInfo")
                        .HasForeignKey("ApiShopModel.Entities.UserInfo", "UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiShopModel.Entities.UserInfoUserRol", b =>
                {
                    b.HasOne("ApiShopModel.Entities.UserInfo", "UserInfo")
                        .WithMany("UserInfoUserRols")
                        .HasForeignKey("UserInfoId1");

                    b.HasOne("ApiShopModel.Entities.UserRol", "UserRol")
                        .WithMany("UserInfoUserRols")
                        .HasForeignKey("UserRolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInfo");

                    b.Navigation("UserRol");
                });

            modelBuilder.Entity("ApiShopModel.Entities.UserInfo", b =>
                {
                    b.Navigation("UserInfoUserRols");
                });

            modelBuilder.Entity("ApiShopModel.Entities.UserRol", b =>
                {
                    b.Navigation("UserInfoUserRols");
                });

            modelBuilder.Entity("ApiShopModel.Entities.UserSecurity", b =>
                {
                    b.Navigation("UserInfo");
                });
#pragma warning restore 612, 618
        }
    }
}