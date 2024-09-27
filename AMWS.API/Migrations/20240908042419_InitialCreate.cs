using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWMS.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeSent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageType = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NotificationType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangePasswordRequired = table.Column<bool>(type: "bit", nullable: false),
                    LastPasswordChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PasswordChangedBy = table.Column<int>(type: "int", nullable: false),
                    PasswordChangeVerificationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerificationCodeEffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerificationCodeExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerificationCodeUsageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EntityType = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserAudit",
                columns: table => new
                {
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactID = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Company_Contact_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contact",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Area_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Area_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Carrier",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrier", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Carrier_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Carrier_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumericCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Country_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Country_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Currency_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Currency_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customer_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Customer_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Department_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Department_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Designation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Designation_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Designation_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DockStatus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DockStatus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DockStatus_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DockStatus_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EntityType = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Driver_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Driver_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Employee_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderStatus_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderStatus_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductCategory_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductCategory_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderStatus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderStatus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderStatus_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PurchaseOrderStatus_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Region_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Region_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Supplier_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Supplier_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AreaPurpose",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaID = table.Column<int>(type: "int", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaPurpose", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AreaPurpose_Area_AreaID",
                        column: x => x.AreaID,
                        principalTable: "Area",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategoryID = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryID",
                        column: x => x.ProductCategoryID,
                        principalTable: "ProductCategory",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Product_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Product_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegionID = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Location_Region_RegionID",
                        column: x => x.RegionID,
                        principalTable: "Region",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Location_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Location_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductCodes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CodeString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCodes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductCodes_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductCodes_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductCodes_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ReceiptLine",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PONumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POLineNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ReceiptNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityOrdered = table.Column<int>(type: "int", nullable: false),
                    PreviousReceipts = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    AddToInventory = table.Column<bool>(type: "bit", nullable: false),
                    LineStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptLine", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReceiptLine_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CompanyAddress",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAddress", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CompanyAddress_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CompanyAddress_Location_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Location",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CompanyAddress_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CompanyAddress_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Location_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Location",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerAddress_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerAddress_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SupplierAddress",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierAddress", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SupplierAddress_Location_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Location",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SupplierAddress_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SupplierAddress_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SupplierAddress_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Warehouse_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Warehouse_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Warehouse_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vendor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    ShipToAddressID = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_CompanyAddress_ShipToAddressID",
                        column: x => x.ShipToAddressID,
                        principalTable: "CompanyAddress",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Currency_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "Currency",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_PurchaseOrderStatus_StatusID",
                        column: x => x.StatusID,
                        principalTable: "PurchaseOrderStatus",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryDateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryDateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiptNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliverToAddressID = table.Column<int>(type: "int", nullable: false),
                    PackingSlipNo = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    ReceivedByID = table.Column<int>(type: "int", nullable: false),
                    CartonCount = table.Column<int>(type: "int", nullable: false),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Delivery_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Delivery_CustomerAddress_DeliverToAddressID",
                        column: x => x.DeliverToAddressID,
                        principalTable: "CustomerAddress",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Delivery_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Delivery_Employee_ReceivedByID",
                        column: x => x.ReceivedByID,
                        principalTable: "Employee",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Delivery_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Delivery_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Delivery_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Dock",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DockName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DockType = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dock", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dock_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Dock_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Dock_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PackingArea",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    AreaID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackingArea", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PackingArea_Area_AreaID",
                        column: x => x.AreaID,
                        principalTable: "Area",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PackingArea_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PickingArea",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    AreaID = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickingArea", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PickingArea_Area_AreaID",
                        column: x => x.AreaID,
                        principalTable: "Area",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PickingArea_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "RequestTransfer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FromWarehouseID = table.Column<int>(type: "int", nullable: false),
                    ToWarehouseID = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTransfer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RequestTransfer_Warehouse_FromWarehouseID",
                        column: x => x.FromWarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RequestTransfer_Warehouse_ToWarehouseID",
                        column: x => x.ToWarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    CurrentStock = table.Column<int>(type: "int", nullable: false),
                    DamagedStock = table.Column<int>(type: "int", nullable: false),
                    StockLimit = table.Column<int>(type: "int", nullable: false),
                    ThreshHold = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastPurchaseOrderID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    RecentCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LastStockUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Inventory_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Inventory_PurchaseOrder_LastPurchaseOrderID",
                        column: x => x.LastPurchaseOrderID,
                        principalTable: "PurchaseOrder",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Inventory_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Inventory_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Inventory_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrderID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    GoodsStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivedByID = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiptLine = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    ReceiptDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Receipt_Employee_ReceivedByID",
                        column: x => x.ReceivedByID,
                        principalTable: "Employee",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Receipt_PurchaseOrder_PurchaseOrderID",
                        column: x => x.PurchaseOrderID,
                        principalTable: "PurchaseOrder",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Receipt_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DeliveryItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    IsAdded = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DeliveryItem_Delivery_DeliveryID",
                        column: x => x.DeliveryID,
                        principalTable: "Delivery",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DeliveryItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DeliveryItem_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DeliveryItem_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Docking",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    DockID = table.Column<int>(type: "int", nullable: false),
                    SlotLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    DockStatusID = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docking", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Docking_DockStatus_DockStatusID",
                        column: x => x.DockStatusID,
                        principalTable: "DockStatus",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Docking_Dock_DockID",
                        column: x => x.DockID,
                        principalTable: "Dock",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Docking_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrderID = table.Column<int>(type: "int", nullable: false),
                    CarrierID = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    DockID = table.Column<int>(type: "int", nullable: false),
                    StartLegLocationID = table.Column<int>(type: "int", nullable: false),
                    EndLegLocationID = table.Column<int>(type: "int", nullable: false),
                    StartDateExpected = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDateActual = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateExpected = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateActual = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OtherDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shipment_Carrier_CarrierID",
                        column: x => x.CarrierID,
                        principalTable: "Carrier",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Shipment_Dock_DockID",
                        column: x => x.DockID,
                        principalTable: "Dock",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Shipment_Location_EndLegLocationID",
                        column: x => x.EndLegLocationID,
                        principalTable: "Location",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Shipment_Location_StartLegLocationID",
                        column: x => x.StartLegLocationID,
                        principalTable: "Location",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Shipment_PurchaseOrder_PurchaseOrderID",
                        column: x => x.PurchaseOrderID,
                        principalTable: "PurchaseOrder",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Shipment_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Shipment_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Packing",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    PackingAreaID = table.Column<int>(type: "int", nullable: false),
                    BegunAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BatchNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoneByID = table.Column<int>(type: "int", nullable: false),
                    DockID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packing", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Packing_Dock_DockID",
                        column: x => x.DockID,
                        principalTable: "Dock",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Packing_Employee_DoneByID",
                        column: x => x.DoneByID,
                        principalTable: "Employee",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Packing_PackingArea_PackingAreaID",
                        column: x => x.PackingAreaID,
                        principalTable: "PackingArea",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Packing_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "RequestStock",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequesterID = table.Column<int>(type: "int", nullable: false),
                    BatchNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    CancellationReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    FromWarehouseID = table.Column<int>(type: "int", nullable: false),
                    PackingAreaID = table.Column<int>(type: "int", nullable: false),
                    ConfirmedByID = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStock", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RequestStock_Employee_ConfirmedByID",
                        column: x => x.ConfirmedByID,
                        principalTable: "Employee",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RequestStock_Employee_RequesterID",
                        column: x => x.RequesterID,
                        principalTable: "Employee",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RequestStock_PackingArea_PackingAreaID",
                        column: x => x.PackingAreaID,
                        principalTable: "PackingArea",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RequestStock_Warehouse_FromWarehouseID",
                        column: x => x.FromWarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Picking",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    PickingAreaID = table.Column<int>(type: "int", nullable: false),
                    BegunAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BatchNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoneByID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picking", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Picking_Employee_DoneByID",
                        column: x => x.DoneByID,
                        principalTable: "Employee",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Picking_PickingArea_PickingAreaID",
                        column: x => x.PickingAreaID,
                        principalTable: "PickingArea",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Picking_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SendStock",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestTransferID = table.Column<int>(type: "int", nullable: false),
                    SendStockDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SentByID = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendStock", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SendStock_Employee_SentByID",
                        column: x => x.SentByID,
                        principalTable: "Employee",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SendStock_RequestTransfer_RequestTransferID",
                        column: x => x.RequestTransferID,
                        principalTable: "RequestTransfer",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "StockMovement",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestTransferID = table.Column<int>(type: "int", nullable: false),
                    MovementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BatchNo = table.Column<int>(type: "int", nullable: false),
                    FromLocationID = table.Column<int>(type: "int", nullable: false),
                    ToLocationID = table.Column<int>(type: "int", nullable: false),
                    FromWarehouseID = table.Column<int>(type: "int", nullable: false),
                    ToWarehouseID = table.Column<int>(type: "int", nullable: false),
                    MovementType = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PreparedByID = table.Column<int>(type: "int", nullable: false),
                    AuthorizedByID = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockMovement", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StockMovement_Employee_AuthorizedByID",
                        column: x => x.AuthorizedByID,
                        principalTable: "Employee",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_StockMovement_Employee_PreparedByID",
                        column: x => x.PreparedByID,
                        principalTable: "Employee",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_StockMovement_Location_FromLocationID",
                        column: x => x.FromLocationID,
                        principalTable: "Location",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_StockMovement_Location_ToLocationID",
                        column: x => x.ToLocationID,
                        principalTable: "Location",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_StockMovement_RequestTransfer_RequestTransferID",
                        column: x => x.RequestTransferID,
                        principalTable: "RequestTransfer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_StockMovement_Warehouse_FromWarehouseID",
                        column: x => x.FromWarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_StockMovement_Warehouse_ToWarehouseID",
                        column: x => x.ToWarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ReceiveStock",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiverID = table.Column<int>(type: "int", nullable: false),
                    ReceiptNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiptDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    RequestID = table.Column<int>(type: "int", nullable: false),
                    RequestTransferID = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveStock", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReceiveStock_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReceiveStock_Employee_ReceiverID",
                        column: x => x.ReceiverID,
                        principalTable: "Employee",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReceiveStock_RequestStock_RequestID",
                        column: x => x.RequestID,
                        principalTable: "RequestStock",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReceiveStock_RequestTransfer_RequestTransferID",
                        column: x => x.RequestTransferID,
                        principalTable: "RequestTransfer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReceiveStock_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizedByID = table.Column<int>(type: "int", nullable: false),
                    CustomerPO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    SalesPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuoteNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipToAddressID = table.Column<int>(type: "int", nullable: false),
                    InvoiceToAddressID = table.Column<int>(type: "int", nullable: false),
                    OrderStatusID = table.Column<int>(type: "int", nullable: false),
                    CustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickingID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_CustomerAddress_InvoiceToAddressID",
                        column: x => x.InvoiceToAddressID,
                        principalTable: "CustomerAddress",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Order_CustomerAddress_ShipToAddressID",
                        column: x => x.ShipToAddressID,
                        principalTable: "CustomerAddress",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Order_Employee_AuthorizedByID",
                        column: x => x.AuthorizedByID,
                        principalTable: "Employee",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Order_OrderStatus_OrderStatusID",
                        column: x => x.OrderStatusID,
                        principalTable: "OrderStatus",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Order_Picking_PickingID",
                        column: x => x.PickingID,
                        principalTable: "Picking",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Order_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Order_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderItem_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderItem_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderItem_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Area_CreatedByID",
                table: "Area",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Area_ModifiedByID",
                table: "Area",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_AreaPurpose_AreaID",
                table: "AreaPurpose",
                column: "AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_Carrier_CreatedByID",
                table: "Carrier",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Carrier_ModifiedByID",
                table: "Carrier",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Company_ContactID",
                table: "Company",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddress_CompanyID",
                table: "CompanyAddress",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddress_CountryID",
                table: "CompanyAddress",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddress_CreatedByID",
                table: "CompanyAddress",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddress_ModifiedByID",
                table: "CompanyAddress",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Country_CreatedByID",
                table: "Country",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Country_ModifiedByID",
                table: "Country",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Currency_CreatedByID",
                table: "Currency",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Currency_ModifiedByID",
                table: "Currency",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CreatedByID",
                table: "Customer",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ModifiedByID",
                table: "Customer",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CountryID",
                table: "CustomerAddress",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CreatedByID",
                table: "CustomerAddress",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CustomerID",
                table: "CustomerAddress",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_ModifiedByID",
                table: "CustomerAddress",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_CompanyID",
                table: "Delivery",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_CreatedByID",
                table: "Delivery",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_CustomerID",
                table: "Delivery",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_DeliverToAddressID",
                table: "Delivery",
                column: "DeliverToAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_ModifiedByID",
                table: "Delivery",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_ReceivedByID",
                table: "Delivery",
                column: "ReceivedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_SupplierID",
                table: "Delivery",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_CreatedByID",
                table: "DeliveryItem",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_DeliveryID",
                table: "DeliveryItem",
                column: "DeliveryID");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_ModifiedByID",
                table: "DeliveryItem",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_ProductID",
                table: "DeliveryItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_CreatedByID",
                table: "Department",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ModifiedByID",
                table: "Department",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Designation_CreatedByID",
                table: "Designation",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Designation_ModifiedByID",
                table: "Designation",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Dock_CreatedByID",
                table: "Dock",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Dock_ModifiedByID",
                table: "Dock",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Dock_WarehouseID",
                table: "Dock",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Docking_DockID",
                table: "Docking",
                column: "DockID");

            migrationBuilder.CreateIndex(
                name: "IX_Docking_DockStatusID",
                table: "Docking",
                column: "DockStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Docking_WarehouseID",
                table: "Docking",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_DockStatus_CreatedByID",
                table: "DockStatus",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_DockStatus_ModifiedByID",
                table: "DockStatus",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_CreatedByID",
                table: "Driver",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_ModifiedByID",
                table: "Driver",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CreatedByID",
                table: "Employee",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ModifiedByID",
                table: "Employee",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_CreatedByID",
                table: "Inventory",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_LastPurchaseOrderID",
                table: "Inventory",
                column: "LastPurchaseOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ModifiedByID",
                table: "Inventory",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ProductID",
                table: "Inventory",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_WarehouseID",
                table: "Inventory",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Location_CreatedByID",
                table: "Location",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Location_ModifiedByID",
                table: "Location",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Location_RegionID",
                table: "Location",
                column: "RegionID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_AuthorizedByID",
                table: "Order",
                column: "AuthorizedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CreatedByID",
                table: "Order",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_InvoiceToAddressID",
                table: "Order",
                column: "InvoiceToAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ModifiedByID",
                table: "Order",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderStatusID",
                table: "Order",
                column: "OrderStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PickingID",
                table: "Order",
                column: "PickingID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShipToAddressID",
                table: "Order",
                column: "ShipToAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_CreatedByID",
                table: "OrderItem",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ModifiedByID",
                table: "OrderItem",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductID",
                table: "OrderItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_WarehouseID",
                table: "OrderItem",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatus_CreatedByID",
                table: "OrderStatus",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatus_ModifiedByID",
                table: "OrderStatus",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Packing_DockID",
                table: "Packing",
                column: "DockID");

            migrationBuilder.CreateIndex(
                name: "IX_Packing_DoneByID",
                table: "Packing",
                column: "DoneByID");

            migrationBuilder.CreateIndex(
                name: "IX_Packing_PackingAreaID",
                table: "Packing",
                column: "PackingAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_Packing_ProductID",
                table: "Packing",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_PackingArea_AreaID",
                table: "PackingArea",
                column: "AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_PackingArea_WarehouseID",
                table: "PackingArea",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Picking_DoneByID",
                table: "Picking",
                column: "DoneByID");

            migrationBuilder.CreateIndex(
                name: "IX_Picking_PickingAreaID",
                table: "Picking",
                column: "PickingAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_Picking_ProductID",
                table: "Picking",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_PickingArea_AreaID",
                table: "PickingArea",
                column: "AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_PickingArea_WarehouseID",
                table: "PickingArea",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CreatedByID",
                table: "Product",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ModifiedByID",
                table: "Product",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryID",
                table: "Product",
                column: "ProductCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_CreatedByID",
                table: "ProductCategory",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_ModifiedByID",
                table: "ProductCategory",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCodes_CreatedByID",
                table: "ProductCodes",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCodes_ModifiedByID",
                table: "ProductCodes",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCodes_ProductId",
                table: "ProductCodes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_CurrencyID",
                table: "PurchaseOrder",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_ShipToAddressID",
                table: "PurchaseOrder",
                column: "ShipToAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_StatusID",
                table: "PurchaseOrder",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderStatus_CreatedByID",
                table: "PurchaseOrderStatus",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderStatus_ModifiedByID",
                table: "PurchaseOrderStatus",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_PurchaseOrderID",
                table: "Receipt",
                column: "PurchaseOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_ReceivedByID",
                table: "Receipt",
                column: "ReceivedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_SupplierID",
                table: "Receipt",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptLine_ProductID",
                table: "ReceiptLine",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveStock_CustomerID",
                table: "ReceiveStock",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveStock_ReceiverID",
                table: "ReceiveStock",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveStock_RequestID",
                table: "ReceiveStock",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveStock_RequestTransferID",
                table: "ReceiveStock",
                column: "RequestTransferID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveStock_WarehouseID",
                table: "ReceiveStock",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Region_CreatedByID",
                table: "Region",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Region_ModifiedByID",
                table: "Region",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStock_ConfirmedByID",
                table: "RequestStock",
                column: "ConfirmedByID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStock_FromWarehouseID",
                table: "RequestStock",
                column: "FromWarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStock_PackingAreaID",
                table: "RequestStock",
                column: "PackingAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStock_RequesterID",
                table: "RequestStock",
                column: "RequesterID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestTransfer_FromWarehouseID",
                table: "RequestTransfer",
                column: "FromWarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestTransfer_ToWarehouseID",
                table: "RequestTransfer",
                column: "ToWarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_SendStock_RequestTransferID",
                table: "SendStock",
                column: "RequestTransferID");

            migrationBuilder.CreateIndex(
                name: "IX_SendStock_SentByID",
                table: "SendStock",
                column: "SentByID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_CarrierID",
                table: "Shipment",
                column: "CarrierID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_CreatedByID",
                table: "Shipment",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_DockID",
                table: "Shipment",
                column: "DockID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_EndLegLocationID",
                table: "Shipment",
                column: "EndLegLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_ModifiedByID",
                table: "Shipment",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_PurchaseOrderID",
                table: "Shipment",
                column: "PurchaseOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_StartLegLocationID",
                table: "Shipment",
                column: "StartLegLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_AuthorizedByID",
                table: "StockMovement",
                column: "AuthorizedByID");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_FromLocationID",
                table: "StockMovement",
                column: "FromLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_FromWarehouseID",
                table: "StockMovement",
                column: "FromWarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_PreparedByID",
                table: "StockMovement",
                column: "PreparedByID");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_RequestTransferID",
                table: "StockMovement",
                column: "RequestTransferID");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_ToLocationID",
                table: "StockMovement",
                column: "ToLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_ToWarehouseID",
                table: "StockMovement",
                column: "ToWarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_CreatedByID",
                table: "Supplier",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_ModifiedByID",
                table: "Supplier",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierAddress_CountryID",
                table: "SupplierAddress",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierAddress_CreatedByID",
                table: "SupplierAddress",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierAddress_ModifiedByID",
                table: "SupplierAddress",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierAddress_SupplierID",
                table: "SupplierAddress",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedByID",
                table: "User",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_CreatedByID",
                table: "Warehouse",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_LocationID",
                table: "Warehouse",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_ModifiedByID",
                table: "Warehouse",
                column: "ModifiedByID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaPurpose");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "DeliveryItem");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Designation");

            migrationBuilder.DropTable(
                name: "Docking");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "NotificationType");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Packing");

            migrationBuilder.DropTable(
                name: "ProductCodes");

            migrationBuilder.DropTable(
                name: "Receipt");

            migrationBuilder.DropTable(
                name: "ReceiptLine");

            migrationBuilder.DropTable(
                name: "ReceiveStock");

            migrationBuilder.DropTable(
                name: "SendStock");

            migrationBuilder.DropTable(
                name: "Shipment");

            migrationBuilder.DropTable(
                name: "StockMovement");

            migrationBuilder.DropTable(
                name: "SupplierAddress");

            migrationBuilder.DropTable(
                name: "UserAudit");

            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "DockStatus");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "RequestStock");

            migrationBuilder.DropTable(
                name: "Carrier");

            migrationBuilder.DropTable(
                name: "Dock");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "RequestTransfer");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "Picking");

            migrationBuilder.DropTable(
                name: "PackingArea");

            migrationBuilder.DropTable(
                name: "CompanyAddress");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "PurchaseOrderStatus");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "PickingArea");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
