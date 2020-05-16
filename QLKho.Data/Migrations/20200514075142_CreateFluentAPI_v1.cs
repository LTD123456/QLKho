using Microsoft.EntityFrameworkCore.Migrations;

namespace QLKho.Data.Migrations
{
    public partial class CreateFluentAPI_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdObject",
                table: "OutputInfos");

            migrationBuilder.DropColumn(
                name: "IdObject",
                table: "InputInfos");

            migrationBuilder.DropColumn(
                name: "Meno",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "IdInputInfo",
                table: "OutputInfos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdCustomer",
                table: "OutputInfos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdItem",
                table: "OutputInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdOutput",
                table: "OutputInfos",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdUnit",
                table: "Items",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdSuplier",
                table: "Items",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdInput",
                table: "InputInfos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdItem",
                table: "InputInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Memo",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OutputInfos_IdCustomer",
                table: "OutputInfos",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_OutputInfos_IdInputInfo",
                table: "OutputInfos",
                column: "IdInputInfo");

            migrationBuilder.CreateIndex(
                name: "IX_OutputInfos_IdItem",
                table: "OutputInfos",
                column: "IdItem");

            migrationBuilder.CreateIndex(
                name: "IX_OutputInfos_IdOutput",
                table: "OutputInfos",
                column: "IdOutput");

            migrationBuilder.CreateIndex(
                name: "IX_Items_IdSuplier",
                table: "Items",
                column: "IdSuplier");

            migrationBuilder.CreateIndex(
                name: "IX_Items_IdUnit",
                table: "Items",
                column: "IdUnit");

            migrationBuilder.CreateIndex(
                name: "IX_InputInfos_IdInput",
                table: "InputInfos",
                column: "IdInput");

            migrationBuilder.CreateIndex(
                name: "IX_InputInfos_IdItem",
                table: "InputInfos",
                column: "IdItem");

            migrationBuilder.AddForeignKey(
                name: "FK_InputInfos_Inputs_IdInput",
                table: "InputInfos",
                column: "IdInput",
                principalTable: "Inputs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InputInfos_Items_IdItem",
                table: "InputInfos",
                column: "IdItem",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Supliers_IdSuplier",
                table: "Items",
                column: "IdSuplier",
                principalTable: "Supliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Units_IdUnit",
                table: "Items",
                column: "IdUnit",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OutputInfos_Customers_IdCustomer",
                table: "OutputInfos",
                column: "IdCustomer",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OutputInfos_InputInfos_IdInputInfo",
                table: "OutputInfos",
                column: "IdInputInfo",
                principalTable: "InputInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OutputInfos_Items_IdItem",
                table: "OutputInfos",
                column: "IdItem",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OutputInfos_Outputs_IdOutput",
                table: "OutputInfos",
                column: "IdOutput",
                principalTable: "Outputs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InputInfos_Inputs_IdInput",
                table: "InputInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_InputInfos_Items_IdItem",
                table: "InputInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Supliers_IdSuplier",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Units_IdUnit",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_OutputInfos_Customers_IdCustomer",
                table: "OutputInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_OutputInfos_InputInfos_IdInputInfo",
                table: "OutputInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_OutputInfos_Items_IdItem",
                table: "OutputInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_OutputInfos_Outputs_IdOutput",
                table: "OutputInfos");

            migrationBuilder.DropIndex(
                name: "IX_OutputInfos_IdCustomer",
                table: "OutputInfos");

            migrationBuilder.DropIndex(
                name: "IX_OutputInfos_IdInputInfo",
                table: "OutputInfos");

            migrationBuilder.DropIndex(
                name: "IX_OutputInfos_IdItem",
                table: "OutputInfos");

            migrationBuilder.DropIndex(
                name: "IX_OutputInfos_IdOutput",
                table: "OutputInfos");

            migrationBuilder.DropIndex(
                name: "IX_Items_IdSuplier",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_IdUnit",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_InputInfos_IdInput",
                table: "InputInfos");

            migrationBuilder.DropIndex(
                name: "IX_InputInfos_IdItem",
                table: "InputInfos");

            migrationBuilder.DropColumn(
                name: "IdItem",
                table: "OutputInfos");

            migrationBuilder.DropColumn(
                name: "IdOutput",
                table: "OutputInfos");

            migrationBuilder.DropColumn(
                name: "IdItem",
                table: "InputInfos");

            migrationBuilder.DropColumn(
                name: "Memo",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "IdInputInfo",
                table: "OutputInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdCustomer",
                table: "OutputInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdObject",
                table: "OutputInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdUnit",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdSuplier",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdInput",
                table: "InputInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdObject",
                table: "InputInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Meno",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
