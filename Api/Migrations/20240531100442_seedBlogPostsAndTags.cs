using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class seedBlogPostsAndTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "Author", "Content", "FeaturedImageUrl", "Heading", "PageTitle", "PublishedDate", "ShortDescription", "UrlHandle", "Visible" },
                values: new object[] { new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"), "Taurius Antanevicius", "", "", "API MVC course Review", "Best intermediate programmer API course", new DateTime(2024, 5, 31, 13, 4, 42, 283, DateTimeKind.Local).AddTicks(5866), "", "", true });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "DisplayName", "Name" },
                values: new object[,]
                {
                    { new Guid("2fa42358-a83b-412d-8048-c2356e8ccb2a"), "Projects", "Projects" },
                    { new Guid("5035a2a2-54f1-4e6a-81b6-40e0b589f637"), "Review", "Review" },
                    { new Guid("dad9b2fa-3bb1-4dde-97f9-e2f6e0dc949b"), "Guide", "Guide" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2fa42358-a83b-412d-8048-c2356e8ccb2a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5035a2a2-54f1-4e6a-81b6-40e0b589f637"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dad9b2fa-3bb1-4dde-97f9-e2f6e0dc949b"));
        }
    }
}
