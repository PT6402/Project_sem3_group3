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
                    Duration_Id = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1, "tuyen quang, ha hang, thuong giap", "72", "207", "8", "2230" },
                    { 2, "quang ninh , huyen binh lieu, dong van", "198", "203", "22", "6847" },
                    { 3, "soc trang, long phu, phu huu", "946", "299", "94", "31657" },
                    { 4, "cao bang , bao lac , thuong ha", "43", "206", "4", "1327" }
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
                    { 1, null, null, "Nguyen Van Thien", null, new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, null, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 }, "0932859395", "", null, "user", "Active", null, null, null },
                    { 2, null, null, "admin", null, new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, null, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 }, "0971866177", "", null, "admin", null, null, null, null },
                    { 3, null, null, "Tran Thien Hieu", null, new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, null, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 }, "0123456789", "", null, "sale", null, null, null, null },
                    { 4, null, null, "Tran Van Phat", null, new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, null, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 }, "0987654321", "", null, "Technical", null, null, null, null },
                    { 5, null, null, "Nguyen Van A", null, new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, null, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 }, "0796526595", "", null, "sale", null, null, null, null },
                    { 6, null, null, "Nguyen Van B", null, new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, null, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 }, "0955797871", "", null, "sale", null, null, null, null },
                    { 7, null, null, "Nguyen Van C", null, new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, null, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 }, "0689764123", "", null, "sale", null, null, null, null },
                    { 8, null, null, "Nguyen Van D", null, new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, null, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 }, "0689434167", "", null, "Technical", null, null, null, null },
                    { 9, null, null, "Nguyen Van E", null, new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, null, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 }, "0689764139", "", null, "Technical", null, null, null, null },
                    { 10, null, null, "Nguyen Van F", null, new byte[] { 144, 215, 150, 247, 134, 123, 207, 6, 196, 147, 186, 146, 250, 194, 241, 155, 135, 22, 175, 152, 40, 25, 181, 36, 102, 251, 161, 145, 56, 126, 240, 84, 208, 121, 109, 137, 20, 145, 154, 47, 223, 199, 116, 185, 110, 103, 226, 192, 246, 21, 147, 184, 84, 47, 46, 195, 21, 142, 32, 221, 249, 93, 120, 229 }, null, new byte[] { 113, 230, 173, 153, 177, 205, 4, 112, 84, 250, 60, 244, 163, 224, 112, 205, 194, 130, 253, 125, 206, 15, 199, 162, 48, 21, 39, 140, 249, 106, 76, 221, 213, 20, 154, 38, 248, 50, 86, 63, 165, 90, 31, 124, 204, 0, 18, 189, 244, 180, 213, 145, 58, 197, 66, 207, 230, 179, 210, 254, 39, 181, 115, 135, 44, 165, 203, 226, 133, 49, 139, 70, 190, 19, 87, 56, 211, 216, 108, 187, 103, 227, 38, 20, 66, 130, 9, 239, 64, 219, 19, 177, 81, 245, 247, 179, 55, 23, 20, 89, 45, 125, 235, 225, 11, 96, 64, 97, 33, 196, 214, 97, 139, 56, 218, 177, 167, 46, 26, 149, 86, 207, 236, 106, 92, 247, 249, 119 }, "0329764195", "", null, "Technical", null, null, null, null }
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
                    { 1, 1, 10, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2110) },
                    { 2, 2, 15, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2130) },
                    { 3, 3, 20, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2130) },
                    { 4, 4, 30, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2140) },
                    { 5, 5, 10, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2140) },
                    { 6, 6, 15, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2140) },
                    { 7, 7, 20, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2140) },
                    { 8, 8, 30, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2150) },
                    { 9, 9, 10, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2150) },
                    { 10, 10, 15, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2150) },
                    { 11, 11, 20, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2150) },
                    { 12, 12, 30, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2150) },
                    { 13, 13, 10, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2160) },
                    { 14, 14, 15, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2160) },
                    { 15, 15, 20, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2160) },
                    { 16, 16, 30, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2160) },
                    { 17, 17, 15, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2170) },
                    { 18, 18, 20, "Done", 1, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2170) },
                    { 19, 1, 10, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2170) },
                    { 20, 2, 15, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2170) },
                    { 21, 3, 20, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2170) },
                    { 22, 4, 30, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2180) },
                    { 23, 5, 10, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2180) },
                    { 24, 6, 15, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2180) },
                    { 25, 7, 20, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2180) },
                    { 26, 8, 30, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2190) },
                    { 27, 9, 10, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2190) },
                    { 28, 10, 15, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2190) },
                    { 29, 11, 20, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2200) },
                    { 30, 12, 30, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2200) },
                    { 31, 13, 10, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2200) },
                    { 32, 14, 15, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2200) },
                    { 33, 15, 20, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2200) },
                    { 34, 16, 30, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2210) },
                    { 35, 17, 15, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2210) },
                    { 36, 18, 20, "Done", 2, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2210) },
                    { 37, 1, 10, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2210) },
                    { 38, 2, 15, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2210) },
                    { 39, 3, 20, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2220) },
                    { 40, 4, 30, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2220) },
                    { 41, 5, 10, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2220) },
                    { 42, 6, 15, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2220) },
                    { 43, 7, 20, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2230) },
                    { 44, 8, 30, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2230) },
                    { 45, 9, 10, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2230) },
                    { 46, 10, 15, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2230) },
                    { 47, 11, 20, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2230) },
                    { 48, 12, 30, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2240) },
                    { 49, 13, 10, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2240) },
                    { 50, 14, 15, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2240) },
                    { 51, 15, 20, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2240) },
                    { 52, 16, 30, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2250) },
                    { 53, 17, 15, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2250) },
                    { 54, 18, 20, "Done", 3, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2250) },
                    { 55, 1, 10, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2250) },
                    { 56, 2, 15, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2250) },
                    { 57, 3, 20, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2260) },
                    { 58, 4, 30, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2260) },
                    { 59, 5, 10, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2260) },
                    { 60, 6, 15, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2260) },
                    { 61, 7, 20, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2260) },
                    { 62, 8, 30, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2260) },
                    { 63, 9, 10, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2270) },
                    { 64, 10, 15, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2270) },
                    { 65, 11, 20, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2270) },
                    { 66, 12, 30, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2320) },
                    { 67, 13, 10, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2320) },
                    { 68, 14, 15, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2320) },
                    { 69, 15, 20, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2320) },
                    { 70, 16, 30, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2330) },
                    { 71, 17, 15, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2330) },
                    { 72, 18, 20, "Done", 4, new DateTime(2024, 1, 9, 0, 0, 33, 982, DateTimeKind.Local).AddTicks(2330) }
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
