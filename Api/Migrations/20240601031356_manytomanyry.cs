using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class manytomanyry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_BlogPosts_BlogPostId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_BlogPostId",
                table: "Tags");

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"));

            migrationBuilder.DropColumn(
                name: "BlogPostId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "TagIds",
                table: "BlogPosts");

            migrationBuilder.CreateTable(
                name: "BlogPostTag",
                columns: table => new
                {
                    BlogPostsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostTag", x => new { x.BlogPostsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_BlogPostTag_BlogPosts_BlogPostsId",
                        column: x => x.BlogPostsId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogPostTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostTag_TagsId",
                table: "BlogPostTag",
                column: "TagsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPostTag");

            migrationBuilder.AddColumn<Guid>(
                name: "BlogPostId",
                table: "Tags",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagIds",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "Author", "Content", "FeaturedImageUrl", "Heading", "PageTitle", "PublishedDate", "ShortDescription", "TagIds", "UrlHandle", "Visible" },
                values: new object[] { new Guid("a200b634-e8ca-46e8-9c38-def3595b940b"), "Taurius Antanevicius", "", "", "API MVC course Review", "Best intermediate programmer API course", new DateTime(2024, 5, 31, 13, 37, 18, 871, DateTimeKind.Local).AddTicks(2303), "", "[\"5035a2a2-54f1-4e6a-81b6-40e0b589f637\"]", "", true });

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
    }
}
