using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace INNO.Data.Migrations
{
    /// <inheritdoc />
    public partial class newmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Past_Experiences");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Users",
                newName: "CreatAt");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "UserRoles",
                newName: "CreatAt");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Roles",
                newName: "CreatAt");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Past_Experiences",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Past_Experiences",
                newName: "CreatAt");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "OwnerStartups",
                newName: "CreatAt");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Organizations",
                newName: "CreatAt");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "OrganizationApps",
                newName: "CreatAt");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Categories",
                newName: "CreatAt");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Appss",
                newName: "CreatAt");

            migrationBuilder.AddColumn<long>(
                name: "AttachmentId",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "AttachmentId",
                table: "OwnerStartups",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "OwnerStartups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "AttachmentId",
                table: "Organizations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Organizations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    CreatAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AttachmentId",
                table: "Users",
                column: "AttachmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OwnerStartups_AttachmentId",
                table: "OwnerStartups",
                column: "AttachmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_AttachmentId",
                table: "Organizations",
                column: "AttachmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Attachments_AttachmentId",
                table: "Organizations",
                column: "AttachmentId",
                principalTable: "Attachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerStartups_Attachments_AttachmentId",
                table: "OwnerStartups",
                column: "AttachmentId",
                principalTable: "Attachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Attachments_AttachmentId",
                table: "Users",
                column: "AttachmentId",
                principalTable: "Attachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Attachments_AttachmentId",
                table: "Organizations");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerStartups_Attachments_AttachmentId",
                table: "OwnerStartups");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Attachments_AttachmentId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropIndex(
                name: "IX_Users_AttachmentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_OwnerStartups_AttachmentId",
                table: "OwnerStartups");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_AttachmentId",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "OwnerStartups");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "OwnerStartups");

            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Organizations");

            migrationBuilder.RenameColumn(
                name: "CreatAt",
                table: "Users",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "CreatAt",
                table: "UserRoles",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "CreatAt",
                table: "Roles",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Past_Experiences",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "CreatAt",
                table: "Past_Experiences",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "CreatAt",
                table: "OwnerStartups",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "CreatAt",
                table: "Organizations",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "CreatAt",
                table: "OrganizationApps",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "CreatAt",
                table: "Categories",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "CreatAt",
                table: "Appss",
                newName: "DateTime");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Past_Experiences",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
