using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class blogpost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "Author", "Content", "FeaturedImageUrl", "Heading", "PageTitle", "PublishedDate", "ShortDescription", "UrlHandle", "Visible" },
                values: new object[] { new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"), "Taurius Antanevicius", "", "", "API MVC course Review", "Best intermediate programmer API course", new DateTime(2024, 6, 1, 6, 17, 38, 482, DateTimeKind.Local).AddTicks(2897), "", "", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"));
        }
    }
}
