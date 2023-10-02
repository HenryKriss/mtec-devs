using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtecDevs.Migrations
{
    public partial class populardados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47869ccd-a651-432b-9479-2c39421f15b2", "a1084ebc-f3e5-4d35-a839-6990d57e18b6", "Moderador", "MODERADOR" },
                    { "ad96bc79-c2ff-42fa-a2d2-88cdb5740404", "ce609445-05de-47ad-b486-16b32c986e48", "Usuário", "USUÁRIO" },
                    { "f80a67bc-7142-438b-8123-0d84038f7da6", "651d31a5-5f16-42b7-866c-06699b8a8125", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "593bccb5-af75-4033-b5d9-2a0bb70538d3", 0, "65c3305d-3a17-4a17-871d-3eaba7e7226f", "pedrowkriss@gmail.com", true, false, null, "PEDROWKRISS@GMAIL.COM", "HENRYKRISS", "AQAAAAEAACcQAAAAECTJuAY5S8dusDmQLatWk10jKPeOAbt2YQ4k5PAYl7iytwQpwqtUwrMK3RlUe8EO8w==", "14991541082", true, "859eeebf-c831-41e3-8412-7ac518b501fa", false, "HenryKriss" });

            migrationBuilder.InsertData(
                table: "TipoDev",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { (byte)1, "FullStack" },
                    { (byte)2, "FrontEnd" },
                    { (byte)3, "BackEnd" },
                    { (byte)4, "Design" },
                    { (byte)5, "Jogos" },
                    { (byte)6, "Músico" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f80a67bc-7142-438b-8123-0d84038f7da6", "593bccb5-af75-4033-b5d9-2a0bb70538d3" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UserId", "DataNascimento", "Foto", "Nome", "TipoDevId" },
                values: new object[] { "593bccb5-af75-4033-b5d9-2a0bb70538d3", new DateTime(2006, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/usuarios/avatar.png", "Pedro Henrique Florêncio", (byte)6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47869ccd-a651-432b-9479-2c39421f15b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad96bc79-c2ff-42fa-a2d2-88cdb5740404");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f80a67bc-7142-438b-8123-0d84038f7da6", "593bccb5-af75-4033-b5d9-2a0bb70538d3" });

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)5);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UserId",
                keyValue: "593bccb5-af75-4033-b5d9-2a0bb70538d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f80a67bc-7142-438b-8123-0d84038f7da6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "593bccb5-af75-4033-b5d9-2a0bb70538d3");

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)6);
        }
    }
}
