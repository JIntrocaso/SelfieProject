﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SelfieProject.WebApi.Models;

namespace SelfieProject.WebApi.Migrations
{
    [DbContext(typeof(VoteContext))]
    [Migration("20180811222744_ColumnNameChanges")]
    partial class ColumnNameChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SelfieProject.WebApi.Models.Camera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CameraAbbreviation");

                    b.Property<string>("CameraName");

                    b.HasKey("Id");

                    b.ToTable("Cameras");

                    b.HasData(
                        new { Id = 1, CameraAbbreviation = "10000", CameraName = "AR" },
                        new { Id = 2, CameraAbbreviation = "20000", CameraName = "MI" },
                        new { Id = 3, CameraAbbreviation = "30000", CameraName = "SF" }
                    );
                });

            modelBuilder.Entity("SelfieProject.WebApi.Models.VoteEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CameraId");

                    b.Property<int>("ImageId");

                    b.Property<DateTime>("VoteDate");

                    b.Property<string>("VoteMessage");

                    b.Property<string>("VoterPhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("VoteEntries");

                    b.HasData(
                        new { Id = 1, CameraId = 1, ImageId = 305, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR305" },
                        new { Id = 2, CameraId = 1, ImageId = 305, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR305" },
                        new { Id = 3, CameraId = 1, ImageId = 305, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR305" },
                        new { Id = 4, CameraId = 1, ImageId = 305, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR305" },
                        new { Id = 5, CameraId = 1, ImageId = 305, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR305" },
                        new { Id = 6, CameraId = 1, ImageId = 305, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR305" },
                        new { Id = 7, CameraId = 1, ImageId = 305, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR305" },
                        new { Id = 8, CameraId = 1, ImageId = 305, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR305" },
                        new { Id = 9, CameraId = 1, ImageId = 307, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR307" },
                        new { Id = 10, CameraId = 1, ImageId = 307, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR307" },
                        new { Id = 11, CameraId = 1, ImageId = 307, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR307" },
                        new { Id = 12, CameraId = 1, ImageId = 307, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR307" },
                        new { Id = 13, CameraId = 1, ImageId = 307, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR307" },
                        new { Id = 14, CameraId = 1, ImageId = 307, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR307" },
                        new { Id = 15, CameraId = 1, ImageId = 307, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR307" },
                        new { Id = 16, CameraId = 1, ImageId = 307, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR307" },
                        new { Id = 17, CameraId = 1, ImageId = 307, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR307" },
                        new { Id = 18, CameraId = 1, ImageId = 307, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR307" },
                        new { Id = 19, CameraId = 1, ImageId = 309, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR309" },
                        new { Id = 20, CameraId = 1, ImageId = 309, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR309" },
                        new { Id = 21, CameraId = 1, ImageId = 309, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR309" },
                        new { Id = 22, CameraId = 1, ImageId = 309, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR309" },
                        new { Id = 23, CameraId = 1, ImageId = 309, VoteDate = new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local), VoteMessage = "AR309" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
