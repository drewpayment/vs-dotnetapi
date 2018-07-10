using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetapi.Migrations
{
    public partial class AddUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.CreateTable(
            //     name: "__EFMigrationsHistory",
            //     columns: table => new
            //     {
            //         MigrationId = table.Column<string>(type: "varchar(95)", nullable: false),
            //         ProductVersion = table.Column<string>(type: "varchar(32)", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK___EFMigrationsHistory", x => x.MigrationId);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "UserDetailList",
            //     columns: table => new
            //     {
            //         UserDetailId = table.Column<int>(nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         UserId = table.Column<int>(nullable: false),
            //         Street = table.Column<string>(nullable: true),
            //         Street2 = table.Column<string>(nullable: true),
            //         City = table.Column<string>(nullable: true),
            //         State = table.Column<string>(nullable: true),
            //         Zip = table.Column<int>(nullable: false),
            //         Ssn = table.Column<int>(nullable: false),
            //         Phone = table.Column<int>(nullable: false),
            //         BirthDate = table.Column<DateTime>(nullable: false),
            //         BankRouting = table.Column<int>(nullable: false),
            //         BankAccount = table.Column<int>(nullable: false),
            //         SaleOneId = table.Column<int>(nullable: false),
            //         SaleOneCampaignId = table.Column<int>(nullable: false),
            //         SaleTwoId = table.Column<int>(nullable: false),
            //         SaleTwoCampaignId = table.Column<int>(nullable: false),
            //         SaleThreeId = table.Column<int>(nullable: false),
            //         SaleThreeCampaignId = table.Column<int>(nullable: false),
            //         CreatedAt = table.Column<DateTime>(nullable: false),
            //         UpdatedAt = table.Column<DateTime>(nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_UserDetailList", x => x.UserDetailId);
            //     });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "varchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", nullable: false),
                    Username = table.Column<string>(type: "varchar(30)", nullable: false),
                    Email = table.Column<string>(type: "varchar(60)", nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", nullable: false),
                    RememberToken = table.Column<string>(type: "varchar(255)", nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "__EFMigrationsHistory");

            // migrationBuilder.DropTable(
            //     name: "UserDetailList");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
