using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SelfieProject.WebApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CameraId = table.Column<string>(nullable: true),
                    CameraName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VoteEntries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageId = table.Column<int>(nullable: false),
                    CameraId = table.Column<int>(nullable: true),
                    VoteDate = table.Column<DateTime>(nullable: false),
                    VoteMessage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteEntries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cameras",
                columns: new[] { "Id", "CameraId", "CameraName" },
                values: new object[,]
                {
                    { 1, "10000", "AR" },
                    { 2, "20000", "MI" },
                    { 3, "30000", "SF" }
                });

            migrationBuilder.InsertData(
                table: "VoteEntries",
                columns: new[] { "Id", "CameraId", "ImageId", "VoteDate", "VoteMessage" },
                values: new object[,]
                {
                    { 21, 1, 309, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR309" },
                    { 20, 1, 309, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR309" },
                    { 19, 1, 309, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR309" },
                    { 18, 1, 307, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR307" },
                    { 17, 1, 307, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR307" },
                    { 16, 1, 307, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR307" },
                    { 15, 1, 307, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR307" },
                    { 14, 1, 307, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR307" },
                    { 13, 1, 307, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR307" },
                    { 12, 1, 307, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR307" },
                    { 10, 1, 307, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR307" },
                    { 22, 1, 309, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR309" },
                    { 9, 1, 307, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR307" },
                    { 8, 1, 305, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR305" },
                    { 7, 1, 305, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR305" },
                    { 6, 1, 305, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR305" },
                    { 5, 1, 305, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR305" },
                    { 4, 1, 305, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR305" },
                    { 3, 1, 305, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR305" },
                    { 2, 1, 305, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR305" },
                    { 1, 1, 305, new DateTime(2018, 8, 5, 17, 49, 59, 346, DateTimeKind.Local), "AR305" },
                    { 11, 1, 307, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR307" },
                    { 23, 1, 309, new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local), "AR309" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cameras");

            migrationBuilder.DropTable(
                name: "VoteEntries");
        }
    }
}
