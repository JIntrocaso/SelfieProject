using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SelfieProject.WebApi.Migrations
{
    public partial class ColumnNameChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CameraId",
                table: "Cameras",
                newName: "CameraAbbreviation");

            migrationBuilder.AddColumn<string>(
                name: "VoterPhoneNumber",
                table: "VoteEntries",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 21,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 22,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 23,
                column: "VoteDate",
                value: new DateTime(2018, 8, 11, 18, 17, 44, 469, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VoterPhoneNumber",
                table: "VoteEntries");

            migrationBuilder.RenameColumn(
                name: "CameraAbbreviation",
                table: "Cameras",
                newName: "CameraId");

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 346, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 21,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 22,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VoteEntries",
                keyColumn: "Id",
                keyValue: 23,
                column: "VoteDate",
                value: new DateTime(2018, 8, 5, 17, 49, 59, 349, DateTimeKind.Local));
        }
    }
}
