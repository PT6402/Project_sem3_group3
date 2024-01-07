using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Data_helper.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tbEmployee",
                keyColumn: "Id",
                keyValue: 4,
                column: "User_Id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "tbEmployee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address_store_Id", "User_Id" },
                values: new object[] { 3, 6 });

            migrationBuilder.InsertData(
                table: "tbEmployee",
                columns: new[] { "Id", "Address_store_Id", "Employee_type_Id", "User_Id" },
                values: new object[,]
                {
                    { 3, 2, 1, 5 },
                    { 6, 3, 2, 9 },
                    { 7, 4, 1, 7 },
                    { 8, 4, 2, 10 }
                });

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.InsertData(
                table: "tbImportReceipt",
                columns: new[] { "Id", "Product_Id", "Quantity", "Status", "Storage_id", "Time" },
                values: new object[,]
                {
                    { 19, 1, 10, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9372) },
                    { 20, 2, 15, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9373) },
                    { 21, 3, 20, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9374) },
                    { 22, 4, 30, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9375) },
                    { 23, 5, 10, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9376) },
                    { 24, 6, 15, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9377) },
                    { 25, 7, 20, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9378) },
                    { 26, 8, 30, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9379) },
                    { 27, 9, 10, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9380) },
                    { 28, 10, 15, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9381) },
                    { 29, 11, 20, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9382) },
                    { 30, 12, 30, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9383) },
                    { 31, 13, 10, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9384) },
                    { 32, 14, 15, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9385) },
                    { 33, 15, 20, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9386) },
                    { 34, 16, 30, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9387) },
                    { 35, 17, 15, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9388) },
                    { 36, 18, 20, "Done", 2, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9389) },
                    { 37, 1, 10, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9390) },
                    { 38, 2, 15, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9391) },
                    { 39, 3, 20, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9392) },
                    { 40, 4, 30, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9393) },
                    { 41, 5, 10, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9394) },
                    { 42, 6, 15, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9395) },
                    { 43, 7, 20, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9396) },
                    { 44, 8, 30, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9397) },
                    { 45, 9, 10, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9398) },
                    { 46, 10, 15, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9399) },
                    { 47, 11, 20, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9400) },
                    { 48, 12, 30, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9401) },
                    { 49, 13, 10, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9402) },
                    { 50, 14, 15, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9403) },
                    { 51, 15, 20, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9404) },
                    { 52, 16, 30, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9405) },
                    { 53, 17, 15, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9406) },
                    { 54, 18, 20, "Done", 3, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9407) },
                    { 55, 1, 10, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9408) },
                    { 56, 2, 15, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9409) },
                    { 57, 3, 20, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9410) },
                    { 58, 4, 30, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9411) },
                    { 59, 5, 10, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9412) },
                    { 60, 6, 15, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9413) },
                    { 61, 7, 20, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9414) },
                    { 62, 8, 30, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9415) },
                    { 63, 9, 10, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9416) },
                    { 64, 10, 15, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9417) },
                    { 65, 11, 20, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9418) },
                    { 66, 12, 30, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9419) },
                    { 67, 13, 10, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9420) },
                    { 68, 14, 15, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9421) },
                    { 69, 15, 20, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9422) },
                    { 70, 16, 30, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9423) },
                    { 71, 17, 15, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9424) },
                    { 72, 18, 20, "Done", 4, new DateTime(2024, 1, 7, 14, 47, 26, 190, DateTimeKind.Local).AddTicks(9425) }
                });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 88, 60, 184, 139, 43, 170, 232, 235, 63, 101, 254, 66, 47, 168, 44, 61, 209, 137, 107, 148, 226, 106, 71, 52, 220, 208, 128, 12, 135, 129, 233, 180, 9, 16, 35, 8, 75, 249, 45, 12, 180, 162, 29, 188, 67, 115, 164, 243, 250, 176, 36, 229, 126, 130, 124, 37, 197, 152, 44, 48, 187, 227, 103, 194 }, new byte[] { 92, 52, 81, 112, 12, 183, 181, 10, 227, 21, 156, 1, 5, 235, 210, 164, 252, 145, 10, 245, 238, 247, 80, 17, 239, 67, 209, 226, 229, 83, 160, 67, 154, 226, 232, 222, 117, 184, 194, 148, 14, 176, 3, 194, 73, 65, 106, 19, 197, 165, 119, 0, 53, 249, 197, 6, 139, 214, 231, 213, 254, 44, 77, 219, 56, 234, 55, 72, 250, 233, 122, 20, 60, 143, 50, 48, 58, 66, 210, 113, 210, 117, 111, 252, 159, 53, 114, 166, 36, 176, 137, 98, 47, 148, 139, 132, 94, 103, 69, 16, 209, 150, 68, 12, 108, 87, 15, 179, 125, 106, 164, 246, 158, 58, 230, 216, 200, 154, 234, 50, 155, 165, 22, 198, 240, 123, 129, 103 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 88, 60, 184, 139, 43, 170, 232, 235, 63, 101, 254, 66, 47, 168, 44, 61, 209, 137, 107, 148, 226, 106, 71, 52, 220, 208, 128, 12, 135, 129, 233, 180, 9, 16, 35, 8, 75, 249, 45, 12, 180, 162, 29, 188, 67, 115, 164, 243, 250, 176, 36, 229, 126, 130, 124, 37, 197, 152, 44, 48, 187, 227, 103, 194 }, new byte[] { 92, 52, 81, 112, 12, 183, 181, 10, 227, 21, 156, 1, 5, 235, 210, 164, 252, 145, 10, 245, 238, 247, 80, 17, 239, 67, 209, 226, 229, 83, 160, 67, 154, 226, 232, 222, 117, 184, 194, 148, 14, 176, 3, 194, 73, 65, 106, 19, 197, 165, 119, 0, 53, 249, 197, 6, 139, 214, 231, 213, 254, 44, 77, 219, 56, 234, 55, 72, 250, 233, 122, 20, 60, 143, 50, 48, 58, 66, 210, 113, 210, 117, 111, 252, 159, 53, 114, 166, 36, 176, 137, 98, 47, 148, 139, 132, 94, 103, 69, 16, 209, 150, 68, 12, 108, 87, 15, 179, 125, 106, 164, 246, 158, 58, 230, 216, 200, 154, 234, 50, 155, 165, 22, 198, 240, 123, 129, 103 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 88, 60, 184, 139, 43, 170, 232, 235, 63, 101, 254, 66, 47, 168, 44, 61, 209, 137, 107, 148, 226, 106, 71, 52, 220, 208, 128, 12, 135, 129, 233, 180, 9, 16, 35, 8, 75, 249, 45, 12, 180, 162, 29, 188, 67, 115, 164, 243, 250, 176, 36, 229, 126, 130, 124, 37, 197, 152, 44, 48, 187, 227, 103, 194 }, new byte[] { 92, 52, 81, 112, 12, 183, 181, 10, 227, 21, 156, 1, 5, 235, 210, 164, 252, 145, 10, 245, 238, 247, 80, 17, 239, 67, 209, 226, 229, 83, 160, 67, 154, 226, 232, 222, 117, 184, 194, 148, 14, 176, 3, 194, 73, 65, 106, 19, 197, 165, 119, 0, 53, 249, 197, 6, 139, 214, 231, 213, 254, 44, 77, 219, 56, 234, 55, 72, 250, 233, 122, 20, 60, 143, 50, 48, 58, 66, 210, 113, 210, 117, 111, 252, 159, 53, 114, 166, 36, 176, 137, 98, 47, 148, 139, 132, 94, 103, 69, 16, 209, 150, 68, 12, 108, 87, 15, 179, 125, 106, 164, 246, 158, 58, 230, 216, 200, 154, 234, 50, 155, 165, 22, 198, 240, 123, 129, 103 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 88, 60, 184, 139, 43, 170, 232, 235, 63, 101, 254, 66, 47, 168, 44, 61, 209, 137, 107, 148, 226, 106, 71, 52, 220, 208, 128, 12, 135, 129, 233, 180, 9, 16, 35, 8, 75, 249, 45, 12, 180, 162, 29, 188, 67, 115, 164, 243, 250, 176, 36, 229, 126, 130, 124, 37, 197, 152, 44, 48, 187, 227, 103, 194 }, new byte[] { 92, 52, 81, 112, 12, 183, 181, 10, 227, 21, 156, 1, 5, 235, 210, 164, 252, 145, 10, 245, 238, 247, 80, 17, 239, 67, 209, 226, 229, 83, 160, 67, 154, 226, 232, 222, 117, 184, 194, 148, 14, 176, 3, 194, 73, 65, 106, 19, 197, 165, 119, 0, 53, 249, 197, 6, 139, 214, 231, 213, 254, 44, 77, 219, 56, 234, 55, 72, 250, 233, 122, 20, 60, 143, 50, 48, 58, 66, 210, 113, 210, 117, 111, 252, 159, 53, 114, 166, 36, 176, 137, 98, 47, 148, 139, 132, 94, 103, 69, 16, 209, 150, 68, 12, 108, 87, 15, 179, 125, 106, 164, 246, 158, 58, 230, 216, 200, 154, 234, 50, 155, 165, 22, 198, 240, 123, 129, 103 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt", "Role" },
                values: new object[] { new byte[] { 88, 60, 184, 139, 43, 170, 232, 235, 63, 101, 254, 66, 47, 168, 44, 61, 209, 137, 107, 148, 226, 106, 71, 52, 220, 208, 128, 12, 135, 129, 233, 180, 9, 16, 35, 8, 75, 249, 45, 12, 180, 162, 29, 188, 67, 115, 164, 243, 250, 176, 36, 229, 126, 130, 124, 37, 197, 152, 44, 48, 187, 227, 103, 194 }, new byte[] { 92, 52, 81, 112, 12, 183, 181, 10, 227, 21, 156, 1, 5, 235, 210, 164, 252, 145, 10, 245, 238, 247, 80, 17, 239, 67, 209, 226, 229, 83, 160, 67, 154, 226, 232, 222, 117, 184, 194, 148, 14, 176, 3, 194, 73, 65, 106, 19, 197, 165, 119, 0, 53, 249, 197, 6, 139, 214, 231, 213, 254, 44, 77, 219, 56, 234, 55, 72, 250, 233, 122, 20, 60, 143, 50, 48, 58, 66, 210, 113, 210, 117, 111, 252, 159, 53, 114, 166, 36, 176, 137, 98, 47, 148, 139, 132, 94, 103, 69, 16, 209, 150, 68, 12, 108, 87, 15, 179, 125, 106, 164, 246, 158, 58, 230, 216, 200, 154, 234, 50, 155, 165, 22, 198, 240, 123, 129, 103 }, "sale" });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt", "Role" },
                values: new object[] { new byte[] { 88, 60, 184, 139, 43, 170, 232, 235, 63, 101, 254, 66, 47, 168, 44, 61, 209, 137, 107, 148, 226, 106, 71, 52, 220, 208, 128, 12, 135, 129, 233, 180, 9, 16, 35, 8, 75, 249, 45, 12, 180, 162, 29, 188, 67, 115, 164, 243, 250, 176, 36, 229, 126, 130, 124, 37, 197, 152, 44, 48, 187, 227, 103, 194 }, new byte[] { 92, 52, 81, 112, 12, 183, 181, 10, 227, 21, 156, 1, 5, 235, 210, 164, 252, 145, 10, 245, 238, 247, 80, 17, 239, 67, 209, 226, 229, 83, 160, 67, 154, 226, 232, 222, 117, 184, 194, 148, 14, 176, 3, 194, 73, 65, 106, 19, 197, 165, 119, 0, 53, 249, 197, 6, 139, 214, 231, 213, 254, 44, 77, 219, 56, 234, 55, 72, 250, 233, 122, 20, 60, 143, 50, 48, 58, 66, 210, 113, 210, 117, 111, 252, 159, 53, 114, 166, 36, 176, 137, 98, 47, 148, 139, 132, 94, 103, 69, 16, 209, 150, 68, 12, 108, 87, 15, 179, 125, 106, 164, 246, 158, 58, 230, 216, 200, 154, 234, 50, 155, 165, 22, 198, 240, 123, 129, 103 }, "sale" });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt", "Role" },
                values: new object[] { new byte[] { 88, 60, 184, 139, 43, 170, 232, 235, 63, 101, 254, 66, 47, 168, 44, 61, 209, 137, 107, 148, 226, 106, 71, 52, 220, 208, 128, 12, 135, 129, 233, 180, 9, 16, 35, 8, 75, 249, 45, 12, 180, 162, 29, 188, 67, 115, 164, 243, 250, 176, 36, 229, 126, 130, 124, 37, 197, 152, 44, 48, 187, 227, 103, 194 }, new byte[] { 92, 52, 81, 112, 12, 183, 181, 10, 227, 21, 156, 1, 5, 235, 210, 164, 252, 145, 10, 245, 238, 247, 80, 17, 239, 67, 209, 226, 229, 83, 160, 67, 154, 226, 232, 222, 117, 184, 194, 148, 14, 176, 3, 194, 73, 65, 106, 19, 197, 165, 119, 0, 53, 249, 197, 6, 139, 214, 231, 213, 254, 44, 77, 219, 56, 234, 55, 72, 250, 233, 122, 20, 60, 143, 50, 48, 58, 66, 210, 113, 210, 117, 111, 252, 159, 53, 114, 166, 36, 176, 137, 98, 47, 148, 139, 132, 94, 103, 69, 16, 209, 150, 68, 12, 108, 87, 15, 179, 125, 106, 164, 246, 158, 58, 230, 216, 200, 154, 234, 50, 155, 165, 22, 198, 240, 123, 129, 103 }, "sale" });

            migrationBuilder.InsertData(
                table: "tbUser",
                columns: new[] { "Id", "Email", "Employees_Id", "FullName", "MethodReset", "PasswordHash", "PasswordReset", "PasswordSalt", "Phone", "RefreshToken", "ResetExpires", "Role", "TP_contract_Id", "TokenCreated", "TokenExpires" },
                values: new object[,]
                {
                    { 8, null, null, "Nguyen Van D", null, new byte[] { 88, 60, 184, 139, 43, 170, 232, 235, 63, 101, 254, 66, 47, 168, 44, 61, 209, 137, 107, 148, 226, 106, 71, 52, 220, 208, 128, 12, 135, 129, 233, 180, 9, 16, 35, 8, 75, 249, 45, 12, 180, 162, 29, 188, 67, 115, 164, 243, 250, 176, 36, 229, 126, 130, 124, 37, 197, 152, 44, 48, 187, 227, 103, 194 }, null, new byte[] { 92, 52, 81, 112, 12, 183, 181, 10, 227, 21, 156, 1, 5, 235, 210, 164, 252, 145, 10, 245, 238, 247, 80, 17, 239, 67, 209, 226, 229, 83, 160, 67, 154, 226, 232, 222, 117, 184, 194, 148, 14, 176, 3, 194, 73, 65, 106, 19, 197, 165, 119, 0, 53, 249, 197, 6, 139, 214, 231, 213, 254, 44, 77, 219, 56, 234, 55, 72, 250, 233, 122, 20, 60, 143, 50, 48, 58, 66, 210, 113, 210, 117, 111, 252, 159, 53, 114, 166, 36, 176, 137, 98, 47, 148, 139, 132, 94, 103, 69, 16, 209, 150, 68, 12, 108, 87, 15, 179, 125, 106, 164, 246, 158, 58, 230, 216, 200, 154, 234, 50, 155, 165, 22, 198, 240, 123, 129, 103 }, "0689434167", "", null, "Technical", null, null, null },
                    { 9, null, null, "Nguyen Van E", null, new byte[] { 88, 60, 184, 139, 43, 170, 232, 235, 63, 101, 254, 66, 47, 168, 44, 61, 209, 137, 107, 148, 226, 106, 71, 52, 220, 208, 128, 12, 135, 129, 233, 180, 9, 16, 35, 8, 75, 249, 45, 12, 180, 162, 29, 188, 67, 115, 164, 243, 250, 176, 36, 229, 126, 130, 124, 37, 197, 152, 44, 48, 187, 227, 103, 194 }, null, new byte[] { 92, 52, 81, 112, 12, 183, 181, 10, 227, 21, 156, 1, 5, 235, 210, 164, 252, 145, 10, 245, 238, 247, 80, 17, 239, 67, 209, 226, 229, 83, 160, 67, 154, 226, 232, 222, 117, 184, 194, 148, 14, 176, 3, 194, 73, 65, 106, 19, 197, 165, 119, 0, 53, 249, 197, 6, 139, 214, 231, 213, 254, 44, 77, 219, 56, 234, 55, 72, 250, 233, 122, 20, 60, 143, 50, 48, 58, 66, 210, 113, 210, 117, 111, 252, 159, 53, 114, 166, 36, 176, 137, 98, 47, 148, 139, 132, 94, 103, 69, 16, 209, 150, 68, 12, 108, 87, 15, 179, 125, 106, 164, 246, 158, 58, 230, 216, 200, 154, 234, 50, 155, 165, 22, 198, 240, 123, 129, 103 }, "0689764139", "", null, "Technical", null, null, null },
                    { 10, null, null, "Nguyen Van F", null, new byte[] { 88, 60, 184, 139, 43, 170, 232, 235, 63, 101, 254, 66, 47, 168, 44, 61, 209, 137, 107, 148, 226, 106, 71, 52, 220, 208, 128, 12, 135, 129, 233, 180, 9, 16, 35, 8, 75, 249, 45, 12, 180, 162, 29, 188, 67, 115, 164, 243, 250, 176, 36, 229, 126, 130, 124, 37, 197, 152, 44, 48, 187, 227, 103, 194 }, null, new byte[] { 92, 52, 81, 112, 12, 183, 181, 10, 227, 21, 156, 1, 5, 235, 210, 164, 252, 145, 10, 245, 238, 247, 80, 17, 239, 67, 209, 226, 229, 83, 160, 67, 154, 226, 232, 222, 117, 184, 194, 148, 14, 176, 3, 194, 73, 65, 106, 19, 197, 165, 119, 0, 53, 249, 197, 6, 139, 214, 231, 213, 254, 44, 77, 219, 56, 234, 55, 72, 250, 233, 122, 20, 60, 143, 50, 48, 58, 66, 210, 113, 210, 117, 111, 252, 159, 53, 114, 166, 36, 176, 137, 98, 47, 148, 139, 132, 94, 103, 69, 16, 209, 150, 68, 12, 108, 87, 15, 179, 125, 106, 164, 246, 158, 58, 230, 216, 200, 154, 234, 50, 155, 165, 22, 198, 240, 123, 129, 103 }, "0329764195", "", null, "Technical", null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbEmployee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tbEmployee",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tbEmployee",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "tbEmployee",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "tbEmployee",
                keyColumn: "Id",
                keyValue: 4,
                column: "User_Id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "tbEmployee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address_store_Id", "User_Id" },
                values: new object[] { 2, 7 });

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
                columns: new[] { "PasswordHash", "PasswordSalt", "Role" },
                values: new object[] { new byte[] { 5, 48, 29, 215, 135, 173, 49, 210, 184, 34, 9, 116, 156, 20, 141, 248, 51, 20, 34, 249, 77, 90, 45, 204, 58, 50, 181, 75, 36, 7, 39, 80, 210, 155, 46, 215, 98, 161, 208, 75, 78, 68, 163, 52, 182, 209, 66, 25, 242, 213, 110, 50, 67, 8, 68, 230, 44, 2, 143, 240, 95, 169, 36, 45 }, new byte[] { 208, 103, 149, 135, 5, 157, 244, 243, 84, 188, 102, 248, 118, 187, 139, 91, 200, 12, 114, 110, 88, 92, 35, 157, 163, 142, 182, 76, 43, 65, 255, 48, 117, 21, 43, 26, 6, 89, 112, 253, 51, 112, 99, 44, 10, 235, 126, 157, 28, 222, 205, 219, 30, 229, 49, 91, 31, 36, 27, 33, 235, 33, 196, 7, 238, 163, 207, 189, 81, 16, 150, 216, 206, 73, 73, 0, 5, 175, 193, 47, 60, 49, 125, 98, 132, 7, 116, 28, 43, 25, 91, 14, 143, 89, 14, 78, 81, 63, 103, 37, 212, 0, 117, 31, 95, 66, 47, 79, 157, 141, 149, 112, 161, 38, 159, 104, 175, 65, 163, 75, 7, 166, 184, 203, 152, 30, 222, 74 }, "Accountant" });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt", "Role" },
                values: new object[] { new byte[] { 5, 48, 29, 215, 135, 173, 49, 210, 184, 34, 9, 116, 156, 20, 141, 248, 51, 20, 34, 249, 77, 90, 45, 204, 58, 50, 181, 75, 36, 7, 39, 80, 210, 155, 46, 215, 98, 161, 208, 75, 78, 68, 163, 52, 182, 209, 66, 25, 242, 213, 110, 50, 67, 8, 68, 230, 44, 2, 143, 240, 95, 169, 36, 45 }, new byte[] { 208, 103, 149, 135, 5, 157, 244, 243, 84, 188, 102, 248, 118, 187, 139, 91, 200, 12, 114, 110, 88, 92, 35, 157, 163, 142, 182, 76, 43, 65, 255, 48, 117, 21, 43, 26, 6, 89, 112, 253, 51, 112, 99, 44, 10, 235, 126, 157, 28, 222, 205, 219, 30, 229, 49, 91, 31, 36, 27, 33, 235, 33, 196, 7, 238, 163, 207, 189, 81, 16, 150, 216, 206, 73, 73, 0, 5, 175, 193, 47, 60, 49, 125, 98, 132, 7, 116, 28, 43, 25, 91, 14, 143, 89, 14, 78, 81, 63, 103, 37, 212, 0, 117, 31, 95, 66, 47, 79, 157, 141, 149, 112, 161, 38, 159, 104, 175, 65, 163, 75, 7, 166, 184, 203, 152, 30, 222, 74 }, "user" });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt", "Role" },
                values: new object[] { new byte[] { 5, 48, 29, 215, 135, 173, 49, 210, 184, 34, 9, 116, 156, 20, 141, 248, 51, 20, 34, 249, 77, 90, 45, 204, 58, 50, 181, 75, 36, 7, 39, 80, 210, 155, 46, 215, 98, 161, 208, 75, 78, 68, 163, 52, 182, 209, 66, 25, 242, 213, 110, 50, 67, 8, 68, 230, 44, 2, 143, 240, 95, 169, 36, 45 }, new byte[] { 208, 103, 149, 135, 5, 157, 244, 243, 84, 188, 102, 248, 118, 187, 139, 91, 200, 12, 114, 110, 88, 92, 35, 157, 163, 142, 182, 76, 43, 65, 255, 48, 117, 21, 43, 26, 6, 89, 112, 253, 51, 112, 99, 44, 10, 235, 126, 157, 28, 222, 205, 219, 30, 229, 49, 91, 31, 36, 27, 33, 235, 33, 196, 7, 238, 163, 207, 189, 81, 16, 150, 216, 206, 73, 73, 0, 5, 175, 193, 47, 60, 49, 125, 98, 132, 7, 116, 28, 43, 25, 91, 14, 143, 89, 14, 78, 81, 63, 103, 37, 212, 0, 117, 31, 95, 66, 47, 79, 157, 141, 149, 112, 161, 38, 159, 104, 175, 65, 163, 75, 7, 166, 184, 203, 152, 30, 222, 74 }, "user" });
        }
    }
}
