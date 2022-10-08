using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations.Ms
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemovedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupClaims",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    ClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupClaims", x => new { x.GroupId, x.ClaimId });
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemovedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemovedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageTemplate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileLogins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Provider = table.Column<int>(type: "int", nullable: false),
                    ExternalUserId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Code = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsSend = table.Column<bool>(type: "bit", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemovedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileLogins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemovedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LangId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemovedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => new { x.UserId, x.ClaimId });
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => new { x.UserId, x.GroupId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitizenId = table.Column<long>(type: "bigint", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhones = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UpdateContactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Personnels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CountyId = table.Column<int>(type: "int", nullable: false),
                    NeighbourhoodId = table.Column<int>(type: "int", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    IsUser = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemovedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personnels_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedBy", "CreationDate", "IsRemoved", "ModifiedBy", "ModifiedDate", "Name", "RemovedBy", "RemovedDate", "Status" },
                values: new object[,]
                {
                    { 1, "tr-TR", 0, new DateTime(2022, 10, 8, 23, 18, 37, 140, DateTimeKind.Local).AddTicks(9682), false, null, null, "Türkçe", null, null, true },
                    { 2, "en-US", 0, new DateTime(2022, 10, 8, 23, 18, 37, 143, DateTimeKind.Local).AddTicks(8273), false, null, null, "English", null, null, true }
                });

            migrationBuilder.InsertData(
                table: "Translates",
                columns: new[] { "Id", "Code", "CreatedBy", "CreationDate", "IsRemoved", "LangId", "ModifiedBy", "ModifiedDate", "RemovedBy", "RemovedDate", "Status", "Value" },
                values: new object[,]
                {
                    { 89, "Save", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9166), false, 1, null, null, null, null, true, "Kaydet" },
                    { 90, "Save", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9168), false, 2, null, null, null, null, true, "Save" },
                    { 91, "GroupName", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9170), false, 1, null, null, null, null, true, "Grup Adı" },
                    { 92, "GroupName", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9172), false, 2, null, null, null, null, true, "Group Name" },
                    { 93, "FullName", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9173), false, 1, null, null, null, null, true, "Tam Adı" },
                    { 94, "FullName", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9211), false, 2, null, null, null, null, true, "Full Name" },
                    { 95, "Address", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9213), false, 1, null, null, null, null, true, "Adres" },
                    { 96, "Address", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9215), false, 2, null, null, null, null, true, "Address" },
                    { 97, "Notes", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9217), false, 1, null, null, null, null, true, "Notlar" },
                    { 98, "Notes", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9219), false, 2, null, null, null, null, true, "Notes" },
                    { 99, "ConfirmPassword", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9221), false, 1, null, null, null, null, true, "Parolayı Doğrula" },
                    { 100, "ConfirmPassword", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9222), false, 2, null, null, null, null, true, "Confirm Password" },
                    { 101, "Code", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9224), false, 1, null, null, null, null, true, "Kod" },
                    { 88, "ChangePassword", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9165), false, 2, null, null, null, null, true, "Change Password" },
                    { 87, "ChangePassword", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9163), false, 1, null, null, null, null, true, "Parola Değiştir" },
                    { 86, "NewPassword", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9161), false, 2, null, null, null, null, true, "New Password:" },
                    { 85, "NewPassword", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9159), false, 1, null, null, null, null, true, "Yeni Parola:" },
                    { 71, "PasswordSpecialCharacter", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9135), false, 1, null, null, null, null, true, "En Az 1 Simge İçermelidir!" },
                    { 72, "PasswordSpecialCharacter", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9136), false, 2, null, null, null, null, true, "Must Contain At Least 1 Symbol!" },
                    { 73, "SendPassword", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9138), false, 1, null, null, null, null, true, "Yeni Parolanız E-Posta Adresinize Gönderildi." },
                    { 74, "SendPassword", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9140), false, 2, null, null, null, null, true, "Your new password has been sent to your e-mail address." },
                    { 75, "InvalidCode", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9142), false, 1, null, null, null, null, true, "Geçersiz Bir Kod Girdiniz!" },
                    { 76, "InvalidCode", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9144), false, 2, null, null, null, null, true, "You Entered An Invalid Code!" },
                    { 102, "Code", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9226), false, 2, null, null, null, null, true, "Code" },
                    { 77, "SmsServiceNotFound", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9145), false, 1, null, null, null, null, true, "SMS Servisine Ulaşılamıyor." },
                    { 79, "TrueButCellPhone", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9149), false, 1, null, null, null, null, true, "Bilgiler doğru. Cep telefonu gerekiyor." },
                    { 80, "TrueButCellPhone", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9151), false, 2, null, null, null, null, true, "The information is correct. Cell phone is required." },
                    { 81, "TokenProviderException", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9152), false, 1, null, null, null, null, true, "Token Provider boş olamaz!" },
                    { 82, "TokenProviderException", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9154), false, 2, null, null, null, null, true, "Token Provider cannot be empty!" },
                    { 83, "Unknown", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9156), false, 1, null, null, null, null, true, "Bilinmiyor!" },
                    { 84, "Unknown", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9158), false, 2, null, null, null, null, true, "Unknown!" },
                    { 78, "SmsServiceNotFound", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9147), false, 2, null, null, null, null, true, "Unable to Reach SMS Service." },
                    { 103, "Alias", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9228), false, 1, null, null, null, null, true, "Görünen Ad" },
                    { 104, "Alias", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9230), false, 2, null, null, null, null, true, "Alias" },
                    { 105, "Description", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9232), false, 1, null, null, null, null, true, "Açıklama" },
                    { 136, "LogList", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9291), false, 2, null, null, null, null, true, "LogList" },
                    { 135, "LogList", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9289), false, 1, null, null, null, null, true, "İşlem Kütüğü" },
                    { 134, "TranslateList", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9287), false, 2, null, null, null, null, true, "Translate List" },
                    { 133, "TranslateList", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9285), false, 1, null, null, null, null, true, "Dil Çeviri Listesi" },
                    { 132, "LanguageList", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9284), false, 2, null, null, null, null, true, "Language List" }
                });

            migrationBuilder.InsertData(
                table: "Translates",
                columns: new[] { "Id", "Code", "CreatedBy", "CreationDate", "IsRemoved", "LangId", "ModifiedBy", "ModifiedDate", "RemovedBy", "RemovedDate", "Status", "Value" },
                values: new object[,]
                {
                    { 131, "LanguageList", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9282), false, 1, null, null, null, null, true, "Dil Listesi" },
                    { 130, "OperationClaimList", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9280), false, 2, null, null, null, null, true, "OperationClaim List" },
                    { 129, "OperationClaimList", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9276), false, 1, null, null, null, null, true, "Yetki Listesi" },
                    { 128, "UserList", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9274), false, 2, null, null, null, null, true, "User List" },
                    { 127, "UserList", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9273), false, 1, null, null, null, null, true, "Kullanıcı Listesi" },
                    { 126, "Add", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9271), false, 2, null, null, null, null, true, "Add" },
                    { 125, "Add", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9269), false, 1, null, null, null, null, true, "Ekle" },
                    { 124, "GrupPermissions", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9267), false, 2, null, null, null, null, true, "Grup Permissions" },
                    { 123, "GrupPermissions", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9265), false, 1, null, null, null, null, true, "Grup Yetkileri" },
                    { 122, "GroupList", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9263), false, 2, null, null, null, null, true, "Group List" },
                    { 121, "GroupList", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9262), false, 1, null, null, null, null, true, "Grup Listesi" },
                    { 120, "Permissions", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9260), false, 2, null, null, null, null, true, "İzinler" },
                    { 106, "Description", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9234), false, 2, null, null, null, null, true, "Description" },
                    { 107, "Value", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9235), false, 1, null, null, null, null, true, "Değer" },
                    { 108, "Value", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9239), false, 2, null, null, null, null, true, "Value" },
                    { 109, "LangCode", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9240), false, 1, null, null, null, null, true, "Dil Kodu" },
                    { 110, "LangCode", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9242), false, 2, null, null, null, null, true, "Lang Code" },
                    { 111, "Name", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9244), false, 1, null, null, null, null, true, "Adı" },
                    { 70, "PasswordDigit", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9133), false, 2, null, null, null, null, true, "It Must Contain At Least 1 Digit!" },
                    { 112, "Name", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9246), false, 2, null, null, null, null, true, "Name" },
                    { 114, "MobilePhones", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9249), false, 2, null, null, null, null, true, "Mobile Phone" },
                    { 115, "NoRecordsFound", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9251), false, 1, null, null, null, null, true, "Kayıt Bulunamadı" },
                    { 116, "NoRecordsFound", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9253), false, 2, null, null, null, null, true, "No Records Found" },
                    { 117, "Required", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9255), false, 1, null, null, null, null, true, "Bu alan zorunludur!" },
                    { 118, "Required", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9256), false, 2, null, null, null, null, true, "This field is required!" },
                    { 119, "Permissions", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9258), false, 1, null, null, null, null, true, "Permissions" },
                    { 113, "MobilePhones", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9247), false, 1, null, null, null, null, true, "Cep Telefonu" },
                    { 69, "PasswordDigit", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9131), false, 1, null, null, null, null, true, "En Az 1 Rakam İçermelidir!" },
                    { 68, "PasswordLowercaseLetter", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9129), false, 2, null, null, null, null, true, "Must Contain At Least 1 Lowercase Letter!" },
                    { 67, "PasswordLowercaseLetter", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9127), false, 1, null, null, null, null, true, "En Az 1 Küçük Harf İçermelidir!" },
                    { 31, "Added", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8977), false, 1, null, null, null, null, true, "Başarıyla Eklendi." },
                    { 30, "AppMenu", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8975), false, 2, null, null, null, null, true, "Application" },
                    { 29, "AppMenu", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8973), false, 1, null, null, null, null, true, "Uygulama" },
                    { 28, "Management", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8971), false, 2, null, null, null, null, true, "Management" },
                    { 27, "Management", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8969), false, 1, null, null, null, null, true, "Yönetim" },
                    { 26, "TranslateWords", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8968), false, 2, null, null, null, null, true, "Translate Words" },
                    { 25, "TranslateWords", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8966), false, 1, null, null, null, null, true, "Dil Çevirileri" },
                    { 24, "Languages", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8964), false, 2, null, null, null, null, true, "Languages" },
                    { 23, "Languages", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8962), false, 1, null, null, null, null, true, "Diller" },
                    { 22, "OperationClaim", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8961), false, 2, null, null, null, null, true, "Operation Claim" },
                    { 21, "OperationClaim", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8959), false, 1, null, null, null, null, true, "Operasyon Yetkileri" },
                    { 20, "Groups", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8957), false, 2, null, null, null, null, true, "Groups" }
                });

            migrationBuilder.InsertData(
                table: "Translates",
                columns: new[] { "Id", "Code", "CreatedBy", "CreationDate", "IsRemoved", "LangId", "ModifiedBy", "ModifiedDate", "RemovedBy", "RemovedDate", "Status", "Value" },
                values: new object[,]
                {
                    { 19, "Users", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8955), false, 2, null, null, null, null, true, "Users" },
                    { 18, "Create", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8953), false, 2, null, null, null, null, true, "Create" },
                    { 17, "UsersClaims", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8950), false, 2, null, null, null, null, true, "User's Claims" },
                    { 16, "UsersGroups", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8948), false, 2, null, null, null, null, true, "User's Groups" },
                    { 15, "Delete", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8947), false, 2, null, null, null, null, true, "Delete" },
                    { 1, "Login", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(7617), false, 1, null, null, null, null, true, "Giriş" },
                    { 2, "Email", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8903), false, 1, null, null, null, null, true, "E posta" },
                    { 3, "Password", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8912), false, 1, null, null, null, null, true, "Parola" },
                    { 4, "Update", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8915), false, 1, null, null, null, null, true, "Güncelle" },
                    { 5, "Delete", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8919), false, 1, null, null, null, null, true, "Sil" },
                    { 6, "UsersGroups", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8929), false, 1, null, null, null, null, true, "Kullanıcının Grupları" },
                    { 32, "Added", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8979), false, 2, null, null, null, null, true, "Successfully Added." },
                    { 7, "UsersClaims", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8931), false, 1, null, null, null, null, true, "Kullanıcının Yetkileri" },
                    { 9, "Users", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8935), false, 1, null, null, null, null, true, "Kullanıcılar" },
                    { 10, "Groups", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8938), false, 1, null, null, null, null, true, "Gruplar" },
                    { 11, "Login", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8940), false, 2, null, null, null, null, true, "Login" },
                    { 12, "Email", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8941), false, 2, null, null, null, null, true, "Email" },
                    { 13, "Password", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8943), false, 2, null, null, null, null, true, "Password" },
                    { 14, "Update", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8945), false, 2, null, null, null, null, true, "Update" },
                    { 8, "Create", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8933), false, 1, null, null, null, null, true, "Yeni" },
                    { 137, "DeleteConfirm", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9292), false, 1, null, null, null, null, true, "Emin misiniz?" },
                    { 33, "Updated", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8981), false, 1, null, null, null, null, true, "Başarıyla Güncellendi." },
                    { 35, "Deleted", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9064), false, 1, null, null, null, null, true, "Başarıyla Silindi." },
                    { 66, "PasswordUppercaseLetter", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9125), false, 2, null, null, null, null, true, "Must Contain At Least 1 Capital Letter!" },
                    { 65, "PasswordUppercaseLetter", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9122), false, 1, null, null, null, null, true, "En Az 1 Büyük Harf İçermelidir!" },
                    { 64, "PasswordLength", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9120), false, 2, null, null, null, null, true, "Must be at least 8 characters long! " },
                    { 63, "PasswordLength", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9118), false, 1, null, null, null, null, true, "Minimum 8 Karakter Uzunluğunda Olmalıdır!" },
                    { 62, "PasswordEmpty", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9116), false, 2, null, null, null, null, true, "Password can not be empty!" },
                    { 61, "PasswordEmpty", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9114), false, 1, null, null, null, null, true, "Parola boş olamaz!" },
                    { 60, "CID", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9113), false, 2, null, null, null, null, true, "Citizenship Number" },
                    { 59, "CID", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9111), false, 1, null, null, null, null, true, "Vatandaşlık No" },
                    { 58, "WrongCID", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9109), false, 2, null, null, null, null, true, "Citizenship Number Not Found In Our System. Please Create New Registration!" },
                    { 57, "WrongCID", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9107), false, 1, null, null, null, null, true, "Vatandaşlık No Sistemimizde Bulunamadı. Lütfen Yeni Kayıt Oluşturun!" },
                    { 56, "NameAlreadyExist", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9106), false, 2, null, null, null, null, true, "The Object You Are Trying To Create Already Exists." },
                    { 55, "NameAlreadyExist", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9104), false, 1, null, null, null, null, true, "Oluşturmaya Çalıştığınız Nesne Zaten Var." },
                    { 54, "SendMobileCode", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9102), false, 2, null, null, null, null, true, "Please Enter The Code Sent To You By SMS!" },
                    { 53, "SendMobileCode", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9100), false, 1, null, null, null, null, true, "Lütfen Size SMS Olarak Gönderilen Kodu Girin!" },
                    { 52, "SuccessfulLogin", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9099), false, 2, null, null, null, null, true, "Login to the system is successful." },
                    { 51, "SuccessfulLogin", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9097), false, 1, null, null, null, null, true, "Sisteme giriş başarılı." },
                    { 50, "PasswordError", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9095), false, 2, null, null, null, null, true, "Credentials Failed to Authenticate, Username and / or password incorrect." },
                    { 36, "Deleted", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9066), false, 2, null, null, null, null, true, "Successfully Deleted." },
                    { 37, "OperationClaimExists", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9068), false, 1, null, null, null, null, true, "Bu operasyon izni zaten mevcut." }
                });

            migrationBuilder.InsertData(
                table: "Translates",
                columns: new[] { "Id", "Code", "CreatedBy", "CreationDate", "IsRemoved", "LangId", "ModifiedBy", "ModifiedDate", "RemovedBy", "RemovedDate", "Status", "Value" },
                values: new object[,]
                {
                    { 38, "OperationClaimExists", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9070), false, 2, null, null, null, null, true, "This operation permit already exists." },
                    { 39, "StringLengthMustBeGreaterThanThree", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9072), false, 1, null, null, null, null, true, "Lütfen En Az 3 Karakterden Oluşan Bir İfade Girin." },
                    { 40, "StringLengthMustBeGreaterThanThree", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9074), false, 2, null, null, null, null, true, "Please Enter A Phrase Of At Least 3 Characters." },
                    { 41, "CouldNotBeVerifyCid", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9075), false, 1, null, null, null, null, true, "Kimlik No Doğrulanamadı." },
                    { 34, "Updated", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9062), false, 2, null, null, null, null, true, "Successfully Updated." },
                    { 42, "CouldNotBeVerifyCid", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9077), false, 2, null, null, null, null, true, "Could not be verify Citizen Id" },
                    { 44, "VerifyCid", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9081), false, 2, null, null, null, null, true, "Verify Citizen Id" },
                    { 45, "AuthorizationsDenied", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9084), false, 1, null, null, null, null, true, "Yetkiniz olmayan bir alana girmeye çalıştığınız tespit edildi." },
                    { 46, "AuthorizationsDenied", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9086), false, 2, null, null, null, null, true, "It has been detected that you are trying to enter an area that you do not have authorization." },
                    { 47, "UserNotFound", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9087), false, 1, null, null, null, null, true, "Kimlik Bilgileri Doğrulanamadı. Lütfen Yeni Kayıt Ekranını kullanın." },
                    { 48, "UserNotFound", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9089), false, 2, null, null, null, null, true, "Credentials Could Not Verify. Please use the New Registration Screen." },
                    { 49, "PasswordError", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9091), false, 1, null, null, null, null, true, "Kimlik Bilgileri Doğrulanamadı, Kullanıcı adı ve/veya parola hatalı." },
                    { 43, "VerifyCid", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9079), false, 1, null, null, null, null, true, "Kimlik No Doğrulandı." },
                    { 138, "DeleteConfirm", 0, new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9294), false, 2, null, null, null, null, true, "Are you sure?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MobileLogins_ExternalUserId_Provider",
                table: "MobileLogins",
                columns: new[] { "ExternalUserId", "Provider" });

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_DepartmentId",
                table: "Personnels",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CitizenId",
                table: "Users",
                column: "CitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MobilePhones",
                table: "Users",
                column: "MobilePhones");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupClaims");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "MobileLogins");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Personnels");

            migrationBuilder.DropTable(
                name: "Translates");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
