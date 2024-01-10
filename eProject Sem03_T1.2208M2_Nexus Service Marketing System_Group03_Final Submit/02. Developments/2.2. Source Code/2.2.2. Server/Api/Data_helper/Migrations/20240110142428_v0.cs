using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Data_helper.Migrations
{
    /// <inheritdoc />
    public partial class v0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address_full = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ward_code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbConnect_type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    First_Letter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Security_Deposit = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbConnect_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbCoupon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<int>(type: "int", nullable: false),
                    From = table.Column<int>(type: "int", nullable: false),
                    Percent_discount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCoupon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbEmployee_type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEmployee_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbSupplier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSupplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbTP_contract",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTP_contract", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbAddress_store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbAddress_store", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_store_Addresses",
                        column: x => x.Address_Id,
                        principalTable: "tbAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbPackage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Connect_type_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPackage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Packages_Connect_type",
                        column: x => x.Connect_type_Id,
                        principalTable: "tbConnect_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numb_Connect = table.Column<int>(type: "int", nullable: false),
                    Connect_type_Id = table.Column<int>(type: "int", nullable: false),
                    Supplier_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ConnectType",
                        column: x => x.Connect_type_Id,
                        principalTable: "tbConnect_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Supplier",
                        column: x => x.Supplier_Id,
                        principalTable: "tbSupplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Employee_type_Id = table.Column<int>(type: "int", nullable: false),
                    Address_store_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEmployee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emp_Address_store",
                        column: x => x.Address_store_Id,
                        principalTable: "tbAddress_store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emp_Emp_type",
                        column: x => x.Employee_type_Id,
                        principalTable: "tbEmployee_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbStorage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address_store_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbStorage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Storage_Address_store",
                        column: x => x.Address_store_id,
                        principalTable: "tbAddress_store",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbDuration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Package_Id = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Validate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDuration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Duration_Package",
                        column: x => x.Package_Id,
                        principalTable: "tbPackage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TokenCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordReset = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MethodReset = table.Column<int>(type: "int", nullable: true),
                    TP_contract_Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Employees_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Employee",
                        column: x => x.Employees_Id,
                        principalTable: "tbEmployee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_TpContractor",
                        column: x => x.TP_contract_Id,
                        principalTable: "tbTP_contract",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbImportReceipt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Storage_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbImportReceipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImportReceipt_Storage",
                        column: x => x.Storage_id,
                        principalTable: "tbStorage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_ImportReceipt",
                        column: x => x.Product_Id,
                        principalTable: "tbProduct",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbCall_charges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCall_charges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Call_charges_Duration",
                        column: x => x.Duration_Id,
                        principalTable: "tbDuration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Duration_Id = table.Column<int>(type: "int", nullable: true),
                    Address_Store_Id = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Reply = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedBack_Duration",
                        column: x => x.Duration_Id,
                        principalTable: "tbDuration",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Feedback_User",
                        column: x => x.User_Id,
                        principalTable: "tbUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbDuration_callCharges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration_Id = table.Column<int>(type: "int", nullable: false),
                    Call_charges_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDuration_callCharges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Duration_callCharges_Call_charges",
                        column: x => x.Call_charges_Id,
                        principalTable: "tbCall_charges",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Duration_callCharges_Duration",
                        column: x => x.Duration_Id,
                        principalTable: "tbDuration",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbOrders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total_Price = table.Column<float>(type: "real", nullable: false),
                    Numb_Connect = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Coupon_Id = table.Column<int>(type: "int", nullable: true),
                    StatusFeedback = table.Column<bool>(type: "bit", nullable: false),
                    FeedbackContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractService_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration_callCharges_Id = table.Column<int>(type: "int", nullable: true),
                    Duration_Id = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Addresses_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Address_Id",
                        column: x => x.Addresses_Id,
                        principalTable: "tbAddress",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_Coupon",
                        column: x => x.Coupon_Id,
                        principalTable: "tbCoupon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_Duration",
                        column: x => x.Duration_Id,
                        principalTable: "tbDuration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Duration_callCharges",
                        column: x => x.Duration_callCharges_Id,
                        principalTable: "tbDuration_callCharges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_User",
                        column: x => x.User_Id,
                        principalTable: "tbUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Order_handler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address_store_Id = table.Column<int>(type: "int", nullable: false),
                    Order_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Employee_Id = table.Column<int>(type: "int", nullable: false),
                    StatusHandle = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_handler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_handle_Address_store",
                        column: x => x.Address_store_Id,
                        principalTable: "tbAddress_store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_handle_Employee",
                        column: x => x.Employee_Id,
                        principalTable: "tbEmployee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_handle_Order",
                        column: x => x.Order_Id,
                        principalTable: "tbOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbContract_Service",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Order_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TP_Contract_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContractCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbContract_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contract_Services_Order",
                        column: x => x.Order_Id,
                        principalTable: "tbOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_Services_TpContractor",
                        column: x => x.TP_Contract_Id,
                        principalTable: "tbTP_contract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbPayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Method_Payment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Order",
                        column: x => x.Order_Id,
                        principalTable: "tbOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tbAddress",
                columns: new[] { "Id", "Address_full", "District_code", "Phone_code", "Province_code", "Ward_code" },
                values: new object[,]
                {
                    { 1, "Ngõ 93, đường Hồ Tùng Mậu, phường Mai Dịch, Quận Cầu Giấy", "5", "24", "1", "163" },
                    { 2, "số 1 Cao Thắng, phương Thanh Bình, Quận Hải Châu", "492", "236", "48", "20227" },
                    { 3, "soc trang, long phu, phu huu", "946", "299", "94", "31657" },
                    { 4, "33 Nguyễn Ảnh Thủ, xã Bà Điểm, huyện Hóc Môn", "784", "28", "79", "27592" }
                });

            migrationBuilder.InsertData(
                table: "tbConnect_type",
                columns: new[] { "Id", "Description", "First_Letter", "Name", "Security_Deposit" },
                values: new object[,]
                {
                    { 1, "dial-up", "D", "Dial-up", 325f },
                    { 2, "Broad Band", "B", "Broad Band", 500f },
                    { 3, "LandLine", "L", "LandLine", 250f }
                });

            migrationBuilder.InsertData(
                table: "tbCoupon",
                columns: new[] { "Id", "From", "Name", "Percent_discount", "To" },
                values: new object[,]
                {
                    { 1, 15, "code coupon", 25f, 10 },
                    { 2, 25, "code coupon 1", 50f, 15 },
                    { 3, 50, "code coupon 2", 75f, 25 },
                    { 4, 1000, "code coupon 3", 100f, 50 }
                });

            migrationBuilder.InsertData(
                table: "tbEmployee_type",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sale" },
                    { 2, "Technician" }
                });

            migrationBuilder.InsertData(
                table: "tbSupplier",
                columns: new[] { "Id", "Address", "Phone", "brandName" },
                values: new object[,]
                {
                    { 1, "ha noi", "0462146762", "UniFi" },
                    { 2, "ha noi", "0646272131", "Grandstream" },
                    { 3, "ha noi", "0646272131", "Panasonic" }
                });

            migrationBuilder.InsertData(
                table: "tbUser",
                columns: new[] { "Id", "Email", "Employees_Id", "FullName", "MethodReset", "PasswordHash", "PasswordReset", "PasswordSalt", "Phone", "RefreshToken", "ResetExpires", "Role", "Status", "TP_contract_Id", "TokenCreated", "TokenExpires" },
                values: new object[,]
                {
                    { 1, null, null, "Nguyen Van Thien", null, new byte[] { 119, 29, 44, 225, 190, 202, 175, 106, 147, 45, 105, 69, 224, 231, 161, 52, 172, 86, 38, 129, 60, 78, 154, 152, 130, 103, 91, 28, 58, 122, 149, 79, 124, 241, 89, 127, 10, 134, 167, 201, 23, 78, 179, 165, 197, 153, 156, 170, 187, 119, 216, 244, 94, 127, 198, 178, 187, 162, 161, 132, 155, 251, 51, 33 }, null, new byte[] { 193, 10, 145, 140, 163, 243, 144, 85, 93, 158, 53, 39, 113, 193, 139, 89, 187, 109, 21, 188, 147, 160, 75, 190, 7, 145, 226, 174, 245, 46, 120, 132, 203, 24, 249, 50, 38, 46, 9, 251, 1, 226, 221, 135, 83, 172, 5, 31, 20, 110, 9, 177, 182, 110, 194, 40, 162, 150, 116, 253, 48, 149, 90, 6, 60, 254, 142, 148, 162, 191, 58, 198, 118, 68, 129, 126, 143, 163, 112, 5, 116, 100, 122, 3, 133, 79, 241, 132, 62, 20, 68, 176, 85, 152, 239, 150, 126, 157, 165, 136, 166, 226, 117, 30, 102, 32, 124, 108, 35, 40, 100, 25, 33, 44, 16, 99, 36, 209, 240, 246, 241, 177, 69, 41, 112, 252, 54, 119 }, "0932859395", "", null, "user", "Active", null, null, null },
                    { 2, null, null, "admin", null, new byte[] { 119, 29, 44, 225, 190, 202, 175, 106, 147, 45, 105, 69, 224, 231, 161, 52, 172, 86, 38, 129, 60, 78, 154, 152, 130, 103, 91, 28, 58, 122, 149, 79, 124, 241, 89, 127, 10, 134, 167, 201, 23, 78, 179, 165, 197, 153, 156, 170, 187, 119, 216, 244, 94, 127, 198, 178, 187, 162, 161, 132, 155, 251, 51, 33 }, null, new byte[] { 193, 10, 145, 140, 163, 243, 144, 85, 93, 158, 53, 39, 113, 193, 139, 89, 187, 109, 21, 188, 147, 160, 75, 190, 7, 145, 226, 174, 245, 46, 120, 132, 203, 24, 249, 50, 38, 46, 9, 251, 1, 226, 221, 135, 83, 172, 5, 31, 20, 110, 9, 177, 182, 110, 194, 40, 162, 150, 116, 253, 48, 149, 90, 6, 60, 254, 142, 148, 162, 191, 58, 198, 118, 68, 129, 126, 143, 163, 112, 5, 116, 100, 122, 3, 133, 79, 241, 132, 62, 20, 68, 176, 85, 152, 239, 150, 126, 157, 165, 136, 166, 226, 117, 30, 102, 32, 124, 108, 35, 40, 100, 25, 33, 44, 16, 99, 36, 209, 240, 246, 241, 177, 69, 41, 112, 252, 54, 119 }, "0971866177", "", null, "admin", null, null, null, null },
                    { 3, null, null, "Tran Thien Hieu", null, new byte[] { 119, 29, 44, 225, 190, 202, 175, 106, 147, 45, 105, 69, 224, 231, 161, 52, 172, 86, 38, 129, 60, 78, 154, 152, 130, 103, 91, 28, 58, 122, 149, 79, 124, 241, 89, 127, 10, 134, 167, 201, 23, 78, 179, 165, 197, 153, 156, 170, 187, 119, 216, 244, 94, 127, 198, 178, 187, 162, 161, 132, 155, 251, 51, 33 }, null, new byte[] { 193, 10, 145, 140, 163, 243, 144, 85, 93, 158, 53, 39, 113, 193, 139, 89, 187, 109, 21, 188, 147, 160, 75, 190, 7, 145, 226, 174, 245, 46, 120, 132, 203, 24, 249, 50, 38, 46, 9, 251, 1, 226, 221, 135, 83, 172, 5, 31, 20, 110, 9, 177, 182, 110, 194, 40, 162, 150, 116, 253, 48, 149, 90, 6, 60, 254, 142, 148, 162, 191, 58, 198, 118, 68, 129, 126, 143, 163, 112, 5, 116, 100, 122, 3, 133, 79, 241, 132, 62, 20, 68, 176, 85, 152, 239, 150, 126, 157, 165, 136, 166, 226, 117, 30, 102, 32, 124, 108, 35, 40, 100, 25, 33, 44, 16, 99, 36, 209, 240, 246, 241, 177, 69, 41, 112, 252, 54, 119 }, "0123456789", "", null, "sale", null, null, null, null },
                    { 4, null, null, "Tran Van Phat", null, new byte[] { 119, 29, 44, 225, 190, 202, 175, 106, 147, 45, 105, 69, 224, 231, 161, 52, 172, 86, 38, 129, 60, 78, 154, 152, 130, 103, 91, 28, 58, 122, 149, 79, 124, 241, 89, 127, 10, 134, 167, 201, 23, 78, 179, 165, 197, 153, 156, 170, 187, 119, 216, 244, 94, 127, 198, 178, 187, 162, 161, 132, 155, 251, 51, 33 }, null, new byte[] { 193, 10, 145, 140, 163, 243, 144, 85, 93, 158, 53, 39, 113, 193, 139, 89, 187, 109, 21, 188, 147, 160, 75, 190, 7, 145, 226, 174, 245, 46, 120, 132, 203, 24, 249, 50, 38, 46, 9, 251, 1, 226, 221, 135, 83, 172, 5, 31, 20, 110, 9, 177, 182, 110, 194, 40, 162, 150, 116, 253, 48, 149, 90, 6, 60, 254, 142, 148, 162, 191, 58, 198, 118, 68, 129, 126, 143, 163, 112, 5, 116, 100, 122, 3, 133, 79, 241, 132, 62, 20, 68, 176, 85, 152, 239, 150, 126, 157, 165, 136, 166, 226, 117, 30, 102, 32, 124, 108, 35, 40, 100, 25, 33, 44, 16, 99, 36, 209, 240, 246, 241, 177, 69, 41, 112, 252, 54, 119 }, "0987654321", "", null, "Technical", null, null, null, null },
                    { 5, null, null, "Nguyen Van A", null, new byte[] { 119, 29, 44, 225, 190, 202, 175, 106, 147, 45, 105, 69, 224, 231, 161, 52, 172, 86, 38, 129, 60, 78, 154, 152, 130, 103, 91, 28, 58, 122, 149, 79, 124, 241, 89, 127, 10, 134, 167, 201, 23, 78, 179, 165, 197, 153, 156, 170, 187, 119, 216, 244, 94, 127, 198, 178, 187, 162, 161, 132, 155, 251, 51, 33 }, null, new byte[] { 193, 10, 145, 140, 163, 243, 144, 85, 93, 158, 53, 39, 113, 193, 139, 89, 187, 109, 21, 188, 147, 160, 75, 190, 7, 145, 226, 174, 245, 46, 120, 132, 203, 24, 249, 50, 38, 46, 9, 251, 1, 226, 221, 135, 83, 172, 5, 31, 20, 110, 9, 177, 182, 110, 194, 40, 162, 150, 116, 253, 48, 149, 90, 6, 60, 254, 142, 148, 162, 191, 58, 198, 118, 68, 129, 126, 143, 163, 112, 5, 116, 100, 122, 3, 133, 79, 241, 132, 62, 20, 68, 176, 85, 152, 239, 150, 126, 157, 165, 136, 166, 226, 117, 30, 102, 32, 124, 108, 35, 40, 100, 25, 33, 44, 16, 99, 36, 209, 240, 246, 241, 177, 69, 41, 112, 252, 54, 119 }, "0796526595", "", null, "sale", null, null, null, null },
                    { 6, null, null, "Nguyen Van B", null, new byte[] { 119, 29, 44, 225, 190, 202, 175, 106, 147, 45, 105, 69, 224, 231, 161, 52, 172, 86, 38, 129, 60, 78, 154, 152, 130, 103, 91, 28, 58, 122, 149, 79, 124, 241, 89, 127, 10, 134, 167, 201, 23, 78, 179, 165, 197, 153, 156, 170, 187, 119, 216, 244, 94, 127, 198, 178, 187, 162, 161, 132, 155, 251, 51, 33 }, null, new byte[] { 193, 10, 145, 140, 163, 243, 144, 85, 93, 158, 53, 39, 113, 193, 139, 89, 187, 109, 21, 188, 147, 160, 75, 190, 7, 145, 226, 174, 245, 46, 120, 132, 203, 24, 249, 50, 38, 46, 9, 251, 1, 226, 221, 135, 83, 172, 5, 31, 20, 110, 9, 177, 182, 110, 194, 40, 162, 150, 116, 253, 48, 149, 90, 6, 60, 254, 142, 148, 162, 191, 58, 198, 118, 68, 129, 126, 143, 163, 112, 5, 116, 100, 122, 3, 133, 79, 241, 132, 62, 20, 68, 176, 85, 152, 239, 150, 126, 157, 165, 136, 166, 226, 117, 30, 102, 32, 124, 108, 35, 40, 100, 25, 33, 44, 16, 99, 36, 209, 240, 246, 241, 177, 69, 41, 112, 252, 54, 119 }, "0955797871", "", null, "sale", null, null, null, null },
                    { 7, null, null, "Nguyen Van C", null, new byte[] { 119, 29, 44, 225, 190, 202, 175, 106, 147, 45, 105, 69, 224, 231, 161, 52, 172, 86, 38, 129, 60, 78, 154, 152, 130, 103, 91, 28, 58, 122, 149, 79, 124, 241, 89, 127, 10, 134, 167, 201, 23, 78, 179, 165, 197, 153, 156, 170, 187, 119, 216, 244, 94, 127, 198, 178, 187, 162, 161, 132, 155, 251, 51, 33 }, null, new byte[] { 193, 10, 145, 140, 163, 243, 144, 85, 93, 158, 53, 39, 113, 193, 139, 89, 187, 109, 21, 188, 147, 160, 75, 190, 7, 145, 226, 174, 245, 46, 120, 132, 203, 24, 249, 50, 38, 46, 9, 251, 1, 226, 221, 135, 83, 172, 5, 31, 20, 110, 9, 177, 182, 110, 194, 40, 162, 150, 116, 253, 48, 149, 90, 6, 60, 254, 142, 148, 162, 191, 58, 198, 118, 68, 129, 126, 143, 163, 112, 5, 116, 100, 122, 3, 133, 79, 241, 132, 62, 20, 68, 176, 85, 152, 239, 150, 126, 157, 165, 136, 166, 226, 117, 30, 102, 32, 124, 108, 35, 40, 100, 25, 33, 44, 16, 99, 36, 209, 240, 246, 241, 177, 69, 41, 112, 252, 54, 119 }, "0689764123", "", null, "sale", null, null, null, null },
                    { 8, null, null, "Nguyen Van D", null, new byte[] { 119, 29, 44, 225, 190, 202, 175, 106, 147, 45, 105, 69, 224, 231, 161, 52, 172, 86, 38, 129, 60, 78, 154, 152, 130, 103, 91, 28, 58, 122, 149, 79, 124, 241, 89, 127, 10, 134, 167, 201, 23, 78, 179, 165, 197, 153, 156, 170, 187, 119, 216, 244, 94, 127, 198, 178, 187, 162, 161, 132, 155, 251, 51, 33 }, null, new byte[] { 193, 10, 145, 140, 163, 243, 144, 85, 93, 158, 53, 39, 113, 193, 139, 89, 187, 109, 21, 188, 147, 160, 75, 190, 7, 145, 226, 174, 245, 46, 120, 132, 203, 24, 249, 50, 38, 46, 9, 251, 1, 226, 221, 135, 83, 172, 5, 31, 20, 110, 9, 177, 182, 110, 194, 40, 162, 150, 116, 253, 48, 149, 90, 6, 60, 254, 142, 148, 162, 191, 58, 198, 118, 68, 129, 126, 143, 163, 112, 5, 116, 100, 122, 3, 133, 79, 241, 132, 62, 20, 68, 176, 85, 152, 239, 150, 126, 157, 165, 136, 166, 226, 117, 30, 102, 32, 124, 108, 35, 40, 100, 25, 33, 44, 16, 99, 36, 209, 240, 246, 241, 177, 69, 41, 112, 252, 54, 119 }, "0689434167", "", null, "Technical", null, null, null, null },
                    { 9, null, null, "Nguyen Van E", null, new byte[] { 119, 29, 44, 225, 190, 202, 175, 106, 147, 45, 105, 69, 224, 231, 161, 52, 172, 86, 38, 129, 60, 78, 154, 152, 130, 103, 91, 28, 58, 122, 149, 79, 124, 241, 89, 127, 10, 134, 167, 201, 23, 78, 179, 165, 197, 153, 156, 170, 187, 119, 216, 244, 94, 127, 198, 178, 187, 162, 161, 132, 155, 251, 51, 33 }, null, new byte[] { 193, 10, 145, 140, 163, 243, 144, 85, 93, 158, 53, 39, 113, 193, 139, 89, 187, 109, 21, 188, 147, 160, 75, 190, 7, 145, 226, 174, 245, 46, 120, 132, 203, 24, 249, 50, 38, 46, 9, 251, 1, 226, 221, 135, 83, 172, 5, 31, 20, 110, 9, 177, 182, 110, 194, 40, 162, 150, 116, 253, 48, 149, 90, 6, 60, 254, 142, 148, 162, 191, 58, 198, 118, 68, 129, 126, 143, 163, 112, 5, 116, 100, 122, 3, 133, 79, 241, 132, 62, 20, 68, 176, 85, 152, 239, 150, 126, 157, 165, 136, 166, 226, 117, 30, 102, 32, 124, 108, 35, 40, 100, 25, 33, 44, 16, 99, 36, 209, 240, 246, 241, 177, 69, 41, 112, 252, 54, 119 }, "0689764139", "", null, "Technical", null, null, null, null },
                    { 10, null, null, "Nguyen Van F", null, new byte[] { 119, 29, 44, 225, 190, 202, 175, 106, 147, 45, 105, 69, 224, 231, 161, 52, 172, 86, 38, 129, 60, 78, 154, 152, 130, 103, 91, 28, 58, 122, 149, 79, 124, 241, 89, 127, 10, 134, 167, 201, 23, 78, 179, 165, 197, 153, 156, 170, 187, 119, 216, 244, 94, 127, 198, 178, 187, 162, 161, 132, 155, 251, 51, 33 }, null, new byte[] { 193, 10, 145, 140, 163, 243, 144, 85, 93, 158, 53, 39, 113, 193, 139, 89, 187, 109, 21, 188, 147, 160, 75, 190, 7, 145, 226, 174, 245, 46, 120, 132, 203, 24, 249, 50, 38, 46, 9, 251, 1, 226, 221, 135, 83, 172, 5, 31, 20, 110, 9, 177, 182, 110, 194, 40, 162, 150, 116, 253, 48, 149, 90, 6, 60, 254, 142, 148, 162, 191, 58, 198, 118, 68, 129, 126, 143, 163, 112, 5, 116, 100, 122, 3, 133, 79, 241, 132, 62, 20, 68, 176, 85, 152, 239, 150, 126, 157, 165, 136, 166, 226, 117, 30, 102, 32, 124, 108, 35, 40, 100, 25, 33, 44, 16, 99, 36, 209, 240, 246, 241, 177, 69, 41, 112, 252, 54, 119 }, "0329764195", "", null, "Technical", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "tbAddress_store",
                columns: new[] { "Id", "Address_Id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "tbPackage",
                columns: new[] { "Id", "Connect_type_Id", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Hourly Basic" },
                    { 2, 1, "Unlimited 28Kbps" },
                    { 3, 1, "Unlimited 56Kbps" },
                    { 4, 2, "Hourly Basic" },
                    { 5, 2, "Unlimited 64Kbps" },
                    { 6, 2, "Unlimited 128Kbps" },
                    { 7, 3, "Local Plan= Rental + Callcharges" },
                    { 8, 3, "STD Plan" }
                });

            migrationBuilder.InsertData(
                table: "tbProduct",
                columns: new[] { "Id", "Connect_type_Id", "Name", "Numb_Connect", "Supplier_Id" },
                values: new object[,]
                {
                    { 1, 1, "UniFi AC Lite", 10, 1 },
                    { 2, 1, "UniFi AC Pro", 15, 1 },
                    { 3, 1, "UniFi AC Nano", 25, 1 },
                    { 4, 1, "UniFi AC NanoPro", 51, 1 },
                    { 5, 1, "GrandStream AC Lite", 10, 2 },
                    { 6, 1, "GrandStream AC Pro", 15, 2 },
                    { 7, 1, "GrandStream AC Nano", 25, 2 },
                    { 8, 1, "GrandStream AC NanoPro", 51, 2 },
                    { 9, 2, "UniFi AC Lite Max", 10, 1 },
                    { 10, 2, "UniFi AC Pro Max", 15, 1 },
                    { 11, 2, "UniFi AC Nano Max", 25, 1 },
                    { 12, 2, "UniFi AC NanoPro Max", 51, 1 },
                    { 13, 2, "GrandStream AC Lite Max", 10, 2 },
                    { 14, 2, "GrandStream AC Pro Max", 15, 2 },
                    { 15, 2, "GrandStream AC Nano Max", 25, 2 },
                    { 16, 2, "GrandStream AC NanoPro Max", 51, 2 },
                    { 17, 3, "KXTS500", 10, 3 },
                    { 18, 3, "IP Fanvil X7A", 15, 3 }
                });

            migrationBuilder.InsertData(
                table: "tbDuration",
                columns: new[] { "Id", "Description", "Package_Id", "Price", "Time", "Validate" },
                values: new object[,]
                {
                    { 1, null, 1, 50f, "10Hrs", "1" },
                    { 2, null, 1, 130f, "30Hrs", "3" },
                    { 3, null, 1, 260f, "60Hrs", "6" },
                    { 4, null, 2, 75f, "Monthly", "1" },
                    { 5, null, 2, 150f, "Quarterly", "3" },
                    { 6, null, 3, 100f, "Monthly", "1" },
                    { 7, null, 3, 180f, "Quarterly", "3" },
                    { 8, null, 4, 175f, "30Hrs", "1" },
                    { 9, null, 4, 315f, "60Hrs", "3" },
                    { 10, null, 5, 225f, "Monthly", "1" },
                    { 11, null, 5, 400f, "Quarterly", "3" },
                    { 12, null, 6, 350f, "Monthly", "1" },
                    { 13, null, 6, 445f, "Quarterly", "3" },
                    { 14, "Local ULT : 55 cent/min", 7, 75f, "Unlimited", "12" },
                    { 15, "Local M: 75cent/min", 7, 35f, "Monthly", "1" },
                    { 16, "Local: 70cent/min; STD:2.25$/min ; Messaging for mobiles:1$/min", 8, 125f, "Monthly", "1" },
                    { 17, "Local: 60cent/min; STD:2$/min ; Messaging for mobiles:1.15$/min", 8, 420f, "Half-Yearly", "6" },
                    { 18, "Local: 60cent/min; STD:1.75$/min ; Messaging for mobiles:1.12$/min", 8, 799f, "Yearly", "12" }
                });

            migrationBuilder.InsertData(
                table: "tbEmployee",
                columns: new[] { "Id", "Address_store_Id", "Employee_type_Id", "User_Id" },
                values: new object[,]
                {
                    { 1, 1, 1, 3 },
                    { 2, 1, 2, 4 },
                    { 3, 2, 1, 5 },
                    { 4, 2, 2, 8 },
                    { 5, 3, 1, 6 },
                    { 6, 3, 2, 9 },
                    { 7, 4, 1, 7 },
                    { 8, 4, 2, 10 }
                });

            migrationBuilder.InsertData(
                table: "tbStorage",
                columns: new[] { "Id", "Address_store_id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "tbCall_charges",
                columns: new[] { "Id", "Duration_Id", "Name", "Price", "Unit" },
                values: new object[,]
                {
                    { 1, 14, "Local ULT", 55f, "cent/min" },
                    { 2, 15, "Local M", 75f, "cent/min" },
                    { 3, 16, "Local", 70f, "cent/min" },
                    { 4, 16, "STD", 2.25f, "$/min" },
                    { 5, 16, "Messaging for mobiles", 1f, "$/min" },
                    { 6, 17, "Local", 60f, "cent/min" },
                    { 7, 17, "STD", 2f, "$/min" },
                    { 8, 17, "Messaging for mobiles", 1.15f, "$/min" },
                    { 9, 18, "Local", 60f, "cent/min" },
                    { 10, 18, "STD", 1.75f, "$/min" },
                    { 11, 18, "Messaging for mobiles", 1.12f, "$/min" }
                });

            migrationBuilder.InsertData(
                table: "tbDuration_callCharges",
                columns: new[] { "Id", "Call_charges_Id", "Duration_Id" },
                values: new object[,]
                {
                    { 1, null, 1 },
                    { 2, null, 2 },
                    { 3, null, 3 },
                    { 4, null, 4 },
                    { 5, null, 5 },
                    { 6, null, 6 },
                    { 7, null, 7 },
                    { 8, null, 8 },
                    { 9, null, 9 },
                    { 10, null, 10 },
                    { 11, null, 11 },
                    { 12, null, 12 },
                    { 13, null, 13 }
                });

            migrationBuilder.InsertData(
                table: "tbImportReceipt",
                columns: new[] { "Id", "Product_Id", "Quantity", "Status", "Storage_id", "Time" },
                values: new object[,]
                {
                    { 1, 1, 10, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(540) },
                    { 2, 2, 15, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(570) },
                    { 3, 3, 20, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(570) },
                    { 4, 4, 30, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(570) },
                    { 5, 5, 10, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(570) },
                    { 6, 6, 15, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(580) },
                    { 7, 7, 20, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(580) },
                    { 8, 8, 30, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(580) },
                    { 9, 9, 10, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(580) },
                    { 10, 10, 15, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(580) },
                    { 11, 11, 20, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(580) },
                    { 12, 12, 30, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(580) },
                    { 13, 13, 10, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(590) },
                    { 14, 14, 15, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(590) },
                    { 15, 15, 20, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(590) },
                    { 16, 16, 30, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(590) },
                    { 17, 17, 15, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(590) },
                    { 18, 18, 20, "Done", 1, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(590) },
                    { 19, 1, 10, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(600) },
                    { 20, 2, 15, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(600) },
                    { 21, 3, 20, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(600) },
                    { 22, 4, 30, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(600) },
                    { 23, 5, 10, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(600) },
                    { 24, 6, 15, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(610) },
                    { 25, 7, 20, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(610) },
                    { 26, 8, 30, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(610) },
                    { 27, 9, 10, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(610) },
                    { 28, 10, 15, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(610) },
                    { 29, 11, 20, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(610) },
                    { 30, 12, 30, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(620) },
                    { 31, 13, 10, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(620) },
                    { 32, 14, 15, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(620) },
                    { 33, 15, 20, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(620) },
                    { 34, 16, 30, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(620) },
                    { 35, 17, 15, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(620) },
                    { 36, 18, 20, "Done", 2, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(630) },
                    { 37, 1, 10, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(630) },
                    { 38, 2, 15, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(630) },
                    { 39, 3, 20, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(630) },
                    { 40, 4, 30, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(630) },
                    { 41, 5, 10, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(630) },
                    { 42, 6, 15, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(630) },
                    { 43, 7, 20, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(670) },
                    { 44, 8, 30, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(680) },
                    { 45, 9, 10, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(680) },
                    { 46, 10, 15, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(680) },
                    { 47, 11, 20, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(680) },
                    { 48, 12, 30, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(680) },
                    { 49, 13, 10, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(680) },
                    { 50, 14, 15, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(680) },
                    { 51, 15, 20, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(690) },
                    { 52, 16, 30, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(690) },
                    { 53, 17, 15, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(690) },
                    { 54, 18, 20, "Done", 3, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(690) },
                    { 55, 1, 10, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(690) },
                    { 56, 2, 15, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(690) },
                    { 57, 3, 20, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(690) },
                    { 58, 4, 30, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(700) },
                    { 59, 5, 10, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(700) },
                    { 60, 6, 15, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(700) },
                    { 61, 7, 20, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(700) },
                    { 62, 8, 30, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(700) },
                    { 63, 9, 10, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(700) },
                    { 64, 10, 15, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(710) },
                    { 65, 11, 20, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(710) },
                    { 66, 12, 30, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(710) },
                    { 67, 13, 10, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(710) },
                    { 68, 14, 15, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(710) },
                    { 69, 15, 20, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(710) },
                    { 70, 16, 30, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(710) },
                    { 71, 17, 15, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(720) },
                    { 72, 18, 20, "Done", 4, new DateTime(2024, 1, 10, 21, 24, 28, 179, DateTimeKind.Local).AddTicks(720) }
                });

            migrationBuilder.InsertData(
                table: "tbDuration_callCharges",
                columns: new[] { "Id", "Call_charges_Id", "Duration_Id" },
                values: new object[,]
                {
                    { 14, 1, 14 },
                    { 15, 2, 15 },
                    { 16, 3, 16 },
                    { 17, 4, 16 },
                    { 18, 5, 16 },
                    { 19, 6, 17 },
                    { 20, 7, 17 },
                    { 21, 8, 17 },
                    { 22, 9, 18 },
                    { 23, 10, 18 },
                    { 24, 11, 18 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Duration_Id",
                table: "Feedbacks",
                column: "Duration_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_User_Id",
                table: "Feedbacks",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_handler_Address_store_Id",
                table: "Order_handler",
                column: "Address_store_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_handler_Employee_Id",
                table: "Order_handler",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_handler_Order_Id",
                table: "Order_handler",
                column: "Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbAddress_store_Address_Id",
                table: "tbAddress_store",
                column: "Address_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbCall_charges_Duration_Id",
                table: "tbCall_charges",
                column: "Duration_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbContract_Service_Order_Id",
                table: "tbContract_Service",
                column: "Order_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbContract_Service_TP_Contract_Id",
                table: "tbContract_Service",
                column: "TP_Contract_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbDuration_Package_Id",
                table: "tbDuration",
                column: "Package_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbDuration_callCharges_Call_charges_Id",
                table: "tbDuration_callCharges",
                column: "Call_charges_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbDuration_callCharges_Duration_Id",
                table: "tbDuration_callCharges",
                column: "Duration_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbEmployee_Address_store_Id",
                table: "tbEmployee",
                column: "Address_store_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbEmployee_Employee_type_Id",
                table: "tbEmployee",
                column: "Employee_type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbImportReceipt_Product_Id",
                table: "tbImportReceipt",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbImportReceipt_Storage_id",
                table: "tbImportReceipt",
                column: "Storage_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbOrders_Addresses_Id",
                table: "tbOrders",
                column: "Addresses_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbOrders_Coupon_Id",
                table: "tbOrders",
                column: "Coupon_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbOrders_Duration_callCharges_Id",
                table: "tbOrders",
                column: "Duration_callCharges_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbOrders_Duration_Id",
                table: "tbOrders",
                column: "Duration_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbOrders_User_Id",
                table: "tbOrders",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbPackage_Connect_type_Id",
                table: "tbPackage",
                column: "Connect_type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbPayment_Order_Id",
                table: "tbPayment",
                column: "Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbProduct_Connect_type_Id",
                table: "tbProduct",
                column: "Connect_type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbProduct_Supplier_Id",
                table: "tbProduct",
                column: "Supplier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbStorage_Address_store_id",
                table: "tbStorage",
                column: "Address_store_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbUser_Employees_Id",
                table: "tbUser",
                column: "Employees_Id",
                unique: true,
                filter: "[Employees_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tbUser_TP_contract_Id",
                table: "tbUser",
                column: "TP_contract_Id",
                unique: true,
                filter: "[TP_contract_Id] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banner");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Order_handler");

            migrationBuilder.DropTable(
                name: "tbContract_Service");

            migrationBuilder.DropTable(
                name: "tbImportReceipt");

            migrationBuilder.DropTable(
                name: "tbPayment");

            migrationBuilder.DropTable(
                name: "tbStorage");

            migrationBuilder.DropTable(
                name: "tbProduct");

            migrationBuilder.DropTable(
                name: "tbOrders");

            migrationBuilder.DropTable(
                name: "tbSupplier");

            migrationBuilder.DropTable(
                name: "tbCoupon");

            migrationBuilder.DropTable(
                name: "tbDuration_callCharges");

            migrationBuilder.DropTable(
                name: "tbUser");

            migrationBuilder.DropTable(
                name: "tbCall_charges");

            migrationBuilder.DropTable(
                name: "tbEmployee");

            migrationBuilder.DropTable(
                name: "tbTP_contract");

            migrationBuilder.DropTable(
                name: "tbDuration");

            migrationBuilder.DropTable(
                name: "tbAddress_store");

            migrationBuilder.DropTable(
                name: "tbEmployee_type");

            migrationBuilder.DropTable(
                name: "tbPackage");

            migrationBuilder.DropTable(
                name: "tbAddress");

            migrationBuilder.DropTable(
                name: "tbConnect_type");
        }
    }
}
