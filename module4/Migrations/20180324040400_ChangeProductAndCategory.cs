using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace module4.Migrations
{
    public partial class ChangeProductAndCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Prod");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Cat");

            migrationBuilder.RenameIndex(
                name: "IX_Products_categoryId",
                table: "Prod",
                newName: "IX_Prod_categoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Prod",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cat",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prod",
                table: "Prod",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cat",
                table: "Cat",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prod_Cat_categoryId",
                table: "Prod",
                column: "categoryId",
                principalTable: "Cat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prod_Cat_categoryId",
                table: "Prod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prod",
                table: "Prod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cat",
                table: "Cat");

            migrationBuilder.RenameTable(
                name: "Prod",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Cat",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Prod_categoryId",
                table: "Products",
                newName: "IX_Products_categoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
