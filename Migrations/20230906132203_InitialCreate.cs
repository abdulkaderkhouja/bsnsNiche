using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

/*
 * This folder (Migration) was created by entering the following in Package Manager Console (each line executed alone):
 * Add-Migration InitialCreate
 * Update-Database
 */

namespace bsnsNiche.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //InitialCreate.Up: creates the Movie table and configures Id as the primary key.
            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    Order_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Order_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Routing_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PO_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiving_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ordered_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Load_Create_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Load_Update_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Need_By_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Retroactive_Effective_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ERP_Supplier_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ERP_Supplier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Supplier_VAT_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ship_To_Location_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_Terms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_PunchOut_Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_Retroactive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_Subcontractor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receipt_Based_Line = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Spot_Buy_Marketplace_Seller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Confirmation_Status_Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Confirmation_Status_Line = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service_Order = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requires_Service_Sheet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number_Substituted_OC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number_Confirmed_With_Changes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number_BackOrdered_OC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source_System = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source_System_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Originating_System = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Originating_System_Reference_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Originating_System_Line_Number = table.Column<int>(type: "int", nullable: false),
                    PO_Line_Number = table.Column<int>(type: "int", nullable: false),
                    Line_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contract_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contract = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Closed_Order_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Line_Closed_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    buyerVatID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bill_To_Location_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Account_Assignment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Account_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profit_Center_ID_Reporting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profit_Center = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Article_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Asset_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Asset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost_Center_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost_Center = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item_Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Internal_Order_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget_Internal_Order = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget_Account_Group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commodity_ID_L1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commodity_L1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commodity_ID_L2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commodity_L2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commodity_ID_L3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commodity_L3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commodity_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commodity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ERP_Commodity_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ERP_Commodity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price_Unit_of_Measure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Original_Currency_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit_Conversion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price_Unit_Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PO_Line_Amount_Range_Minimum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PO_Line_Amount_Range_Maximum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PO_Spend = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PO_Spend_Original_Currency = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount_Accepted = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount_Accepted_Original_Currency = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount_Invoiced = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount_Invoiced_Original_Currency = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax_Amount_Invoiced = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount_Reconciled = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount_Reconciled_Original_Currency = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PO_Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.Order_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //InitialCreate.Down: reverts the schema changes made by the Up migration.
            migrationBuilder.DropTable(
                name: "PurchaseOrder");
        }
    }
}
