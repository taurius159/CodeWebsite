using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class addTagsToBlogPosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BlogPostId",
                table: "Tags",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2fa42358-a83b-412d-8048-c2356e8ccb2a"),
                column: "BlogPostId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5035a2a2-54f1-4e6a-81b6-40e0b589f637"),
                column: "BlogPostId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dad9b2fa-3bb1-4dde-97f9-e2f6e0dc949b"),
                column: "BlogPostId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BlogPostId",
                table: "Tags",
                column: "BlogPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_BlogPosts_BlogPostId",
                table: "Tags",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_BlogPosts_BlogPostId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_BlogPostId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "BlogPostId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "BlogPosts");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"),
                column: "PublishedDate",
                value: new DateTime(2024, 5, 31, 13, 4, 42, 283, DateTimeKind.Local).AddTicks(5866));
        }
    }
}
