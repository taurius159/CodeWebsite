using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class BlogPostsHaveMultipleTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagId",
                table: "BlogPosts");

            migrationBuilder.AddColumn<string>(
                name: "TagIds",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"),
                columns: new[] { "PublishedDate", "TagIds" },
                values: new object[] { new DateTime(2024, 5, 31, 13, 37, 18, 871, DateTimeKind.Local).AddTicks(2303), "[\"5035a2a2-54f1-4e6a-81b6-40e0b589f637\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagIds",
                table: "BlogPosts");

            migrationBuilder.AddColumn<Guid>(
                name: "TagId",
                table: "BlogPosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"),
                columns: new[] { "PublishedDate", "TagId" },
                values: new object[] { new DateTime(2024, 5, 31, 13, 35, 4, 720, DateTimeKind.Local).AddTicks(8263), new Guid("5035a2a2-54f1-4e6a-81b6-40e0b589f637") });
        }
    }
}
