using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CarDealer.Data.Migrations
{
    public partial class TableLogFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_AspNetUsers_UserId1",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_UserId1",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Logs");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Logs",
                newName: "User");

            migrationBuilder.AlterColumn<string>(
                name: "User",
                table: "Logs",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User",
                table: "Logs",
                newName: "UserId1");

            migrationBuilder.AlterColumn<string>(
                name: "UserId1",
                table: "Logs",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Logs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserId1",
                table: "Logs",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_AspNetUsers_UserId1",
                table: "Logs",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
