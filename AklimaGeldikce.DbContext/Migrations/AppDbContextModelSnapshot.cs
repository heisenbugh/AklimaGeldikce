﻿// <auto-generated />
using System;
using AklimaGeldikce.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AklimaGeldikce.DbContext.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AklimaGeldikce.Entities.AppLevelLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<string>("Controller");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LogDate");

                    b.Property<Guid?>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("AppLevelLog");
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<Guid?>("ParentCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.CategoryPost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryId");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PostId");

                    b.ToTable("CategoryPost");
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid?>("OwnerId");

                    b.Property<Guid?>("OwnerPostId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("OwnerPostId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.MenuItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<string>("Controller");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<Guid?>("ParentMenuItemId");

                    b.HasKey("Id");

                    b.HasIndex("ParentMenuItemId");

                    b.ToTable("MenuItem");
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid?>("OwnerId");

                    b.Property<string>("Title");

                    b.Property<int>("ViewCount");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<string>("Controller");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("Id");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.RoleMenuItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("MenuItemId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleMenuItem");
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.RoleRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("RequestId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleRequest");
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.RoleUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsLoggedIn");

                    b.Property<DateTime?>("LastLoginDate");

                    b.Property<DateTime?>("LastLogoutDate");

                    b.Property<string>("Password");

                    b.Property<string>("SecondName");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.AppLevelLog", b =>
                {
                    b.HasOne("AklimaGeldikce.Entities.User", "Owner")
                        .WithMany("AppLevelLogs")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.Category", b =>
                {
                    b.HasOne("AklimaGeldikce.Entities.Category", "ParentCategory")
                        .WithMany("ChildCategories")
                        .HasForeignKey("ParentCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.CategoryPost", b =>
                {
                    b.HasOne("AklimaGeldikce.Entities.Category", "Category")
                        .WithMany("CategoryPosts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AklimaGeldikce.Entities.Post", "Post")
                        .WithMany("CategoryPosts")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.Comment", b =>
                {
                    b.HasOne("AklimaGeldikce.Entities.User", "Owner")
                        .WithMany("Comments")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("AklimaGeldikce.Entities.Post", "OwnerPost")
                        .WithMany("Comments")
                        .HasForeignKey("OwnerPostId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.MenuItem", b =>
                {
                    b.HasOne("AklimaGeldikce.Entities.MenuItem", "ParentMenuItem")
                        .WithMany("ChildMenuItems")
                        .HasForeignKey("ParentMenuItemId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.Post", b =>
                {
                    b.HasOne("AklimaGeldikce.Entities.User", "Owner")
                        .WithMany("Posts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.RoleMenuItem", b =>
                {
                    b.HasOne("AklimaGeldikce.Entities.MenuItem", "MenuItem")
                        .WithMany("RoleMenuItems")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AklimaGeldikce.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.RoleRequest", b =>
                {
                    b.HasOne("AklimaGeldikce.Entities.Request", "Request")
                        .WithMany("RoleRequests")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AklimaGeldikce.Entities.Role", "Role")
                        .WithMany("RoleRequests")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AklimaGeldikce.Entities.RoleUser", b =>
                {
                    b.HasOne("AklimaGeldikce.Entities.Role", "Role")
                        .WithMany("RoleUsers")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AklimaGeldikce.Entities.User", "User")
                        .WithMany("RoleUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
