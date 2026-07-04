using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddProjectMemberTenantScope : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMembers_Tenants_TenantId",
                table: "ProjectMembers");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMembers_Tenants_TenantId",
                table: "ProjectMembers",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMembers_Tenants_TenantId",
                table: "ProjectMembers");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMembers_Tenants_TenantId",
                table: "ProjectMembers",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
