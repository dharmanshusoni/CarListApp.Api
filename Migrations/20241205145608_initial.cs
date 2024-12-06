﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarListApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Make = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Vin = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "Make", "Model", "Vin" },
                values: new object[,]
                {
                    { 1, "Honda", "Fit", "123" },
                    { 2, "Toyota", "Prado", "123" },
                    { 3, "Honda", "Civic", "123" },
                    { 4, "Audi", "A5", "123" },
                    { 5, "BMW", "M3", "123" },
                    { 6, "Nissan", "Note", "123" },
                    { 7, "Ferrari", "Spider", "123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");
        }
    }
}
