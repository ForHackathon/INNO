using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace INNO.Data.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appss_Categories_CategoryId1",
                table: "Appss");

            migrationBuilder.DropForeignKey(
                name: "FK_Appss_Organizations_OrganizationId1",
                table: "Appss");

            migrationBuilder.DropForeignKey(
                name: "FK_Appss_OwnerStartups_OwnerStartupId1",
                table: "Appss");

            migrationBuilder.DropForeignKey(
                name: "FK_Appss_Users_ProductOwnerId1",
                table: "Appss");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationApps_Organizations_OrganizationId1",
                table: "OrganizationApps");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationApps_OwnerStartups_OwnerStartupId1",
                table: "OrganizationApps");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationApps_Users_InvesterId1",
                table: "OrganizationApps");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Categories_CategoryId1",
                table: "Organizations");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Users_UserId1",
                table: "Organizations");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerStartups_Categories_CategoryId1",
                table: "OwnerStartups");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerStartups_Users_UserId1",
                table: "OwnerStartups");

            migrationBuilder.DropForeignKey(
                name: "FK_Past_Experiences_Users_UserId1",
                table: "Past_Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId1",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId1",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_RoleId1",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId1",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_Past_Experiences_UserId1",
                table: "Past_Experiences");

            migrationBuilder.DropIndex(
                name: "IX_OwnerStartups_CategoryId1",
                table: "OwnerStartups");

            migrationBuilder.DropIndex(
                name: "IX_OwnerStartups_UserId1",
                table: "OwnerStartups");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_CategoryId1",
                table: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_UserId1",
                table: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationApps_InvesterId1",
                table: "OrganizationApps");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationApps_OrganizationId1",
                table: "OrganizationApps");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationApps_OwnerStartupId1",
                table: "OrganizationApps");

            migrationBuilder.DropIndex(
                name: "IX_Appss_CategoryId1",
                table: "Appss");

            migrationBuilder.DropIndex(
                name: "IX_Appss_OrganizationId1",
                table: "Appss");

            migrationBuilder.DropIndex(
                name: "IX_Appss_OwnerStartupId1",
                table: "Appss");

            migrationBuilder.DropIndex(
                name: "IX_Appss_ProductOwnerId1",
                table: "Appss");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Past_Experiences");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "OwnerStartups");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "OwnerStartups");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "InvesterId1",
                table: "OrganizationApps");

            migrationBuilder.DropColumn(
                name: "OrganizationId1",
                table: "OrganizationApps");

            migrationBuilder.DropColumn(
                name: "OwnerStartupId1",
                table: "OrganizationApps");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Appss");

            migrationBuilder.DropColumn(
                name: "OrganizationId1",
                table: "Appss");

            migrationBuilder.DropColumn(
                name: "OwnerStartupId1",
                table: "Appss");

            migrationBuilder.DropColumn(
                name: "ProductOwnerId1",
                table: "Appss");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Users",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "UserRoles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Roles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Past_Experiences",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "OwnerStartups",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Organizations",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "OrganizationApps",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Categories",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Appss",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Past_Experiences_UserId",
                table: "Past_Experiences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerStartups_CategoryId",
                table: "OwnerStartups",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerStartups_UserId",
                table: "OwnerStartups",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_CategoryId",
                table: "Organizations",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_UserId",
                table: "Organizations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationApps_InvesterId",
                table: "OrganizationApps",
                column: "InvesterId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationApps_OrganizationId",
                table: "OrganizationApps",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationApps_OwnerStartupId",
                table: "OrganizationApps",
                column: "OwnerStartupId");

            migrationBuilder.CreateIndex(
                name: "IX_Appss_CategoryId",
                table: "Appss",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Appss_OrganizationId",
                table: "Appss",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Appss_OwnerStartupId",
                table: "Appss",
                column: "OwnerStartupId");

            migrationBuilder.CreateIndex(
                name: "IX_Appss_ProductOwnerId",
                table: "Appss",
                column: "ProductOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appss_Categories_CategoryId",
                table: "Appss",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appss_Organizations_OrganizationId",
                table: "Appss",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appss_OwnerStartups_OwnerStartupId",
                table: "Appss",
                column: "OwnerStartupId",
                principalTable: "OwnerStartups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appss_Users_ProductOwnerId",
                table: "Appss",
                column: "ProductOwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationApps_Organizations_OrganizationId",
                table: "OrganizationApps",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationApps_OwnerStartups_OwnerStartupId",
                table: "OrganizationApps",
                column: "OwnerStartupId",
                principalTable: "OwnerStartups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationApps_Users_InvesterId",
                table: "OrganizationApps",
                column: "InvesterId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Categories_CategoryId",
                table: "Organizations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Users_UserId",
                table: "Organizations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerStartups_Categories_CategoryId",
                table: "OwnerStartups",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerStartups_Users_UserId",
                table: "OwnerStartups",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Past_Experiences_Users_UserId",
                table: "Past_Experiences",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appss_Categories_CategoryId",
                table: "Appss");

            migrationBuilder.DropForeignKey(
                name: "FK_Appss_Organizations_OrganizationId",
                table: "Appss");

            migrationBuilder.DropForeignKey(
                name: "FK_Appss_OwnerStartups_OwnerStartupId",
                table: "Appss");

            migrationBuilder.DropForeignKey(
                name: "FK_Appss_Users_ProductOwnerId",
                table: "Appss");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationApps_Organizations_OrganizationId",
                table: "OrganizationApps");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationApps_OwnerStartups_OwnerStartupId",
                table: "OrganizationApps");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationApps_Users_InvesterId",
                table: "OrganizationApps");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Categories_CategoryId",
                table: "Organizations");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Users_UserId",
                table: "Organizations");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerStartups_Categories_CategoryId",
                table: "OwnerStartups");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerStartups_Users_UserId",
                table: "OwnerStartups");

            migrationBuilder.DropForeignKey(
                name: "FK_Past_Experiences_Users_UserId",
                table: "Past_Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_Past_Experiences_UserId",
                table: "Past_Experiences");

            migrationBuilder.DropIndex(
                name: "IX_OwnerStartups_CategoryId",
                table: "OwnerStartups");

            migrationBuilder.DropIndex(
                name: "IX_OwnerStartups_UserId",
                table: "OwnerStartups");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_CategoryId",
                table: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_UserId",
                table: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationApps_InvesterId",
                table: "OrganizationApps");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationApps_OrganizationId",
                table: "OrganizationApps");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationApps_OwnerStartupId",
                table: "OrganizationApps");

            migrationBuilder.DropIndex(
                name: "IX_Appss_CategoryId",
                table: "Appss");

            migrationBuilder.DropIndex(
                name: "IX_Appss_OrganizationId",
                table: "Appss");

            migrationBuilder.DropIndex(
                name: "IX_Appss_OwnerStartupId",
                table: "Appss");

            migrationBuilder.DropIndex(
                name: "IX_Appss_ProductOwnerId",
                table: "Appss");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Users",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "RoleId1",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserRoles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "RoleId1",
                table: "UserRoles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "UserRoles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Roles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Past_Experiences",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Past_Experiences",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "OwnerStartups",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "OwnerStartups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "OwnerStartups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Organizations",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Organizations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Organizations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "OrganizationApps",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "InvesterId1",
                table: "OrganizationApps",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId1",
                table: "OrganizationApps",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwnerStartupId1",
                table: "OrganizationApps",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categories",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Appss",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Appss",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId1",
                table: "Appss",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwnerStartupId1",
                table: "Appss",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductOwnerId1",
                table: "Appss",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId1",
                table: "Users",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId1",
                table: "UserRoles",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId1",
                table: "UserRoles",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Past_Experiences_UserId1",
                table: "Past_Experiences",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerStartups_CategoryId1",
                table: "OwnerStartups",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerStartups_UserId1",
                table: "OwnerStartups",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_CategoryId1",
                table: "Organizations",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_UserId1",
                table: "Organizations",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationApps_InvesterId1",
                table: "OrganizationApps",
                column: "InvesterId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationApps_OrganizationId1",
                table: "OrganizationApps",
                column: "OrganizationId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationApps_OwnerStartupId1",
                table: "OrganizationApps",
                column: "OwnerStartupId1");

            migrationBuilder.CreateIndex(
                name: "IX_Appss_CategoryId1",
                table: "Appss",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Appss_OrganizationId1",
                table: "Appss",
                column: "OrganizationId1");

            migrationBuilder.CreateIndex(
                name: "IX_Appss_OwnerStartupId1",
                table: "Appss",
                column: "OwnerStartupId1");

            migrationBuilder.CreateIndex(
                name: "IX_Appss_ProductOwnerId1",
                table: "Appss",
                column: "ProductOwnerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Appss_Categories_CategoryId1",
                table: "Appss",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appss_Organizations_OrganizationId1",
                table: "Appss",
                column: "OrganizationId1",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appss_OwnerStartups_OwnerStartupId1",
                table: "Appss",
                column: "OwnerStartupId1",
                principalTable: "OwnerStartups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appss_Users_ProductOwnerId1",
                table: "Appss",
                column: "ProductOwnerId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationApps_Organizations_OrganizationId1",
                table: "OrganizationApps",
                column: "OrganizationId1",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationApps_OwnerStartups_OwnerStartupId1",
                table: "OrganizationApps",
                column: "OwnerStartupId1",
                principalTable: "OwnerStartups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationApps_Users_InvesterId1",
                table: "OrganizationApps",
                column: "InvesterId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Categories_CategoryId1",
                table: "Organizations",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Users_UserId1",
                table: "Organizations",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerStartups_Categories_CategoryId1",
                table: "OwnerStartups",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerStartups_Users_UserId1",
                table: "OwnerStartups",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Past_Experiences_Users_UserId1",
                table: "Past_Experiences",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId1",
                table: "UserRoles",
                column: "RoleId1",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId1",
                table: "UserRoles",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId1",
                table: "Users",
                column: "RoleId1",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
