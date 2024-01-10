using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Data_helper.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_Duration",
                table: "Feedbacks");

            migrationBuilder.AddColumn<string>(
                name: "FeedbackContent",
                table: "tbOrders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "StatusFeedback",
                table: "tbOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Duration_Id",
                table: "Feedbacks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 26,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 27,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 28,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 29,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 30,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 31,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 32,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 33,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 34,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 35,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 36,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 37,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 38,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 39,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 40,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 41,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 42,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 43,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 44,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 45,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 46,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 47,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 48,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 49,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 50,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 51,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 52,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 53,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 54,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 55,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 56,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 57,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 58,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 59,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 60,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 61,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 62,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 63,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 64,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 65,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 66,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 67,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 68,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 69,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 70,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 71,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 72,
                column: "Time",
                value: new DateTime(2024, 1, 10, 1, 19, 5, 268, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 78, 23, 251, 54, 217, 241, 211, 178, 19, 207, 220, 235, 159, 52, 61, 22, 41, 57, 77, 123, 148, 240, 20, 0, 193, 209, 170, 210, 155, 189, 44, 112, 57, 220, 220, 238, 249, 53, 20, 158, 18, 3, 232, 93, 15, 118, 39, 0, 93, 17, 19, 170, 177, 182, 59, 50, 97, 36, 57, 230, 200, 4, 201 }, new byte[] { 234, 56, 169, 63, 125, 91, 138, 220, 242, 186, 144, 237, 99, 113, 2, 136, 31, 193, 123, 100, 193, 140, 109, 208, 163, 67, 127, 25, 200, 146, 152, 128, 159, 95, 27, 177, 172, 5, 103, 152, 92, 10, 214, 86, 86, 171, 175, 118, 144, 115, 196, 188, 49, 108, 176, 68, 240, 82, 60, 38, 191, 99, 63, 4, 250, 75, 155, 243, 141, 175, 62, 169, 213, 81, 14, 60, 14, 116, 218, 104, 244, 50, 208, 50, 127, 243, 133, 230, 6, 45, 49, 28, 0, 203, 108, 60, 172, 245, 197, 179, 25, 67, 15, 62, 216, 177, 127, 68, 142, 130, 221, 0, 121, 182, 25, 146, 253, 235, 14, 206, 31, 158, 28, 138, 193, 78, 26, 106 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 78, 23, 251, 54, 217, 241, 211, 178, 19, 207, 220, 235, 159, 52, 61, 22, 41, 57, 77, 123, 148, 240, 20, 0, 193, 209, 170, 210, 155, 189, 44, 112, 57, 220, 220, 238, 249, 53, 20, 158, 18, 3, 232, 93, 15, 118, 39, 0, 93, 17, 19, 170, 177, 182, 59, 50, 97, 36, 57, 230, 200, 4, 201 }, new byte[] { 234, 56, 169, 63, 125, 91, 138, 220, 242, 186, 144, 237, 99, 113, 2, 136, 31, 193, 123, 100, 193, 140, 109, 208, 163, 67, 127, 25, 200, 146, 152, 128, 159, 95, 27, 177, 172, 5, 103, 152, 92, 10, 214, 86, 86, 171, 175, 118, 144, 115, 196, 188, 49, 108, 176, 68, 240, 82, 60, 38, 191, 99, 63, 4, 250, 75, 155, 243, 141, 175, 62, 169, 213, 81, 14, 60, 14, 116, 218, 104, 244, 50, 208, 50, 127, 243, 133, 230, 6, 45, 49, 28, 0, 203, 108, 60, 172, 245, 197, 179, 25, 67, 15, 62, 216, 177, 127, 68, 142, 130, 221, 0, 121, 182, 25, 146, 253, 235, 14, 206, 31, 158, 28, 138, 193, 78, 26, 106 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 78, 23, 251, 54, 217, 241, 211, 178, 19, 207, 220, 235, 159, 52, 61, 22, 41, 57, 77, 123, 148, 240, 20, 0, 193, 209, 170, 210, 155, 189, 44, 112, 57, 220, 220, 238, 249, 53, 20, 158, 18, 3, 232, 93, 15, 118, 39, 0, 93, 17, 19, 170, 177, 182, 59, 50, 97, 36, 57, 230, 200, 4, 201 }, new byte[] { 234, 56, 169, 63, 125, 91, 138, 220, 242, 186, 144, 237, 99, 113, 2, 136, 31, 193, 123, 100, 193, 140, 109, 208, 163, 67, 127, 25, 200, 146, 152, 128, 159, 95, 27, 177, 172, 5, 103, 152, 92, 10, 214, 86, 86, 171, 175, 118, 144, 115, 196, 188, 49, 108, 176, 68, 240, 82, 60, 38, 191, 99, 63, 4, 250, 75, 155, 243, 141, 175, 62, 169, 213, 81, 14, 60, 14, 116, 218, 104, 244, 50, 208, 50, 127, 243, 133, 230, 6, 45, 49, 28, 0, 203, 108, 60, 172, 245, 197, 179, 25, 67, 15, 62, 216, 177, 127, 68, 142, 130, 221, 0, 121, 182, 25, 146, 253, 235, 14, 206, 31, 158, 28, 138, 193, 78, 26, 106 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 78, 23, 251, 54, 217, 241, 211, 178, 19, 207, 220, 235, 159, 52, 61, 22, 41, 57, 77, 123, 148, 240, 20, 0, 193, 209, 170, 210, 155, 189, 44, 112, 57, 220, 220, 238, 249, 53, 20, 158, 18, 3, 232, 93, 15, 118, 39, 0, 93, 17, 19, 170, 177, 182, 59, 50, 97, 36, 57, 230, 200, 4, 201 }, new byte[] { 234, 56, 169, 63, 125, 91, 138, 220, 242, 186, 144, 237, 99, 113, 2, 136, 31, 193, 123, 100, 193, 140, 109, 208, 163, 67, 127, 25, 200, 146, 152, 128, 159, 95, 27, 177, 172, 5, 103, 152, 92, 10, 214, 86, 86, 171, 175, 118, 144, 115, 196, 188, 49, 108, 176, 68, 240, 82, 60, 38, 191, 99, 63, 4, 250, 75, 155, 243, 141, 175, 62, 169, 213, 81, 14, 60, 14, 116, 218, 104, 244, 50, 208, 50, 127, 243, 133, 230, 6, 45, 49, 28, 0, 203, 108, 60, 172, 245, 197, 179, 25, 67, 15, 62, 216, 177, 127, 68, 142, 130, 221, 0, 121, 182, 25, 146, 253, 235, 14, 206, 31, 158, 28, 138, 193, 78, 26, 106 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 78, 23, 251, 54, 217, 241, 211, 178, 19, 207, 220, 235, 159, 52, 61, 22, 41, 57, 77, 123, 148, 240, 20, 0, 193, 209, 170, 210, 155, 189, 44, 112, 57, 220, 220, 238, 249, 53, 20, 158, 18, 3, 232, 93, 15, 118, 39, 0, 93, 17, 19, 170, 177, 182, 59, 50, 97, 36, 57, 230, 200, 4, 201 }, new byte[] { 234, 56, 169, 63, 125, 91, 138, 220, 242, 186, 144, 237, 99, 113, 2, 136, 31, 193, 123, 100, 193, 140, 109, 208, 163, 67, 127, 25, 200, 146, 152, 128, 159, 95, 27, 177, 172, 5, 103, 152, 92, 10, 214, 86, 86, 171, 175, 118, 144, 115, 196, 188, 49, 108, 176, 68, 240, 82, 60, 38, 191, 99, 63, 4, 250, 75, 155, 243, 141, 175, 62, 169, 213, 81, 14, 60, 14, 116, 218, 104, 244, 50, 208, 50, 127, 243, 133, 230, 6, 45, 49, 28, 0, 203, 108, 60, 172, 245, 197, 179, 25, 67, 15, 62, 216, 177, 127, 68, 142, 130, 221, 0, 121, 182, 25, 146, 253, 235, 14, 206, 31, 158, 28, 138, 193, 78, 26, 106 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 78, 23, 251, 54, 217, 241, 211, 178, 19, 207, 220, 235, 159, 52, 61, 22, 41, 57, 77, 123, 148, 240, 20, 0, 193, 209, 170, 210, 155, 189, 44, 112, 57, 220, 220, 238, 249, 53, 20, 158, 18, 3, 232, 93, 15, 118, 39, 0, 93, 17, 19, 170, 177, 182, 59, 50, 97, 36, 57, 230, 200, 4, 201 }, new byte[] { 234, 56, 169, 63, 125, 91, 138, 220, 242, 186, 144, 237, 99, 113, 2, 136, 31, 193, 123, 100, 193, 140, 109, 208, 163, 67, 127, 25, 200, 146, 152, 128, 159, 95, 27, 177, 172, 5, 103, 152, 92, 10, 214, 86, 86, 171, 175, 118, 144, 115, 196, 188, 49, 108, 176, 68, 240, 82, 60, 38, 191, 99, 63, 4, 250, 75, 155, 243, 141, 175, 62, 169, 213, 81, 14, 60, 14, 116, 218, 104, 244, 50, 208, 50, 127, 243, 133, 230, 6, 45, 49, 28, 0, 203, 108, 60, 172, 245, 197, 179, 25, 67, 15, 62, 216, 177, 127, 68, 142, 130, 221, 0, 121, 182, 25, 146, 253, 235, 14, 206, 31, 158, 28, 138, 193, 78, 26, 106 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 78, 23, 251, 54, 217, 241, 211, 178, 19, 207, 220, 235, 159, 52, 61, 22, 41, 57, 77, 123, 148, 240, 20, 0, 193, 209, 170, 210, 155, 189, 44, 112, 57, 220, 220, 238, 249, 53, 20, 158, 18, 3, 232, 93, 15, 118, 39, 0, 93, 17, 19, 170, 177, 182, 59, 50, 97, 36, 57, 230, 200, 4, 201 }, new byte[] { 234, 56, 169, 63, 125, 91, 138, 220, 242, 186, 144, 237, 99, 113, 2, 136, 31, 193, 123, 100, 193, 140, 109, 208, 163, 67, 127, 25, 200, 146, 152, 128, 159, 95, 27, 177, 172, 5, 103, 152, 92, 10, 214, 86, 86, 171, 175, 118, 144, 115, 196, 188, 49, 108, 176, 68, 240, 82, 60, 38, 191, 99, 63, 4, 250, 75, 155, 243, 141, 175, 62, 169, 213, 81, 14, 60, 14, 116, 218, 104, 244, 50, 208, 50, 127, 243, 133, 230, 6, 45, 49, 28, 0, 203, 108, 60, 172, 245, 197, 179, 25, 67, 15, 62, 216, 177, 127, 68, 142, 130, 221, 0, 121, 182, 25, 146, 253, 235, 14, 206, 31, 158, 28, 138, 193, 78, 26, 106 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 78, 23, 251, 54, 217, 241, 211, 178, 19, 207, 220, 235, 159, 52, 61, 22, 41, 57, 77, 123, 148, 240, 20, 0, 193, 209, 170, 210, 155, 189, 44, 112, 57, 220, 220, 238, 249, 53, 20, 158, 18, 3, 232, 93, 15, 118, 39, 0, 93, 17, 19, 170, 177, 182, 59, 50, 97, 36, 57, 230, 200, 4, 201 }, new byte[] { 234, 56, 169, 63, 125, 91, 138, 220, 242, 186, 144, 237, 99, 113, 2, 136, 31, 193, 123, 100, 193, 140, 109, 208, 163, 67, 127, 25, 200, 146, 152, 128, 159, 95, 27, 177, 172, 5, 103, 152, 92, 10, 214, 86, 86, 171, 175, 118, 144, 115, 196, 188, 49, 108, 176, 68, 240, 82, 60, 38, 191, 99, 63, 4, 250, 75, 155, 243, 141, 175, 62, 169, 213, 81, 14, 60, 14, 116, 218, 104, 244, 50, 208, 50, 127, 243, 133, 230, 6, 45, 49, 28, 0, 203, 108, 60, 172, 245, 197, 179, 25, 67, 15, 62, 216, 177, 127, 68, 142, 130, 221, 0, 121, 182, 25, 146, 253, 235, 14, 206, 31, 158, 28, 138, 193, 78, 26, 106 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 78, 23, 251, 54, 217, 241, 211, 178, 19, 207, 220, 235, 159, 52, 61, 22, 41, 57, 77, 123, 148, 240, 20, 0, 193, 209, 170, 210, 155, 189, 44, 112, 57, 220, 220, 238, 249, 53, 20, 158, 18, 3, 232, 93, 15, 118, 39, 0, 93, 17, 19, 170, 177, 182, 59, 50, 97, 36, 57, 230, 200, 4, 201 }, new byte[] { 234, 56, 169, 63, 125, 91, 138, 220, 242, 186, 144, 237, 99, 113, 2, 136, 31, 193, 123, 100, 193, 140, 109, 208, 163, 67, 127, 25, 200, 146, 152, 128, 159, 95, 27, 177, 172, 5, 103, 152, 92, 10, 214, 86, 86, 171, 175, 118, 144, 115, 196, 188, 49, 108, 176, 68, 240, 82, 60, 38, 191, 99, 63, 4, 250, 75, 155, 243, 141, 175, 62, 169, 213, 81, 14, 60, 14, 116, 218, 104, 244, 50, 208, 50, 127, 243, 133, 230, 6, 45, 49, 28, 0, 203, 108, 60, 172, 245, 197, 179, 25, 67, 15, 62, 216, 177, 127, 68, 142, 130, 221, 0, 121, 182, 25, 146, 253, 235, 14, 206, 31, 158, 28, 138, 193, 78, 26, 106 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 78, 23, 251, 54, 217, 241, 211, 178, 19, 207, 220, 235, 159, 52, 61, 22, 41, 57, 77, 123, 148, 240, 20, 0, 193, 209, 170, 210, 155, 189, 44, 112, 57, 220, 220, 238, 249, 53, 20, 158, 18, 3, 232, 93, 15, 118, 39, 0, 93, 17, 19, 170, 177, 182, 59, 50, 97, 36, 57, 230, 200, 4, 201 }, new byte[] { 234, 56, 169, 63, 125, 91, 138, 220, 242, 186, 144, 237, 99, 113, 2, 136, 31, 193, 123, 100, 193, 140, 109, 208, 163, 67, 127, 25, 200, 146, 152, 128, 159, 95, 27, 177, 172, 5, 103, 152, 92, 10, 214, 86, 86, 171, 175, 118, 144, 115, 196, 188, 49, 108, 176, 68, 240, 82, 60, 38, 191, 99, 63, 4, 250, 75, 155, 243, 141, 175, 62, 169, 213, 81, 14, 60, 14, 116, 218, 104, 244, 50, 208, 50, 127, 243, 133, 230, 6, 45, 49, 28, 0, 203, 108, 60, 172, 245, 197, 179, 25, 67, 15, 62, 216, 177, 127, 68, 142, 130, 221, 0, 121, 182, 25, 146, 253, 235, 14, 206, 31, 158, 28, 138, 193, 78, 26, 106 } });

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_Duration",
                table: "Feedbacks",
                column: "Duration_Id",
                principalTable: "tbDuration",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_Duration",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "FeedbackContent",
                table: "tbOrders");

            migrationBuilder.DropColumn(
                name: "StatusFeedback",
                table: "tbOrders");

            migrationBuilder.AlterColumn<int>(
                name: "Duration_Id",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 26,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 27,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 28,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 29,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 30,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 31,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 32,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 33,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 34,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 35,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 36,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 37,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 38,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 39,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 40,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 41,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 42,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 43,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 44,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 45,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 46,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 47,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 48,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 49,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 50,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 51,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 52,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 53,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 54,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 55,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 56,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 57,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 58,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 59,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 60,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 61,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 62,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 63,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 64,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 65,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 66,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 67,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 68,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 69,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 70,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 71,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 72,
                column: "Time",
                value: new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 } });

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_Duration",
                table: "Feedbacks",
                column: "Duration_Id",
                principalTable: "tbDuration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
