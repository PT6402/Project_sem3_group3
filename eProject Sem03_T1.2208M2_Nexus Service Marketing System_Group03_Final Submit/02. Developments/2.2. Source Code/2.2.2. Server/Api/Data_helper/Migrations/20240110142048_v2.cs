using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Data_helper.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tbAddress",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address_full", "District_code", "Phone_code", "Province_code", "Ward_code" },
                values: new object[] { "Ngõ 93, đường Hồ Tùng Mậu, phường Mai Dịch, Quận Cầu Giấy", "5", "24", "1", "163" });

            migrationBuilder.UpdateData(
                table: "tbAddress",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address_full", "District_code", "Phone_code", "Province_code", "Ward_code" },
                values: new object[] { "số 1 Cao Thắng, phương Thanh Bình, Quận Hải Châu", "492", "236", "48", "20227" });

            migrationBuilder.UpdateData(
                table: "tbAddress",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address_full", "District_code", "Phone_code", "Province_code", "Ward_code" },
                values: new object[] { "33 Nguyễn Ảnh Thủ, xã Bà Điểm, huyện Hóc Môn", "784", "28", "79", "27592" });

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 186, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 186, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 186, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 186, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 186, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 186, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 186, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 186, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 186, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 26,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 27,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 28,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 29,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 30,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 31,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 32,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 33,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 34,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 35,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 36,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 37,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 38,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 39,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 40,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 41,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 42,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 43,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 44,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 45,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 46,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 47,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 48,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 49,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 50,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 51,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 52,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 53,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 54,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 55,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 56,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 57,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 58,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 59,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 60,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 61,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 62,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 63,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 64,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 65,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 66,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 67,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 68,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 69,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 70,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 71,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "tbImportReceipt",
                keyColumn: "Id",
                keyValue: 72,
                column: "Time",
                value: new DateTime(2024, 1, 10, 21, 20, 47, 200, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 174, 146, 151, 45, 181, 88, 140, 140, 181, 226, 0, 62, 12, 68, 180, 105, 212, 28, 175, 215, 46, 184, 48, 234, 1, 131, 227, 132, 123, 32, 106, 246, 4, 116, 38, 252, 66, 35, 165, 249, 46, 50, 157, 149, 85, 108, 230, 187, 173, 211, 79, 150, 127, 156, 236, 82, 51, 99, 193, 212, 89, 75, 226 }, new byte[] { 175, 136, 41, 250, 218, 88, 104, 181, 96, 208, 143, 244, 23, 76, 103, 124, 226, 193, 146, 61, 12, 81, 191, 145, 171, 66, 73, 53, 43, 93, 200, 104, 196, 77, 100, 29, 150, 203, 135, 1, 15, 36, 210, 72, 33, 207, 184, 119, 58, 141, 231, 212, 230, 225, 211, 185, 130, 112, 244, 63, 71, 230, 204, 238, 220, 243, 52, 75, 118, 183, 223, 237, 103, 22, 87, 208, 26, 131, 82, 167, 151, 55, 100, 117, 156, 21, 251, 130, 120, 46, 152, 122, 223, 112, 253, 154, 168, 50, 124, 249, 106, 141, 150, 19, 138, 111, 107, 255, 107, 45, 187, 243, 155, 145, 2, 41, 249, 149, 223, 77, 75, 109, 161, 230, 172, 173, 52, 246 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 174, 146, 151, 45, 181, 88, 140, 140, 181, 226, 0, 62, 12, 68, 180, 105, 212, 28, 175, 215, 46, 184, 48, 234, 1, 131, 227, 132, 123, 32, 106, 246, 4, 116, 38, 252, 66, 35, 165, 249, 46, 50, 157, 149, 85, 108, 230, 187, 173, 211, 79, 150, 127, 156, 236, 82, 51, 99, 193, 212, 89, 75, 226 }, new byte[] { 175, 136, 41, 250, 218, 88, 104, 181, 96, 208, 143, 244, 23, 76, 103, 124, 226, 193, 146, 61, 12, 81, 191, 145, 171, 66, 73, 53, 43, 93, 200, 104, 196, 77, 100, 29, 150, 203, 135, 1, 15, 36, 210, 72, 33, 207, 184, 119, 58, 141, 231, 212, 230, 225, 211, 185, 130, 112, 244, 63, 71, 230, 204, 238, 220, 243, 52, 75, 118, 183, 223, 237, 103, 22, 87, 208, 26, 131, 82, 167, 151, 55, 100, 117, 156, 21, 251, 130, 120, 46, 152, 122, 223, 112, 253, 154, 168, 50, 124, 249, 106, 141, 150, 19, 138, 111, 107, 255, 107, 45, 187, 243, 155, 145, 2, 41, 249, 149, 223, 77, 75, 109, 161, 230, 172, 173, 52, 246 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 174, 146, 151, 45, 181, 88, 140, 140, 181, 226, 0, 62, 12, 68, 180, 105, 212, 28, 175, 215, 46, 184, 48, 234, 1, 131, 227, 132, 123, 32, 106, 246, 4, 116, 38, 252, 66, 35, 165, 249, 46, 50, 157, 149, 85, 108, 230, 187, 173, 211, 79, 150, 127, 156, 236, 82, 51, 99, 193, 212, 89, 75, 226 }, new byte[] { 175, 136, 41, 250, 218, 88, 104, 181, 96, 208, 143, 244, 23, 76, 103, 124, 226, 193, 146, 61, 12, 81, 191, 145, 171, 66, 73, 53, 43, 93, 200, 104, 196, 77, 100, 29, 150, 203, 135, 1, 15, 36, 210, 72, 33, 207, 184, 119, 58, 141, 231, 212, 230, 225, 211, 185, 130, 112, 244, 63, 71, 230, 204, 238, 220, 243, 52, 75, 118, 183, 223, 237, 103, 22, 87, 208, 26, 131, 82, 167, 151, 55, 100, 117, 156, 21, 251, 130, 120, 46, 152, 122, 223, 112, 253, 154, 168, 50, 124, 249, 106, 141, 150, 19, 138, 111, 107, 255, 107, 45, 187, 243, 155, 145, 2, 41, 249, 149, 223, 77, 75, 109, 161, 230, 172, 173, 52, 246 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 174, 146, 151, 45, 181, 88, 140, 140, 181, 226, 0, 62, 12, 68, 180, 105, 212, 28, 175, 215, 46, 184, 48, 234, 1, 131, 227, 132, 123, 32, 106, 246, 4, 116, 38, 252, 66, 35, 165, 249, 46, 50, 157, 149, 85, 108, 230, 187, 173, 211, 79, 150, 127, 156, 236, 82, 51, 99, 193, 212, 89, 75, 226 }, new byte[] { 175, 136, 41, 250, 218, 88, 104, 181, 96, 208, 143, 244, 23, 76, 103, 124, 226, 193, 146, 61, 12, 81, 191, 145, 171, 66, 73, 53, 43, 93, 200, 104, 196, 77, 100, 29, 150, 203, 135, 1, 15, 36, 210, 72, 33, 207, 184, 119, 58, 141, 231, 212, 230, 225, 211, 185, 130, 112, 244, 63, 71, 230, 204, 238, 220, 243, 52, 75, 118, 183, 223, 237, 103, 22, 87, 208, 26, 131, 82, 167, 151, 55, 100, 117, 156, 21, 251, 130, 120, 46, 152, 122, 223, 112, 253, 154, 168, 50, 124, 249, 106, 141, 150, 19, 138, 111, 107, 255, 107, 45, 187, 243, 155, 145, 2, 41, 249, 149, 223, 77, 75, 109, 161, 230, 172, 173, 52, 246 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 174, 146, 151, 45, 181, 88, 140, 140, 181, 226, 0, 62, 12, 68, 180, 105, 212, 28, 175, 215, 46, 184, 48, 234, 1, 131, 227, 132, 123, 32, 106, 246, 4, 116, 38, 252, 66, 35, 165, 249, 46, 50, 157, 149, 85, 108, 230, 187, 173, 211, 79, 150, 127, 156, 236, 82, 51, 99, 193, 212, 89, 75, 226 }, new byte[] { 175, 136, 41, 250, 218, 88, 104, 181, 96, 208, 143, 244, 23, 76, 103, 124, 226, 193, 146, 61, 12, 81, 191, 145, 171, 66, 73, 53, 43, 93, 200, 104, 196, 77, 100, 29, 150, 203, 135, 1, 15, 36, 210, 72, 33, 207, 184, 119, 58, 141, 231, 212, 230, 225, 211, 185, 130, 112, 244, 63, 71, 230, 204, 238, 220, 243, 52, 75, 118, 183, 223, 237, 103, 22, 87, 208, 26, 131, 82, 167, 151, 55, 100, 117, 156, 21, 251, 130, 120, 46, 152, 122, 223, 112, 253, 154, 168, 50, 124, 249, 106, 141, 150, 19, 138, 111, 107, 255, 107, 45, 187, 243, 155, 145, 2, 41, 249, 149, 223, 77, 75, 109, 161, 230, 172, 173, 52, 246 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 174, 146, 151, 45, 181, 88, 140, 140, 181, 226, 0, 62, 12, 68, 180, 105, 212, 28, 175, 215, 46, 184, 48, 234, 1, 131, 227, 132, 123, 32, 106, 246, 4, 116, 38, 252, 66, 35, 165, 249, 46, 50, 157, 149, 85, 108, 230, 187, 173, 211, 79, 150, 127, 156, 236, 82, 51, 99, 193, 212, 89, 75, 226 }, new byte[] { 175, 136, 41, 250, 218, 88, 104, 181, 96, 208, 143, 244, 23, 76, 103, 124, 226, 193, 146, 61, 12, 81, 191, 145, 171, 66, 73, 53, 43, 93, 200, 104, 196, 77, 100, 29, 150, 203, 135, 1, 15, 36, 210, 72, 33, 207, 184, 119, 58, 141, 231, 212, 230, 225, 211, 185, 130, 112, 244, 63, 71, 230, 204, 238, 220, 243, 52, 75, 118, 183, 223, 237, 103, 22, 87, 208, 26, 131, 82, 167, 151, 55, 100, 117, 156, 21, 251, 130, 120, 46, 152, 122, 223, 112, 253, 154, 168, 50, 124, 249, 106, 141, 150, 19, 138, 111, 107, 255, 107, 45, 187, 243, 155, 145, 2, 41, 249, 149, 223, 77, 75, 109, 161, 230, 172, 173, 52, 246 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 174, 146, 151, 45, 181, 88, 140, 140, 181, 226, 0, 62, 12, 68, 180, 105, 212, 28, 175, 215, 46, 184, 48, 234, 1, 131, 227, 132, 123, 32, 106, 246, 4, 116, 38, 252, 66, 35, 165, 249, 46, 50, 157, 149, 85, 108, 230, 187, 173, 211, 79, 150, 127, 156, 236, 82, 51, 99, 193, 212, 89, 75, 226 }, new byte[] { 175, 136, 41, 250, 218, 88, 104, 181, 96, 208, 143, 244, 23, 76, 103, 124, 226, 193, 146, 61, 12, 81, 191, 145, 171, 66, 73, 53, 43, 93, 200, 104, 196, 77, 100, 29, 150, 203, 135, 1, 15, 36, 210, 72, 33, 207, 184, 119, 58, 141, 231, 212, 230, 225, 211, 185, 130, 112, 244, 63, 71, 230, 204, 238, 220, 243, 52, 75, 118, 183, 223, 237, 103, 22, 87, 208, 26, 131, 82, 167, 151, 55, 100, 117, 156, 21, 251, 130, 120, 46, 152, 122, 223, 112, 253, 154, 168, 50, 124, 249, 106, 141, 150, 19, 138, 111, 107, 255, 107, 45, 187, 243, 155, 145, 2, 41, 249, 149, 223, 77, 75, 109, 161, 230, 172, 173, 52, 246 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 174, 146, 151, 45, 181, 88, 140, 140, 181, 226, 0, 62, 12, 68, 180, 105, 212, 28, 175, 215, 46, 184, 48, 234, 1, 131, 227, 132, 123, 32, 106, 246, 4, 116, 38, 252, 66, 35, 165, 249, 46, 50, 157, 149, 85, 108, 230, 187, 173, 211, 79, 150, 127, 156, 236, 82, 51, 99, 193, 212, 89, 75, 226 }, new byte[] { 175, 136, 41, 250, 218, 88, 104, 181, 96, 208, 143, 244, 23, 76, 103, 124, 226, 193, 146, 61, 12, 81, 191, 145, 171, 66, 73, 53, 43, 93, 200, 104, 196, 77, 100, 29, 150, 203, 135, 1, 15, 36, 210, 72, 33, 207, 184, 119, 58, 141, 231, 212, 230, 225, 211, 185, 130, 112, 244, 63, 71, 230, 204, 238, 220, 243, 52, 75, 118, 183, 223, 237, 103, 22, 87, 208, 26, 131, 82, 167, 151, 55, 100, 117, 156, 21, 251, 130, 120, 46, 152, 122, 223, 112, 253, 154, 168, 50, 124, 249, 106, 141, 150, 19, 138, 111, 107, 255, 107, 45, 187, 243, 155, 145, 2, 41, 249, 149, 223, 77, 75, 109, 161, 230, 172, 173, 52, 246 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 174, 146, 151, 45, 181, 88, 140, 140, 181, 226, 0, 62, 12, 68, 180, 105, 212, 28, 175, 215, 46, 184, 48, 234, 1, 131, 227, 132, 123, 32, 106, 246, 4, 116, 38, 252, 66, 35, 165, 249, 46, 50, 157, 149, 85, 108, 230, 187, 173, 211, 79, 150, 127, 156, 236, 82, 51, 99, 193, 212, 89, 75, 226 }, new byte[] { 175, 136, 41, 250, 218, 88, 104, 181, 96, 208, 143, 244, 23, 76, 103, 124, 226, 193, 146, 61, 12, 81, 191, 145, 171, 66, 73, 53, 43, 93, 200, 104, 196, 77, 100, 29, 150, 203, 135, 1, 15, 36, 210, 72, 33, 207, 184, 119, 58, 141, 231, 212, 230, 225, 211, 185, 130, 112, 244, 63, 71, 230, 204, 238, 220, 243, 52, 75, 118, 183, 223, 237, 103, 22, 87, 208, 26, 131, 82, 167, 151, 55, 100, 117, 156, 21, 251, 130, 120, 46, 152, 122, 223, 112, 253, 154, 168, 50, 124, 249, 106, 141, 150, 19, 138, 111, 107, 255, 107, 45, 187, 243, 155, 145, 2, 41, 249, 149, 223, 77, 75, 109, 161, 230, 172, 173, 52, 246 } });

            migrationBuilder.UpdateData(
                table: "tbUser",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 174, 146, 151, 45, 181, 88, 140, 140, 181, 226, 0, 62, 12, 68, 180, 105, 212, 28, 175, 215, 46, 184, 48, 234, 1, 131, 227, 132, 123, 32, 106, 246, 4, 116, 38, 252, 66, 35, 165, 249, 46, 50, 157, 149, 85, 108, 230, 187, 173, 211, 79, 150, 127, 156, 236, 82, 51, 99, 193, 212, 89, 75, 226 }, new byte[] { 175, 136, 41, 250, 218, 88, 104, 181, 96, 208, 143, 244, 23, 76, 103, 124, 226, 193, 146, 61, 12, 81, 191, 145, 171, 66, 73, 53, 43, 93, 200, 104, 196, 77, 100, 29, 150, 203, 135, 1, 15, 36, 210, 72, 33, 207, 184, 119, 58, 141, 231, 212, 230, 225, 211, 185, 130, 112, 244, 63, 71, 230, 204, 238, 220, 243, 52, 75, 118, 183, 223, 237, 103, 22, 87, 208, 26, 131, 82, 167, 151, 55, 100, 117, 156, 21, 251, 130, 120, 46, 152, 122, 223, 112, 253, 154, 168, 50, 124, 249, 106, 141, 150, 19, 138, 111, 107, 255, 107, 45, 187, 243, 155, 145, 2, 41, 249, 149, 223, 77, 75, 109, 161, 230, 172, 173, 52, 246 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tbAddress",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address_full", "District_code", "Phone_code", "Province_code", "Ward_code" },
                values: new object[] { "tuyen quang, ha hang, thuong giap", "72", "207", "8", "2230" });

            migrationBuilder.UpdateData(
                table: "tbAddress",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address_full", "District_code", "Phone_code", "Province_code", "Ward_code" },
                values: new object[] { "quang ninh , huyen binh lieu, dong van", "198", "203", "22", "6847" });

            migrationBuilder.UpdateData(
                table: "tbAddress",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address_full", "District_code", "Phone_code", "Province_code", "Ward_code" },
                values: new object[] { "cao bang , bao lac , thuong ha", "43", "206", "4", "1327" });

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
        }
    }
}
