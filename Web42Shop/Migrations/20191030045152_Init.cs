using Microsoft.EntityFrameworkCore.Migrations;

namespace Web42Shop.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_CartStatus_CartStatus_Id",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Users_User_Id",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_CartDetail_Cart_Cart_Id",
                table: "CartDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_CartDetail_Product_Product_Id",
                table: "CartDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Product_Product_Id",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Users_User_Id",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentReply_Comment_Comment_Id",
                table: "CommentReply");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentReply_Users_User_Id",
                table: "CommentReply");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderStatus_OrderStatus_Id",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_PayStatus_PayStatus_Id",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_PayType_PayType_Id",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Users_User_Id",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_Order_Id",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Product_Product_Id",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Admins_Admin_Id",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductBrands_ProductBrand_Id",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductTypes_ProductType_Id",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Slug_Slug_Id",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Slug",
                table: "Slug");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PayType",
                table: "PayType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PayStatus",
                table: "PayStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderStatus",
                table: "OrderStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommentReply",
                table: "CommentReply");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartStatus",
                table: "CartStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartDetail",
                table: "CartDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "Slug",
                newName: "Slugs");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "PayType",
                newName: "PayTypes");

            migrationBuilder.RenameTable(
                name: "PayStatus",
                newName: "PayStatuses");

            migrationBuilder.RenameTable(
                name: "OrderStatus",
                newName: "OrderStatuses");

            migrationBuilder.RenameTable(
                name: "OrderDetail",
                newName: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "CommentReply",
                newName: "CommentReplies");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameTable(
                name: "CartStatus",
                newName: "CartStatuses");

            migrationBuilder.RenameTable(
                name: "CartDetail",
                newName: "CartDetails");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "Carts");

            migrationBuilder.RenameIndex(
                name: "IX_Slug_Url",
                table: "Slugs",
                newName: "IX_Slugs_Url");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Slug_Id",
                table: "Products",
                newName: "IX_Products_Slug_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductType_Id",
                table: "Products",
                newName: "IX_Products_ProductType_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductBrand_Id",
                table: "Products",
                newName: "IX_Products_ProductBrand_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Admin_Id",
                table: "Products",
                newName: "IX_Products_Admin_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PayType_Type",
                table: "PayTypes",
                newName: "IX_PayTypes_Type");

            migrationBuilder.RenameIndex(
                name: "IX_PayStatus_Status",
                table: "PayStatuses",
                newName: "IX_PayStatuses_Status");

            migrationBuilder.RenameIndex(
                name: "IX_OrderStatus_Status",
                table: "OrderStatuses",
                newName: "IX_OrderStatuses_Status");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_Product_Id",
                table: "OrderDetails",
                newName: "IX_OrderDetails_Product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_Order_Id",
                table: "OrderDetails",
                newName: "IX_OrderDetails_Order_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Order_User_Id",
                table: "Orders",
                newName: "IX_Orders_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Order_PayType_Id",
                table: "Orders",
                newName: "IX_Orders_PayType_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Order_PayStatus_Id",
                table: "Orders",
                newName: "IX_Orders_PayStatus_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Order_OrderStatus_Id",
                table: "Orders",
                newName: "IX_Orders_OrderStatus_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CommentReply_User_Id",
                table: "CommentReplies",
                newName: "IX_CommentReplies_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CommentReply_Comment_Id",
                table: "CommentReplies",
                newName: "IX_CommentReplies_Comment_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_User_Id",
                table: "Comments",
                newName: "IX_Comments_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_Product_Id",
                table: "Comments",
                newName: "IX_Comments_Product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CartStatus_Status",
                table: "CartStatuses",
                newName: "IX_CartStatuses_Status");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetail_Product_Id",
                table: "CartDetails",
                newName: "IX_CartDetails_Product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetail_Cart_Id",
                table: "CartDetails",
                newName: "IX_CartDetails_Cart_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_User_Id",
                table: "Carts",
                newName: "IX_Carts_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_CartStatus_Id",
                table: "Carts",
                newName: "IX_Carts_CartStatus_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Slugs",
                table: "Slugs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PayTypes",
                table: "PayTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PayStatuses",
                table: "PayStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderStatuses",
                table: "OrderStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommentReplies",
                table: "CommentReplies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartStatuses",
                table: "CartStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartDetails",
                table: "CartDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Carts_Cart_Id",
                table: "CartDetails",
                column: "Cart_Id",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Products_Product_Id",
                table: "CartDetails",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_CartStatuses_CartStatus_Id",
                table: "Carts",
                column: "CartStatus_Id",
                principalTable: "CartStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_User_Id",
                table: "Carts",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentReplies_Comments_Comment_Id",
                table: "CommentReplies",
                column: "Comment_Id",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentReplies_Users_User_Id",
                table: "CommentReplies",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Products_Product_Id",
                table: "Comments",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_User_Id",
                table: "Comments",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_Order_Id",
                table: "OrderDetails",
                column: "Order_Id",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_Product_Id",
                table: "OrderDetails",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStatuses_OrderStatus_Id",
                table: "Orders",
                column: "OrderStatus_Id",
                principalTable: "OrderStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PayStatuses_PayStatus_Id",
                table: "Orders",
                column: "PayStatus_Id",
                principalTable: "PayStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PayTypes_PayType_Id",
                table: "Orders",
                column: "PayType_Id",
                principalTable: "PayTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_User_Id",
                table: "Orders",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Admins_Admin_Id",
                table: "Products",
                column: "Admin_Id",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductBrands_ProductBrand_Id",
                table: "Products",
                column: "ProductBrand_Id",
                principalTable: "ProductBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductType_Id",
                table: "Products",
                column: "ProductType_Id",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Slugs_Slug_Id",
                table: "Products",
                column: "Slug_Id",
                principalTable: "Slugs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Carts_Cart_Id",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Products_Product_Id",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_CartStatuses_CartStatus_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_User_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentReplies_Comments_Comment_Id",
                table: "CommentReplies");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentReplies_Users_User_Id",
                table: "CommentReplies");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Products_Product_Id",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_User_Id",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_Order_Id",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_Product_Id",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatuses_OrderStatus_Id",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PayStatuses_PayStatus_Id",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PayTypes_PayType_Id",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_User_Id",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Admins_Admin_Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductBrands_ProductBrand_Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductType_Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Slugs_Slug_Id",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Slugs",
                table: "Slugs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PayTypes",
                table: "PayTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PayStatuses",
                table: "PayStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderStatuses",
                table: "OrderStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommentReplies",
                table: "CommentReplies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartStatuses",
                table: "CartStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartDetails",
                table: "CartDetails");

            migrationBuilder.RenameTable(
                name: "Slugs",
                newName: "Slug");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "PayTypes",
                newName: "PayType");

            migrationBuilder.RenameTable(
                name: "PayStatuses",
                newName: "PayStatus");

            migrationBuilder.RenameTable(
                name: "OrderStatuses",
                newName: "OrderStatus");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "OrderDetail");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameTable(
                name: "CommentReplies",
                newName: "CommentReply");

            migrationBuilder.RenameTable(
                name: "CartStatuses",
                newName: "CartStatus");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Cart");

            migrationBuilder.RenameTable(
                name: "CartDetails",
                newName: "CartDetail");

            migrationBuilder.RenameIndex(
                name: "IX_Slugs_Url",
                table: "Slug",
                newName: "IX_Slug_Url");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Slug_Id",
                table: "Product",
                newName: "IX_Product_Slug_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductType_Id",
                table: "Product",
                newName: "IX_Product_ProductType_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductBrand_Id",
                table: "Product",
                newName: "IX_Product_ProductBrand_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Admin_Id",
                table: "Product",
                newName: "IX_Product_Admin_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PayTypes_Type",
                table: "PayType",
                newName: "IX_PayType_Type");

            migrationBuilder.RenameIndex(
                name: "IX_PayStatuses_Status",
                table: "PayStatus",
                newName: "IX_PayStatus_Status");

            migrationBuilder.RenameIndex(
                name: "IX_OrderStatuses_Status",
                table: "OrderStatus",
                newName: "IX_OrderStatus_Status");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_User_Id",
                table: "Order",
                newName: "IX_Order_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PayType_Id",
                table: "Order",
                newName: "IX_Order_PayType_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PayStatus_Id",
                table: "Order",
                newName: "IX_Order_PayStatus_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_OrderStatus_Id",
                table: "Order",
                newName: "IX_Order_OrderStatus_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_Product_Id",
                table: "OrderDetail",
                newName: "IX_OrderDetail_Product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_Order_Id",
                table: "OrderDetail",
                newName: "IX_OrderDetail_Order_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_User_Id",
                table: "Comment",
                newName: "IX_Comment_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_Product_Id",
                table: "Comment",
                newName: "IX_Comment_Product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CommentReplies_User_Id",
                table: "CommentReply",
                newName: "IX_CommentReply_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CommentReplies_Comment_Id",
                table: "CommentReply",
                newName: "IX_CommentReply_Comment_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CartStatuses_Status",
                table: "CartStatus",
                newName: "IX_CartStatus_Status");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_User_Id",
                table: "Cart",
                newName: "IX_Cart_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_CartStatus_Id",
                table: "Cart",
                newName: "IX_Cart_CartStatus_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetails_Product_Id",
                table: "CartDetail",
                newName: "IX_CartDetail_Product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetails_Cart_Id",
                table: "CartDetail",
                newName: "IX_CartDetail_Cart_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Slug",
                table: "Slug",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PayType",
                table: "PayType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PayStatus",
                table: "PayStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderStatus",
                table: "OrderStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommentReply",
                table: "CommentReply",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartStatus",
                table: "CartStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartDetail",
                table: "CartDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_CartStatus_CartStatus_Id",
                table: "Cart",
                column: "CartStatus_Id",
                principalTable: "CartStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Users_User_Id",
                table: "Cart",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetail_Cart_Cart_Id",
                table: "CartDetail",
                column: "Cart_Id",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetail_Product_Product_Id",
                table: "CartDetail",
                column: "Product_Id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Product_Product_Id",
                table: "Comment",
                column: "Product_Id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Users_User_Id",
                table: "Comment",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentReply_Comment_Comment_Id",
                table: "CommentReply",
                column: "Comment_Id",
                principalTable: "Comment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentReply_Users_User_Id",
                table: "CommentReply",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderStatus_OrderStatus_Id",
                table: "Order",
                column: "OrderStatus_Id",
                principalTable: "OrderStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_PayStatus_PayStatus_Id",
                table: "Order",
                column: "PayStatus_Id",
                principalTable: "PayStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_PayType_PayType_Id",
                table: "Order",
                column: "PayType_Id",
                principalTable: "PayType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Users_User_Id",
                table: "Order",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_Order_Id",
                table: "OrderDetail",
                column: "Order_Id",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Product_Product_Id",
                table: "OrderDetail",
                column: "Product_Id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Admins_Admin_Id",
                table: "Product",
                column: "Admin_Id",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductBrands_ProductBrand_Id",
                table: "Product",
                column: "ProductBrand_Id",
                principalTable: "ProductBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductTypes_ProductType_Id",
                table: "Product",
                column: "ProductType_Id",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Slug_Slug_Id",
                table: "Product",
                column: "Slug_Id",
                principalTable: "Slug",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
