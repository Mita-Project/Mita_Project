using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Migration_Nullable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_EMails_EMailId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_EMails_ServiceRecords_ServiceRecordId",
                table: "EMails");

            migrationBuilder.DropForeignKey(
                name: "FK_Gadgets_GadgetTypes_GadgetTypeId",
                table: "Gadgets");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenances_Branch_BranchId",
                table: "Maintenances");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_AspNetUsers_UserId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_Teams_TeamId",
                table: "ServiceRecords");

            migrationBuilder.DropIndex(
                name: "IX_Requests_ServiceRecordId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Offers_RequestId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_ServiceRecordId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Maintenances_BranchId",
                table: "Maintenances");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "ServiceRecords",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "ServiceRecords",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "ServiceRecords",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Requests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRecordId",
                table: "Requests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "Requests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Requests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Requests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRecordId",
                table: "Photographs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "Photographs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MessageId",
                table: "Photographs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Offers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRecordId",
                table: "Offers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "Offers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRecordId",
                table: "Messages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Maintenances",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GadgetTypeId",
                table: "Gadgets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRecordId",
                table: "EMails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "Documents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MessageId",
                table: "Documents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EMailId",
                table: "Documents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaintenanceId",
                table: "Branch",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ServiceRecordId",
                table: "Requests",
                column: "ServiceRecordId",
                unique: true,
                filter: "[ServiceRecordId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_RequestId",
                table: "Offers",
                column: "RequestId",
                unique: true,
                filter: "[RequestId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_ServiceRecordId",
                table: "Offers",
                column: "ServiceRecordId",
                unique: true,
                filter: "[ServiceRecordId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_BranchId",
                table: "Maintenances",
                column: "BranchId",
                unique: true,
                filter: "[BranchId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_EMails_EMailId",
                table: "Documents",
                column: "EMailId",
                principalTable: "EMails",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_EMails_ServiceRecords_ServiceRecordId",
                table: "EMails",
                column: "ServiceRecordId",
                principalTable: "ServiceRecords",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gadgets_GadgetTypes_GadgetTypeId",
                table: "Gadgets",
                column: "GadgetTypeId",
                principalTable: "GadgetTypes",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenances_Branch_BranchId",
                table: "Maintenances",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_AspNetUsers_UserId",
                table: "Offers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_Teams_TeamId",
                table: "ServiceRecords",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_EMails_EMailId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_EMails_ServiceRecords_ServiceRecordId",
                table: "EMails");

            migrationBuilder.DropForeignKey(
                name: "FK_Gadgets_GadgetTypes_GadgetTypeId",
                table: "Gadgets");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenances_Branch_BranchId",
                table: "Maintenances");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_AspNetUsers_UserId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_Teams_TeamId",
                table: "ServiceRecords");

            migrationBuilder.DropIndex(
                name: "IX_Requests_ServiceRecordId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Offers_RequestId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_ServiceRecordId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Maintenances_BranchId",
                table: "Maintenances");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "ServiceRecords",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "ServiceRecords",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "ServiceRecords",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRecordId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRecordId",
                table: "Photographs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "Photographs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MessageId",
                table: "Photographs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRecordId",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRecordId",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Maintenances",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GadgetTypeId",
                table: "Gadgets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRecordId",
                table: "EMails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "Documents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MessageId",
                table: "Documents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EMailId",
                table: "Documents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaintenanceId",
                table: "Branch",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ServiceRecordId",
                table: "Requests",
                column: "ServiceRecordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_RequestId",
                table: "Offers",
                column: "RequestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_ServiceRecordId",
                table: "Offers",
                column: "ServiceRecordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_BranchId",
                table: "Maintenances",
                column: "BranchId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_EMails_EMailId",
                table: "Documents",
                column: "EMailId",
                principalTable: "EMails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EMails_ServiceRecords_ServiceRecordId",
                table: "EMails",
                column: "ServiceRecordId",
                principalTable: "ServiceRecords",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gadgets_GadgetTypes_GadgetTypeId",
                table: "Gadgets",
                column: "GadgetTypeId",
                principalTable: "GadgetTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenances_Branch_BranchId",
                table: "Maintenances",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_AspNetUsers_UserId",
                table: "Offers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_Teams_TeamId",
                table: "ServiceRecords",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
