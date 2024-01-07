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
            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 5, 13, 859, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 48, 29, 215, 135, 173, 49, 210, 184, 34, 9, 116, 156, 20, 141, 248, 51, 20, 34, 249, 77, 90, 45, 204, 58, 50, 181, 75, 36, 7, 39, 80, 210, 155, 46, 215, 98, 161, 208, 75, 78, 68, 163, 52, 182, 209, 66, 25, 242, 213, 110, 50, 67, 8, 68, 230, 44, 2, 143, 240, 95, 169, 36, 45 }, new byte[] { 208, 103, 149, 135, 5, 157, 244, 243, 84, 188, 102, 248, 118, 187, 139, 91, 200, 12, 114, 110, 88, 92, 35, 157, 163, 142, 182, 76, 43, 65, 255, 48, 117, 21, 43, 26, 6, 89, 112, 253, 51, 112, 99, 44, 10, 235, 126, 157, 28, 222, 205, 219, 30, 229, 49, 91, 31, 36, 27, 33, 235, 33, 196, 7, 238, 163, 207, 189, 81, 16, 150, 216, 206, 73, 73, 0, 5, 175, 193, 47, 60, 49, 125, 98, 132, 7, 116, 28, 43, 25, 91, 14, 143, 89, 14, 78, 81, 63, 103, 37, 212, 0, 117, 31, 95, 66, 47, 79, 157, 141, 149, 112, 161, 38, 159, 104, 175, 65, 163, 75, 7, 166, 184, 203, 152, 30, 222, 74 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 48, 29, 215, 135, 173, 49, 210, 184, 34, 9, 116, 156, 20, 141, 248, 51, 20, 34, 249, 77, 90, 45, 204, 58, 50, 181, 75, 36, 7, 39, 80, 210, 155, 46, 215, 98, 161, 208, 75, 78, 68, 163, 52, 182, 209, 66, 25, 242, 213, 110, 50, 67, 8, 68, 230, 44, 2, 143, 240, 95, 169, 36, 45 }, new byte[] { 208, 103, 149, 135, 5, 157, 244, 243, 84, 188, 102, 248, 118, 187, 139, 91, 200, 12, 114, 110, 88, 92, 35, 157, 163, 142, 182, 76, 43, 65, 255, 48, 117, 21, 43, 26, 6, 89, 112, 253, 51, 112, 99, 44, 10, 235, 126, 157, 28, 222, 205, 219, 30, 229, 49, 91, 31, 36, 27, 33, 235, 33, 196, 7, 238, 163, 207, 189, 81, 16, 150, 216, 206, 73, 73, 0, 5, 175, 193, 47, 60, 49, 125, 98, 132, 7, 116, 28, 43, 25, 91, 14, 143, 89, 14, 78, 81, 63, 103, 37, 212, 0, 117, 31, 95, 66, 47, 79, 157, 141, 149, 112, 161, 38, 159, 104, 175, 65, 163, 75, 7, 166, 184, 203, 152, 30, 222, 74 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 48, 29, 215, 135, 173, 49, 210, 184, 34, 9, 116, 156, 20, 141, 248, 51, 20, 34, 249, 77, 90, 45, 204, 58, 50, 181, 75, 36, 7, 39, 80, 210, 155, 46, 215, 98, 161, 208, 75, 78, 68, 163, 52, 182, 209, 66, 25, 242, 213, 110, 50, 67, 8, 68, 230, 44, 2, 143, 240, 95, 169, 36, 45 }, new byte[] { 208, 103, 149, 135, 5, 157, 244, 243, 84, 188, 102, 248, 118, 187, 139, 91, 200, 12, 114, 110, 88, 92, 35, 157, 163, 142, 182, 76, 43, 65, 255, 48, 117, 21, 43, 26, 6, 89, 112, 253, 51, 112, 99, 44, 10, 235, 126, 157, 28, 222, 205, 219, 30, 229, 49, 91, 31, 36, 27, 33, 235, 33, 196, 7, 238, 163, 207, 189, 81, 16, 150, 216, 206, 73, 73, 0, 5, 175, 193, 47, 60, 49, 125, 98, 132, 7, 116, 28, 43, 25, 91, 14, 143, 89, 14, 78, 81, 63, 103, 37, 212, 0, 117, 31, 95, 66, 47, 79, 157, 141, 149, 112, 161, 38, 159, 104, 175, 65, 163, 75, 7, 166, 184, 203, 152, 30, 222, 74 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 48, 29, 215, 135, 173, 49, 210, 184, 34, 9, 116, 156, 20, 141, 248, 51, 20, 34, 249, 77, 90, 45, 204, 58, 50, 181, 75, 36, 7, 39, 80, 210, 155, 46, 215, 98, 161, 208, 75, 78, 68, 163, 52, 182, 209, 66, 25, 242, 213, 110, 50, 67, 8, 68, 230, 44, 2, 143, 240, 95, 169, 36, 45 }, new byte[] { 208, 103, 149, 135, 5, 157, 244, 243, 84, 188, 102, 248, 118, 187, 139, 91, 200, 12, 114, 110, 88, 92, 35, 157, 163, 142, 182, 76, 43, 65, 255, 48, 117, 21, 43, 26, 6, 89, 112, 253, 51, 112, 99, 44, 10, 235, 126, 157, 28, 222, 205, 219, 30, 229, 49, 91, 31, 36, 27, 33, 235, 33, 196, 7, 238, 163, 207, 189, 81, 16, 150, 216, 206, 73, 73, 0, 5, 175, 193, 47, 60, 49, 125, 98, 132, 7, 116, 28, 43, 25, 91, 14, 143, 89, 14, 78, 81, 63, 103, 37, 212, 0, 117, 31, 95, 66, 47, 79, 157, 141, 149, 112, 161, 38, 159, 104, 175, 65, 163, 75, 7, 166, 184, 203, 152, 30, 222, 74 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 48, 29, 215, 135, 173, 49, 210, 184, 34, 9, 116, 156, 20, 141, 248, 51, 20, 34, 249, 77, 90, 45, 204, 58, 50, 181, 75, 36, 7, 39, 80, 210, 155, 46, 215, 98, 161, 208, 75, 78, 68, 163, 52, 182, 209, 66, 25, 242, 213, 110, 50, 67, 8, 68, 230, 44, 2, 143, 240, 95, 169, 36, 45 }, new byte[] { 208, 103, 149, 135, 5, 157, 244, 243, 84, 188, 102, 248, 118, 187, 139, 91, 200, 12, 114, 110, 88, 92, 35, 157, 163, 142, 182, 76, 43, 65, 255, 48, 117, 21, 43, 26, 6, 89, 112, 253, 51, 112, 99, 44, 10, 235, 126, 157, 28, 222, 205, 219, 30, 229, 49, 91, 31, 36, 27, 33, 235, 33, 196, 7, 238, 163, 207, 189, 81, 16, 150, 216, 206, 73, 73, 0, 5, 175, 193, 47, 60, 49, 125, 98, 132, 7, 116, 28, 43, 25, 91, 14, 143, 89, 14, 78, 81, 63, 103, 37, 212, 0, 117, 31, 95, 66, 47, 79, 157, 141, 149, 112, 161, 38, 159, 104, 175, 65, 163, 75, 7, 166, 184, 203, 152, 30, 222, 74 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 48, 29, 215, 135, 173, 49, 210, 184, 34, 9, 116, 156, 20, 141, 248, 51, 20, 34, 249, 77, 90, 45, 204, 58, 50, 181, 75, 36, 7, 39, 80, 210, 155, 46, 215, 98, 161, 208, 75, 78, 68, 163, 52, 182, 209, 66, 25, 242, 213, 110, 50, 67, 8, 68, 230, 44, 2, 143, 240, 95, 169, 36, 45 }, new byte[] { 208, 103, 149, 135, 5, 157, 244, 243, 84, 188, 102, 248, 118, 187, 139, 91, 200, 12, 114, 110, 88, 92, 35, 157, 163, 142, 182, 76, 43, 65, 255, 48, 117, 21, 43, 26, 6, 89, 112, 253, 51, 112, 99, 44, 10, 235, 126, 157, 28, 222, 205, 219, 30, 229, 49, 91, 31, 36, 27, 33, 235, 33, 196, 7, 238, 163, 207, 189, 81, 16, 150, 216, 206, 73, 73, 0, 5, 175, 193, 47, 60, 49, 125, 98, 132, 7, 116, 28, 43, 25, 91, 14, 143, 89, 14, 78, 81, 63, 103, 37, 212, 0, 117, 31, 95, 66, 47, 79, 157, 141, 149, 112, 161, 38, 159, 104, 175, 65, 163, 75, 7, 166, 184, 203, 152, 30, 222, 74 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 48, 29, 215, 135, 173, 49, 210, 184, 34, 9, 116, 156, 20, 141, 248, 51, 20, 34, 249, 77, 90, 45, 204, 58, 50, 181, 75, 36, 7, 39, 80, 210, 155, 46, 215, 98, 161, 208, 75, 78, 68, 163, 52, 182, 209, 66, 25, 242, 213, 110, 50, 67, 8, 68, 230, 44, 2, 143, 240, 95, 169, 36, 45 }, new byte[] { 208, 103, 149, 135, 5, 157, 244, 243, 84, 188, 102, 248, 118, 187, 139, 91, 200, 12, 114, 110, 88, 92, 35, 157, 163, 142, 182, 76, 43, 65, 255, 48, 117, 21, 43, 26, 6, 89, 112, 253, 51, 112, 99, 44, 10, 235, 126, 157, 28, 222, 205, 219, 30, 229, 49, 91, 31, 36, 27, 33, 235, 33, 196, 7, 238, 163, 207, 189, 81, 16, 150, 216, 206, 73, 73, 0, 5, 175, 193, 47, 60, 49, 125, 98, 132, 7, 116, 28, 43, 25, 91, 14, 143, 89, 14, 78, 81, 63, 103, 37, 212, 0, 117, 31, 95, 66, 47, 79, 157, 141, 149, 112, 161, 38, 159, 104, 175, 65, 163, 75, 7, 166, 184, 203, 152, 30, 222, 74 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2024, 1, 7, 10, 2, 8, 603, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 184, 149, 9, 172, 56, 200, 20, 91, 138, 80, 154, 24, 23, 249, 92, 48, 93, 174, 183, 155, 191, 215, 86, 229, 53, 234, 69, 140, 199, 192, 48, 166, 151, 55, 160, 5, 0, 147, 182, 172, 116, 131, 99, 166, 206, 75, 46, 195, 183, 81, 38, 116, 182, 2, 62, 132, 36, 251, 228, 8, 83, 127, 117 }, new byte[] { 84, 170, 190, 154, 44, 68, 165, 241, 245, 173, 187, 104, 70, 55, 125, 49, 231, 158, 1, 89, 198, 58, 13, 199, 234, 83, 37, 67, 154, 42, 81, 119, 241, 38, 144, 124, 115, 162, 6, 219, 140, 165, 224, 2, 22, 171, 33, 49, 220, 177, 152, 159, 140, 66, 171, 145, 218, 216, 187, 137, 126, 183, 107, 148, 68, 171, 31, 39, 131, 83, 15, 152, 119, 54, 172, 209, 6, 88, 10, 19, 101, 170, 126, 32, 4, 25, 43, 12, 140, 71, 190, 174, 194, 144, 198, 159, 102, 76, 114, 52, 238, 0, 109, 249, 209, 239, 72, 117, 17, 90, 38, 245, 7, 196, 254, 21, 114, 95, 250, 108, 165, 29, 43, 251, 55, 70, 59, 12 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 184, 149, 9, 172, 56, 200, 20, 91, 138, 80, 154, 24, 23, 249, 92, 48, 93, 174, 183, 155, 191, 215, 86, 229, 53, 234, 69, 140, 199, 192, 48, 166, 151, 55, 160, 5, 0, 147, 182, 172, 116, 131, 99, 166, 206, 75, 46, 195, 183, 81, 38, 116, 182, 2, 62, 132, 36, 251, 228, 8, 83, 127, 117 }, new byte[] { 84, 170, 190, 154, 44, 68, 165, 241, 245, 173, 187, 104, 70, 55, 125, 49, 231, 158, 1, 89, 198, 58, 13, 199, 234, 83, 37, 67, 154, 42, 81, 119, 241, 38, 144, 124, 115, 162, 6, 219, 140, 165, 224, 2, 22, 171, 33, 49, 220, 177, 152, 159, 140, 66, 171, 145, 218, 216, 187, 137, 126, 183, 107, 148, 68, 171, 31, 39, 131, 83, 15, 152, 119, 54, 172, 209, 6, 88, 10, 19, 101, 170, 126, 32, 4, 25, 43, 12, 140, 71, 190, 174, 194, 144, 198, 159, 102, 76, 114, 52, 238, 0, 109, 249, 209, 239, 72, 117, 17, 90, 38, 245, 7, 196, 254, 21, 114, 95, 250, 108, 165, 29, 43, 251, 55, 70, 59, 12 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 184, 149, 9, 172, 56, 200, 20, 91, 138, 80, 154, 24, 23, 249, 92, 48, 93, 174, 183, 155, 191, 215, 86, 229, 53, 234, 69, 140, 199, 192, 48, 166, 151, 55, 160, 5, 0, 147, 182, 172, 116, 131, 99, 166, 206, 75, 46, 195, 183, 81, 38, 116, 182, 2, 62, 132, 36, 251, 228, 8, 83, 127, 117 }, new byte[] { 84, 170, 190, 154, 44, 68, 165, 241, 245, 173, 187, 104, 70, 55, 125, 49, 231, 158, 1, 89, 198, 58, 13, 199, 234, 83, 37, 67, 154, 42, 81, 119, 241, 38, 144, 124, 115, 162, 6, 219, 140, 165, 224, 2, 22, 171, 33, 49, 220, 177, 152, 159, 140, 66, 171, 145, 218, 216, 187, 137, 126, 183, 107, 148, 68, 171, 31, 39, 131, 83, 15, 152, 119, 54, 172, 209, 6, 88, 10, 19, 101, 170, 126, 32, 4, 25, 43, 12, 140, 71, 190, 174, 194, 144, 198, 159, 102, 76, 114, 52, 238, 0, 109, 249, 209, 239, 72, 117, 17, 90, 38, 245, 7, 196, 254, 21, 114, 95, 250, 108, 165, 29, 43, 251, 55, 70, 59, 12 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 184, 149, 9, 172, 56, 200, 20, 91, 138, 80, 154, 24, 23, 249, 92, 48, 93, 174, 183, 155, 191, 215, 86, 229, 53, 234, 69, 140, 199, 192, 48, 166, 151, 55, 160, 5, 0, 147, 182, 172, 116, 131, 99, 166, 206, 75, 46, 195, 183, 81, 38, 116, 182, 2, 62, 132, 36, 251, 228, 8, 83, 127, 117 }, new byte[] { 84, 170, 190, 154, 44, 68, 165, 241, 245, 173, 187, 104, 70, 55, 125, 49, 231, 158, 1, 89, 198, 58, 13, 199, 234, 83, 37, 67, 154, 42, 81, 119, 241, 38, 144, 124, 115, 162, 6, 219, 140, 165, 224, 2, 22, 171, 33, 49, 220, 177, 152, 159, 140, 66, 171, 145, 218, 216, 187, 137, 126, 183, 107, 148, 68, 171, 31, 39, 131, 83, 15, 152, 119, 54, 172, 209, 6, 88, 10, 19, 101, 170, 126, 32, 4, 25, 43, 12, 140, 71, 190, 174, 194, 144, 198, 159, 102, 76, 114, 52, 238, 0, 109, 249, 209, 239, 72, 117, 17, 90, 38, 245, 7, 196, 254, 21, 114, 95, 250, 108, 165, 29, 43, 251, 55, 70, 59, 12 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 184, 149, 9, 172, 56, 200, 20, 91, 138, 80, 154, 24, 23, 249, 92, 48, 93, 174, 183, 155, 191, 215, 86, 229, 53, 234, 69, 140, 199, 192, 48, 166, 151, 55, 160, 5, 0, 147, 182, 172, 116, 131, 99, 166, 206, 75, 46, 195, 183, 81, 38, 116, 182, 2, 62, 132, 36, 251, 228, 8, 83, 127, 117 }, new byte[] { 84, 170, 190, 154, 44, 68, 165, 241, 245, 173, 187, 104, 70, 55, 125, 49, 231, 158, 1, 89, 198, 58, 13, 199, 234, 83, 37, 67, 154, 42, 81, 119, 241, 38, 144, 124, 115, 162, 6, 219, 140, 165, 224, 2, 22, 171, 33, 49, 220, 177, 152, 159, 140, 66, 171, 145, 218, 216, 187, 137, 126, 183, 107, 148, 68, 171, 31, 39, 131, 83, 15, 152, 119, 54, 172, 209, 6, 88, 10, 19, 101, 170, 126, 32, 4, 25, 43, 12, 140, 71, 190, 174, 194, 144, 198, 159, 102, 76, 114, 52, 238, 0, 109, 249, 209, 239, 72, 117, 17, 90, 38, 245, 7, 196, 254, 21, 114, 95, 250, 108, 165, 29, 43, 251, 55, 70, 59, 12 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 184, 149, 9, 172, 56, 200, 20, 91, 138, 80, 154, 24, 23, 249, 92, 48, 93, 174, 183, 155, 191, 215, 86, 229, 53, 234, 69, 140, 199, 192, 48, 166, 151, 55, 160, 5, 0, 147, 182, 172, 116, 131, 99, 166, 206, 75, 46, 195, 183, 81, 38, 116, 182, 2, 62, 132, 36, 251, 228, 8, 83, 127, 117 }, new byte[] { 84, 170, 190, 154, 44, 68, 165, 241, 245, 173, 187, 104, 70, 55, 125, 49, 231, 158, 1, 89, 198, 58, 13, 199, 234, 83, 37, 67, 154, 42, 81, 119, 241, 38, 144, 124, 115, 162, 6, 219, 140, 165, 224, 2, 22, 171, 33, 49, 220, 177, 152, 159, 140, 66, 171, 145, 218, 216, 187, 137, 126, 183, 107, 148, 68, 171, 31, 39, 131, 83, 15, 152, 119, 54, 172, 209, 6, 88, 10, 19, 101, 170, 126, 32, 4, 25, 43, 12, 140, 71, 190, 174, 194, 144, 198, 159, 102, 76, 114, 52, 238, 0, 109, 249, 209, 239, 72, 117, 17, 90, 38, 245, 7, 196, 254, 21, 114, 95, 250, 108, 165, 29, 43, 251, 55, 70, 59, 12 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 184, 149, 9, 172, 56, 200, 20, 91, 138, 80, 154, 24, 23, 249, 92, 48, 93, 174, 183, 155, 191, 215, 86, 229, 53, 234, 69, 140, 199, 192, 48, 166, 151, 55, 160, 5, 0, 147, 182, 172, 116, 131, 99, 166, 206, 75, 46, 195, 183, 81, 38, 116, 182, 2, 62, 132, 36, 251, 228, 8, 83, 127, 117 }, new byte[] { 84, 170, 190, 154, 44, 68, 165, 241, 245, 173, 187, 104, 70, 55, 125, 49, 231, 158, 1, 89, 198, 58, 13, 199, 234, 83, 37, 67, 154, 42, 81, 119, 241, 38, 144, 124, 115, 162, 6, 219, 140, 165, 224, 2, 22, 171, 33, 49, 220, 177, 152, 159, 140, 66, 171, 145, 218, 216, 187, 137, 126, 183, 107, 148, 68, 171, 31, 39, 131, 83, 15, 152, 119, 54, 172, 209, 6, 88, 10, 19, 101, 170, 126, 32, 4, 25, 43, 12, 140, 71, 190, 174, 194, 144, 198, 159, 102, 76, 114, 52, 238, 0, 109, 249, 209, 239, 72, 117, 17, 90, 38, 245, 7, 196, 254, 21, 114, 95, 250, 108, 165, 29, 43, 251, 55, 70, 59, 12 } });
        }
    }
}
