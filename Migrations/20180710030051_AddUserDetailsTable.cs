using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetapi.Migrations
{
    public partial class AddUserDetailsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserDetailId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Street = table.Column<string>(type: "varchar(100)", nullable: false),
                    Street2 = table.Column<string>(type: "varchar(100)", nullable: false),
                    City = table.Column<string>(type: "varchar(100)", nullable: false),
                    State = table.Column<string>(type: "varchar(10)", nullable: false),
                    Zip = table.Column<int>(nullable: false),
                    Ssn = table.Column<int>(nullable: false),
                    Phone = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BankRouting = table.Column<long>(type: "bigint", nullable: false),
                    BankAccount = table.Column<long>(type: "bigint", nullable: false),
                    SaleOneId = table.Column<int>(nullable: false),
                    SaleOneCampaignId = table.Column<int>(nullable: false),
                    SaleTwoId = table.Column<int>(nullable: false),
                    SaleTwoCampaignId = table.Column<int>(nullable: false),
                    SaleThreeId = table.Column<int>(nullable: false),
                    SaleThreeCampaignId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserDetailId);
                    table.ForeignKey(
                        name: "FK_UserDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_UserId",
                table: "UserDetails",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDetails");
        }
    }
}
