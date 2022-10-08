using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations.Ms
{
    public partial class AddNewConf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Personnels",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NeighbourhoodId",
                table: "Personnels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Personnels",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdentityNumber",
                table: "Personnels",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullAddress",
                table: "Personnels",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Personnels",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountyId",
                table: "Personnels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Personnels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Personnels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine",
                table: "Personnels",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 269, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 270, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 43, 53, 284, DateTimeKind.Local).AddTicks(8464));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Personnels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "NeighbourhoodId",
                table: "Personnels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Personnels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "IdentityNumber",
                table: "Personnels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FullAddress",
                table: "Personnels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Personnels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "CountyId",
                table: "Personnels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Personnels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Personnels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine",
                table: "Personnels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 140, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 143, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreationDate",
                value: new DateTime(2022, 10, 8, 23, 18, 37, 155, DateTimeKind.Local).AddTicks(9294));
        }
    }
}
