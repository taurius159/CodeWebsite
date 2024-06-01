using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class seedJoinTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlogPostTag",
                columns: new[] { "BlogPostsId", "TagsId" },
                values: new object[] { new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"), new Guid("5035a2a2-54f1-4e6a-81b6-40e0b589f637") });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"),
                column: "PublishedDate",
                value: new DateTime(2024, 6, 1, 6, 36, 8, 949, DateTimeKind.Local).AddTicks(5314));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogPostTag",
                keyColumns: new[] { "BlogPostsId", "TagsId" },
                keyValues: new object[] { new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"), new Guid("5035a2a2-54f1-4e6a-81b6-40e0b589f637") });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"),
                column: "PublishedDate",
                value: new DateTime(2024, 6, 1, 6, 17, 38, 482, DateTimeKind.Local).AddTicks(2897));
        }
    }
}
