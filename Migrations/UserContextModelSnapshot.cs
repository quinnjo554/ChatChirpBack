﻿// <auto-generated />
using System;
using ChatChirp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ChatChirp.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ChatChirp.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("DefaultProfile")
                        .HasColumnType("boolean");

                    b.Property<bool>("DefaultProfileImage")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FavouritesCount")
                        .HasColumnType("integer");

                    b.Property<int>("FollowersCount")
                        .HasColumnType("integer");

                    b.Property<int>("FriendsCount")
                        .HasColumnType("integer");

                    b.Property<string>("HasedPassword")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Points")
                        .HasColumnType("integer");

                    b.Property<string>("ProfileBannerUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProfileImageUrlHttps")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Protected")
                        .HasColumnType("boolean");

                    b.Property<string>("ScreenName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StatusesCount")
                        .HasColumnType("integer");

                    b.Property<bool>("Verified")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
