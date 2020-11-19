using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class modifyDatablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Goodse_GoodsID",
                table: "OrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Goodse",
                table: "Goodse");

            migrationBuilder.RenameTable(
                name: "Goodse",
                newName: "Goods");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Goods",
                table: "Goods",
                column: "GoodsID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Goods_GoodsID",
                table: "OrderDetail",
                column: "GoodsID",
                principalTable: "Goods",
                principalColumn: "GoodsID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Goods_GoodsID",
                table: "OrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Goods",
                table: "Goods");

            migrationBuilder.RenameTable(
                name: "Goods",
                newName: "Goodse");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Goodse",
                table: "Goodse",
                column: "GoodsID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Goodse_GoodsID",
                table: "OrderDetail",
                column: "GoodsID",
                principalTable: "Goodse",
                principalColumn: "GoodsID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
