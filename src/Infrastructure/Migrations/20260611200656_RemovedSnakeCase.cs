using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedSnakeCase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_api_keys_tenants_tenant_id",
                table: "api_keys");

            migrationBuilder.DropForeignKey(
                name: "fk_asp_net_role_claims_asp_net_roles_role_id",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "fk_asp_net_user_claims_asp_net_users_user_id",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "fk_asp_net_user_logins_asp_net_users_user_id",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "fk_asp_net_user_roles_asp_net_roles_role_id",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "fk_asp_net_user_roles_asp_net_users_user_id",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "fk_asp_net_user_tokens_asp_net_users_user_id",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "fk_invitaitons_tenants_tenant_id",
                table: "invitaitons");

            migrationBuilder.DropForeignKey(
                name: "fk_projects_tenants_tenant_id",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "fk_task_item_projects_project_id",
                table: "task_item");

            migrationBuilder.DropForeignKey(
                name: "fk_user_tenant_roles_tenants_tenant_id",
                table: "user_tenant_roles");

            migrationBuilder.DropForeignKey(
                name: "fk_user_tenant_roles_users_user_id",
                table: "user_tenant_roles");

            migrationBuilder.DropPrimaryKey(
                name: "pk_tenants",
                table: "tenants");

            migrationBuilder.DropPrimaryKey(
                name: "pk_projects",
                table: "projects");

            migrationBuilder.DropPrimaryKey(
                name: "pk_invitaitons",
                table: "invitaitons");

            migrationBuilder.DropPrimaryKey(
                name: "pk_asp_net_user_tokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "pk_asp_net_users",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "pk_asp_net_user_roles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "pk_asp_net_user_logins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "pk_asp_net_user_claims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "pk_asp_net_roles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "pk_asp_net_role_claims",
                table: "AspNetRoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_tenant_roles",
                table: "user_tenant_roles");

            migrationBuilder.DropPrimaryKey(
                name: "pk_task_item",
                table: "task_item");

            migrationBuilder.DropPrimaryKey(
                name: "pk_api_keys",
                table: "api_keys");

            migrationBuilder.RenameTable(
                name: "tenants",
                newName: "Tenants");

            migrationBuilder.RenameTable(
                name: "projects",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "invitaitons",
                newName: "Invitaitons");

            migrationBuilder.RenameTable(
                name: "user_tenant_roles",
                newName: "UserTenantRoles");

            migrationBuilder.RenameTable(
                name: "task_item",
                newName: "TaskItem");

            migrationBuilder.RenameTable(
                name: "api_keys",
                newName: "ApiKeys");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Tenants",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "slug",
                table: "Tenants",
                newName: "Slug");

            migrationBuilder.RenameColumn(
                name: "settings",
                table: "Tenants",
                newName: "Settings");

            migrationBuilder.RenameColumn(
                name: "plan",
                table: "Tenants",
                newName: "Plan");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Tenants",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Tenants",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Tenants",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "plan_expires_at",
                table: "Tenants",
                newName: "PlanExpiresAt");

            migrationBuilder.RenameColumn(
                name: "isolation_mode",
                table: "Tenants",
                newName: "IsolationMode");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "Tenants",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Tenants",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "billing_email",
                table: "Tenants",
                newName: "BillingEmail");

            migrationBuilder.RenameIndex(
                name: "ix_tenants_slug",
                table: "Tenants",
                newName: "IX_Tenants_Slug");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Projects",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Projects",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "color",
                table: "Projects",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Projects",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Projects",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "tenant_id",
                table: "Projects",
                newName: "TenantId");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "Projects",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Projects",
                newName: "CreatedAt");

            migrationBuilder.RenameIndex(
                name: "ix_projects_tenant_id",
                table: "Projects",
                newName: "IX_Projects_TenantId");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "Invitaitons",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Invitaitons",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "accepted",
                table: "Invitaitons",
                newName: "Accepted");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Invitaitons",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Invitaitons",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "token_hash",
                table: "Invitaitons",
                newName: "TokenHash");

            migrationBuilder.RenameColumn(
                name: "tenant_id",
                table: "Invitaitons",
                newName: "TenantId");

            migrationBuilder.RenameColumn(
                name: "expires_at",
                table: "Invitaitons",
                newName: "ExpiresAt");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "Invitaitons",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Invitaitons",
                newName: "CreatedAt");

            migrationBuilder.RenameIndex(
                name: "ix_invitaitons_tenant_id",
                table: "Invitaitons",
                newName: "IX_Invitaitons_TenantId");

            migrationBuilder.RenameColumn(
                name: "value",
                table: "AspNetUserTokens",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "AspNetUserTokens",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "login_provider",
                table: "AspNetUserTokens",
                newName: "LoginProvider");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "AspNetUserTokens",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "AspNetUsers",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AspNetUsers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_name",
                table: "AspNetUsers",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "AspNetUsers",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "two_factor_enabled",
                table: "AspNetUsers",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "security_stamp",
                table: "AspNetUsers",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "primary_tenant_id",
                table: "AspNetUsers",
                newName: "PrimaryTenantId");

            migrationBuilder.RenameColumn(
                name: "phone_number_confirmed",
                table: "AspNetUsers",
                newName: "PhoneNumberConfirmed");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "AspNetUsers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "password_hash",
                table: "AspNetUsers",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "normalized_user_name",
                table: "AspNetUsers",
                newName: "NormalizedUserName");

            migrationBuilder.RenameColumn(
                name: "normalized_email",
                table: "AspNetUsers",
                newName: "NormalizedEmail");

            migrationBuilder.RenameColumn(
                name: "lockout_end",
                table: "AspNetUsers",
                newName: "LockoutEnd");

            migrationBuilder.RenameColumn(
                name: "lockout_enabled",
                table: "AspNetUsers",
                newName: "LockoutEnabled");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "AspNetUsers",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "email_confirmed",
                table: "AspNetUsers",
                newName: "EmailConfirmed");

            migrationBuilder.RenameColumn(
                name: "display_name",
                table: "AspNetUsers",
                newName: "DisplayName");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "AspNetUsers",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "AspNetUsers",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "concurrency_stamp",
                table: "AspNetUsers",
                newName: "ConcurrencyStamp");

            migrationBuilder.RenameColumn(
                name: "access_failed_count",
                table: "AspNetUsers",
                newName: "AccessFailedCount");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "AspNetUserRoles",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "AspNetUserRoles",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "ix_asp_net_user_roles_role_id",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "AspNetUserLogins",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "provider_display_name",
                table: "AspNetUserLogins",
                newName: "ProviderDisplayName");

            migrationBuilder.RenameColumn(
                name: "provider_key",
                table: "AspNetUserLogins",
                newName: "ProviderKey");

            migrationBuilder.RenameColumn(
                name: "login_provider",
                table: "AspNetUserLogins",
                newName: "LoginProvider");

            migrationBuilder.RenameIndex(
                name: "ix_asp_net_user_logins_user_id",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AspNetUserClaims",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "AspNetUserClaims",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "claim_value",
                table: "AspNetUserClaims",
                newName: "ClaimValue");

            migrationBuilder.RenameColumn(
                name: "claim_type",
                table: "AspNetUserClaims",
                newName: "ClaimType");

            migrationBuilder.RenameIndex(
                name: "ix_asp_net_user_claims_user_id",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "AspNetRoles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AspNetRoles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "normalized_name",
                table: "AspNetRoles",
                newName: "NormalizedName");

            migrationBuilder.RenameColumn(
                name: "concurrency_stamp",
                table: "AspNetRoles",
                newName: "ConcurrencyStamp");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AspNetRoleClaims",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "AspNetRoleClaims",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "claim_value",
                table: "AspNetRoleClaims",
                newName: "ClaimValue");

            migrationBuilder.RenameColumn(
                name: "claim_type",
                table: "AspNetRoleClaims",
                newName: "ClaimType");

            migrationBuilder.RenameIndex(
                name: "ix_asp_net_role_claims_role_id",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "UserTenantRoles",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "UserTenantRoles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "UserTenantRoles",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "tenant_id",
                table: "UserTenantRoles",
                newName: "TenantId");

            migrationBuilder.RenameIndex(
                name: "ix_user_tenant_roles_user_id_tenant_id",
                table: "UserTenantRoles",
                newName: "IX_UserTenantRoles_UserId_TenantId");

            migrationBuilder.RenameIndex(
                name: "ix_user_tenant_roles_tenant_id",
                table: "UserTenantRoles",
                newName: "IX_UserTenantRoles_TenantId");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "TaskItem",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "TaskItem",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TaskItem",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "TaskItem",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "tenant_id",
                table: "TaskItem",
                newName: "TenantId");

            migrationBuilder.RenameColumn(
                name: "project_id",
                table: "TaskItem",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "TaskItem",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "TaskItem",
                newName: "CreatedAt");

            migrationBuilder.RenameIndex(
                name: "ix_task_item_project_id",
                table: "TaskItem",
                newName: "IX_TaskItem_ProjectId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "ApiKeys",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ApiKeys",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "ApiKeys",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "tenant_id",
                table: "ApiKeys",
                newName: "TenantId");

            migrationBuilder.RenameColumn(
                name: "last_used_at",
                table: "ApiKeys",
                newName: "LastUsedAt");

            migrationBuilder.RenameColumn(
                name: "key_prefix",
                table: "ApiKeys",
                newName: "KeyPrefix");

            migrationBuilder.RenameColumn(
                name: "key_hash",
                table: "ApiKeys",
                newName: "KeyHash");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "ApiKeys",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "expires_at",
                table: "ApiKeys",
                newName: "ExpiresAt");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "ApiKeys",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "ApiKeys",
                newName: "CreatedAt");

            migrationBuilder.RenameIndex(
                name: "ix_api_keys_tenant_id",
                table: "ApiKeys",
                newName: "IX_ApiKeys_TenantId");

            migrationBuilder.RenameIndex(
                name: "ix_api_keys_key_hash",
                table: "ApiKeys",
                newName: "IX_ApiKeys_KeyHash");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tenants",
                table: "Tenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invitaitons",
                table: "Invitaitons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTenantRoles",
                table: "UserTenantRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskItem",
                table: "TaskItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiKeys",
                table: "ApiKeys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApiKeys_Tenants_TenantId",
                table: "ApiKeys",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invitaitons_Tenants_TenantId",
                table: "Invitaitons",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Tenants_TenantId",
                table: "Projects",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItem_Projects_ProjectId",
                table: "TaskItem",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTenantRoles_AspNetUsers_UserId",
                table: "UserTenantRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTenantRoles_Tenants_TenantId",
                table: "UserTenantRoles",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApiKeys_Tenants_TenantId",
                table: "ApiKeys");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Invitaitons_Tenants_TenantId",
                table: "Invitaitons");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Tenants_TenantId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskItem_Projects_ProjectId",
                table: "TaskItem");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTenantRoles_AspNetUsers_UserId",
                table: "UserTenantRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTenantRoles_Tenants_TenantId",
                table: "UserTenantRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tenants",
                table: "Tenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invitaitons",
                table: "Invitaitons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTenantRoles",
                table: "UserTenantRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskItem",
                table: "TaskItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiKeys",
                table: "ApiKeys");

            migrationBuilder.RenameTable(
                name: "Tenants",
                newName: "tenants");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "projects");

            migrationBuilder.RenameTable(
                name: "Invitaitons",
                newName: "invitaitons");

            migrationBuilder.RenameTable(
                name: "UserTenantRoles",
                newName: "user_tenant_roles");

            migrationBuilder.RenameTable(
                name: "TaskItem",
                newName: "task_item");

            migrationBuilder.RenameTable(
                name: "ApiKeys",
                newName: "api_keys");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "tenants",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "tenants",
                newName: "slug");

            migrationBuilder.RenameColumn(
                name: "Settings",
                table: "tenants",
                newName: "settings");

            migrationBuilder.RenameColumn(
                name: "Plan",
                table: "tenants",
                newName: "plan");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tenants",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tenants",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "tenants",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "PlanExpiresAt",
                table: "tenants",
                newName: "plan_expires_at");

            migrationBuilder.RenameColumn(
                name: "IsolationMode",
                table: "tenants",
                newName: "isolation_mode");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "tenants",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "tenants",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "BillingEmail",
                table: "tenants",
                newName: "billing_email");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_Slug",
                table: "tenants",
                newName: "ix_tenants_slug");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "projects",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "projects",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "projects",
                newName: "color");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "projects",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "projects",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "projects",
                newName: "tenant_id");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "projects",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "projects",
                newName: "created_at");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_TenantId",
                table: "projects",
                newName: "ix_projects_tenant_id");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "invitaitons",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "invitaitons",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Accepted",
                table: "invitaitons",
                newName: "accepted");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "invitaitons",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "invitaitons",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "TokenHash",
                table: "invitaitons",
                newName: "token_hash");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "invitaitons",
                newName: "tenant_id");

            migrationBuilder.RenameColumn(
                name: "ExpiresAt",
                table: "invitaitons",
                newName: "expires_at");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "invitaitons",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "invitaitons",
                newName: "created_at");

            migrationBuilder.RenameIndex(
                name: "IX_Invitaitons_TenantId",
                table: "invitaitons",
                newName: "ix_invitaitons_tenant_id");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "AspNetUserTokens",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUserTokens",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                newName: "login_provider");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AspNetUserTokens",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "AspNetUsers",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AspNetUsers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "AspNetUsers",
                newName: "user_name");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "AspNetUsers",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                newName: "two_factor_enabled");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "AspNetUsers",
                newName: "security_stamp");

            migrationBuilder.RenameColumn(
                name: "PrimaryTenantId",
                table: "AspNetUsers",
                newName: "primary_tenant_id");

            migrationBuilder.RenameColumn(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                newName: "phone_number_confirmed");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "AspNetUsers",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "AspNetUsers",
                newName: "password_hash");

            migrationBuilder.RenameColumn(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                newName: "normalized_user_name");

            migrationBuilder.RenameColumn(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                newName: "normalized_email");

            migrationBuilder.RenameColumn(
                name: "LockoutEnd",
                table: "AspNetUsers",
                newName: "lockout_end");

            migrationBuilder.RenameColumn(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                newName: "lockout_enabled");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "AspNetUsers",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                newName: "email_confirmed");

            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "AspNetUsers",
                newName: "display_name");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "AspNetUsers",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "AspNetUsers",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ConcurrencyStamp",
                table: "AspNetUsers",
                newName: "concurrency_stamp");

            migrationBuilder.RenameColumn(
                name: "AccessFailedCount",
                table: "AspNetUsers",
                newName: "access_failed_count");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "AspNetUserRoles",
                newName: "role_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AspNetUserRoles",
                newName: "user_id");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "ix_asp_net_user_roles_role_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AspNetUserLogins",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "ProviderDisplayName",
                table: "AspNetUserLogins",
                newName: "provider_display_name");

            migrationBuilder.RenameColumn(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                newName: "provider_key");

            migrationBuilder.RenameColumn(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                newName: "login_provider");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "ix_asp_net_user_logins_user_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AspNetUserClaims",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AspNetUserClaims",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "ClaimValue",
                table: "AspNetUserClaims",
                newName: "claim_value");

            migrationBuilder.RenameColumn(
                name: "ClaimType",
                table: "AspNetUserClaims",
                newName: "claim_type");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "ix_asp_net_user_claims_user_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetRoles",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AspNetRoles",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NormalizedName",
                table: "AspNetRoles",
                newName: "normalized_name");

            migrationBuilder.RenameColumn(
                name: "ConcurrencyStamp",
                table: "AspNetRoles",
                newName: "concurrency_stamp");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AspNetRoleClaims",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "AspNetRoleClaims",
                newName: "role_id");

            migrationBuilder.RenameColumn(
                name: "ClaimValue",
                table: "AspNetRoleClaims",
                newName: "claim_value");

            migrationBuilder.RenameColumn(
                name: "ClaimType",
                table: "AspNetRoleClaims",
                newName: "claim_type");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "ix_asp_net_role_claims_role_id");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "user_tenant_roles",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "user_tenant_roles",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "user_tenant_roles",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "user_tenant_roles",
                newName: "tenant_id");

            migrationBuilder.RenameIndex(
                name: "IX_UserTenantRoles_UserId_TenantId",
                table: "user_tenant_roles",
                newName: "ix_user_tenant_roles_user_id_tenant_id");

            migrationBuilder.RenameIndex(
                name: "IX_UserTenantRoles_TenantId",
                table: "user_tenant_roles",
                newName: "ix_user_tenant_roles_tenant_id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "task_item",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "task_item",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "task_item",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "task_item",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "task_item",
                newName: "tenant_id");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "task_item",
                newName: "project_id");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "task_item",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "task_item",
                newName: "created_at");

            migrationBuilder.RenameIndex(
                name: "IX_TaskItem_ProjectId",
                table: "task_item",
                newName: "ix_task_item_project_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "api_keys",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "api_keys",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "api_keys",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "api_keys",
                newName: "tenant_id");

            migrationBuilder.RenameColumn(
                name: "LastUsedAt",
                table: "api_keys",
                newName: "last_used_at");

            migrationBuilder.RenameColumn(
                name: "KeyPrefix",
                table: "api_keys",
                newName: "key_prefix");

            migrationBuilder.RenameColumn(
                name: "KeyHash",
                table: "api_keys",
                newName: "key_hash");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "api_keys",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "ExpiresAt",
                table: "api_keys",
                newName: "expires_at");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "api_keys",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "api_keys",
                newName: "created_at");

            migrationBuilder.RenameIndex(
                name: "IX_ApiKeys_TenantId",
                table: "api_keys",
                newName: "ix_api_keys_tenant_id");

            migrationBuilder.RenameIndex(
                name: "IX_ApiKeys_KeyHash",
                table: "api_keys",
                newName: "ix_api_keys_key_hash");

            migrationBuilder.AddPrimaryKey(
                name: "pk_tenants",
                table: "tenants",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_projects",
                table: "projects",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_invitaitons",
                table: "invitaitons",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_asp_net_user_tokens",
                table: "AspNetUserTokens",
                columns: new[] { "user_id", "login_provider", "name" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_asp_net_users",
                table: "AspNetUsers",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_asp_net_user_roles",
                table: "AspNetUserRoles",
                columns: new[] { "user_id", "role_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_asp_net_user_logins",
                table: "AspNetUserLogins",
                columns: new[] { "login_provider", "provider_key" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_asp_net_user_claims",
                table: "AspNetUserClaims",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_asp_net_roles",
                table: "AspNetRoles",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_asp_net_role_claims",
                table: "AspNetRoleClaims",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_tenant_roles",
                table: "user_tenant_roles",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_task_item",
                table: "task_item",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_api_keys",
                table: "api_keys",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_api_keys_tenants_tenant_id",
                table: "api_keys",
                column: "tenant_id",
                principalTable: "tenants",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_asp_net_role_claims_asp_net_roles_role_id",
                table: "AspNetRoleClaims",
                column: "role_id",
                principalTable: "AspNetRoles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_asp_net_user_claims_asp_net_users_user_id",
                table: "AspNetUserClaims",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_asp_net_user_logins_asp_net_users_user_id",
                table: "AspNetUserLogins",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_asp_net_user_roles_asp_net_roles_role_id",
                table: "AspNetUserRoles",
                column: "role_id",
                principalTable: "AspNetRoles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_asp_net_user_roles_asp_net_users_user_id",
                table: "AspNetUserRoles",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_asp_net_user_tokens_asp_net_users_user_id",
                table: "AspNetUserTokens",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_invitaitons_tenants_tenant_id",
                table: "invitaitons",
                column: "tenant_id",
                principalTable: "tenants",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_projects_tenants_tenant_id",
                table: "projects",
                column: "tenant_id",
                principalTable: "tenants",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_task_item_projects_project_id",
                table: "task_item",
                column: "project_id",
                principalTable: "projects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_user_tenant_roles_tenants_tenant_id",
                table: "user_tenant_roles",
                column: "tenant_id",
                principalTable: "tenants",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_user_tenant_roles_users_user_id",
                table: "user_tenant_roles",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
