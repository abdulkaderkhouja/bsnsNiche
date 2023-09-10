using bsnsNiche.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace bsnsNiche.Models
{

    /*
     * With EF Core, data access is performed using a model. A model is made up of entity classes and a context object that represents a session
     * with the database. The context object allows querying and saving data. The database context is derived from Microsoft.EntityFrameworkCore.DbContext
     * and specifies the entities to include in the data model.
     * Scaffolding creates the Data/MvcMovieContext.cs database context class:
     */

    public class PurchaseRequest
    {
        [Key]
        public int Request_id { get; set; }

        //Add PO's to PR as a collection
        public ICollection<PurchaseOrder> PurchaseOrders { get;}

        [DataType(DataType.DateTime)]
        public DateTime ApprovalTime { get; set; }
        public decimal ChargeAmount { get; set; }
        public string LineType { get; set; }
        public int RequisitionLineNumber { get; set; }
        public decimal ClearingAmount { get; set; }
        public decimal ConsumedAmount { get; set; }
        public decimal ConstumsAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal ExpectedAmount { get; set; }
        public decimal FreightAmount { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal InsuranceAmount { get; set; }
        public decimal LCCostsAmount { get; set; }
        public decimal LegalizationAmount { get; set; }
        public decimal LineCount { get; set; }
        public decimal LocalTransportAmount { get; set; }
        public decimal MaximumAmount { get; set; }
        public decimal PriceVarianceCost { get; set; }
        public decimal ReleasedAmount { get; set; }
        public decimal RequisitionCost { get; set; }
        public decimal RequisitionQuantity { get; set; }
        public decimal RequisitionSpend { get; set; }
        public decimal RequisitionSpendOrigCurr { get; set; }
        public decimal TaxAmount { get; set; }

        
    }

    public class PurchaseOrder
    {
        [Key]
        public int Order_Id { get; set; }

        //Adding the PR ID
        //public int Request_id { get; set; }

        //Adding a reference from PO to PR on which it is based
        //public PurchaseRequest PurchaseRequest { get; set; }
        public int Version { get; set; }
        public string Order_Type { get; set; }
        public string Routing_Type { get; set; }
        public string PO_Status { get; set; }
        public string Receiving_Type { get; set; }
        [DataType(DataType.Date)]
        public DateTime Ordered_Date { get; set; }
        [DataType(DataType.Date)]
        public DateTime Load_Create_Time { get; set; }
        [DataType(DataType.Date)]
        public DateTime Load_Update_Time { get; set; }
        [DataType(DataType.Date)]
        public DateTime Need_By_Date { get; set; }
        [DataType(DataType.Date)]
        public DateTime Retroactive_Effective_Date { get; set; }
        public string ERP_Supplier_ID { get; set; }
        public string ERP_Supplier { get; set; }
        public string Supplier_VAT_Id { get; set; }
        public string Ship_To_Location_ID { get; set; }
        public string Payment_Terms { get; set; }
        public string Is_PunchOut_Item { get; set; }
        public string Is_Retroactive { get; set; }
        public string Is_Subcontractor { get; set; }
        public string Receipt_Based_Line { get; set; }
        public string Spot_Buy_Marketplace_Seller { get; set; }
        public string Order_Confirmation_Status_Header { get; set; }
        public string Order_Confirmation_Status_Line { get; set; }
        public string Service_Order { get; set; }
        public string Requires_Service_Sheet { get; set; }
        public string Number_Substituted_OC { get; set; }
        public string Number_Confirmed_With_Changes { get; set; }
        public string Number_BackOrdered_OC { get; set; }
        public string Source_System { get; set; }
        public string Source_System_Type { get; set; }
        public string Originating_System { get; set; }
        public string Originating_System_Reference_ID { get; set; }
        public int Originating_System_Line_Number { get; set; }
        public int PO_Line_Number { get; set; }
        public string Line_Type { get; set; }
        public string Contract_Id { get; set; }
        public string Contract { get; set; }
        public string Closed_Order_Status { get; set; }
        public string Line_Closed_Status { get; set; }
        public string Description { get; set; }
        public string buyerVatID { get; set; }
        public string Bill_To_Location_ID { get; set; }
        public string Account_Assignment { get; set; }
        public string Account_Type { get; set; }
        public string Profit_Center_ID_Reporting { get; set; }
        public string Profit_Center { get; set; }
        public string Article_ID { get; set; }
        public string Asset_Id { get; set; }
        public string Asset { get; set; }
        public string Cost_Center_ID { get; set; }
        public string Cost_Center { get; set; }
        public string Item_Category { get; set; }
        public string Internal_Order_Id { get; set; }
        public string Budget_Internal_Order { get; set; }
        public string Budget_Account_Group { get; set; }
        public string Commodity_ID_L1 { get; set; }
        public string Commodity_L1 { get; set; }
        public string Commodity_ID_L2 { get; set; }
        public string Commodity_L2 { get; set; }
        public string Commodity_ID_L3 { get; set; }
        public string Commodity_L3 { get; set; }
        public string Commodity_ID { get; set; }
        public string Commodity { get; set; }
        public string ERP_Commodity_ID { get; set; }
        public string ERP_Commodity { get; set; }
        public string Price_Unit_of_Measure { get; set; }
        public string Original_Currency_Code { get; set; }
        public decimal Unit_Conversion { get; set; }
        public decimal Price_Unit_Quantity { get; set; }
        public decimal PO_Line_Amount_Range_Minimum { get; set; }
        public decimal PO_Line_Amount_Range_Maximum { get; set; }
        public decimal PO_Spend { get; set; }
        public decimal PO_Spend_Original_Currency { get; set; }
        public decimal Amount_Accepted { get; set; }
        public decimal Amount_Accepted_Original_Currency { get; set; }
        public decimal Amount_Invoiced { get; set; }
        public decimal Amount_Invoiced_Original_Currency { get; set; }
        public decimal Tax_Amount { get; set; }
        public decimal Tax_Amount_Invoiced { get; set; }
        public decimal Amount_Reconciled { get; set; }
        public decimal Amount_Reconciled_Original_Currency { get; set; }
        public decimal PO_Quantity { get; set; }
    }

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new bsnsNicheContext(
                serviceProvider.GetRequiredService<DbContextOptions<bsnsNicheContext>>()
                                                        )
                )
            {
                //Look for any purchase order
                //If there are any purchase orders in the database, the seed initializer returns and no purchase orders are added.
                if (context.PurchaseOrder.Any())
                {
                    return; //DB has been seeded
                }

                context.PurchaseOrder.AddRange(
                    new PurchaseOrder
                    {
                        Order_Id = 11,
                        Version = 1,
                        Order_Type = "Service",
                        Routing_Type = "Online",
                        PO_Status = "Open",
                        Receiving_Type = "Service",
                        Ordered_Date = DateTime.Parse("2022-01-01"),
                        Load_Create_Time = DateTime.Parse("2022-01-01"),
                        Load_Update_Time = DateTime.Parse("2022-01-10"),
                        Need_By_Date = DateTime.Parse("2022-05-10"),
                        Retroactive_Effective_Date = DateTime.Parse("2023-01-01"),
                        ERP_Supplier_ID = "1564654864",
                        ERP_Supplier = "Abdulkader Khouja Machines",
                        Supplier_VAT_Id = "6546841353651",
                        Ship_To_Location_ID = "6746165641",
                        Payment_Terms = "30 days",
                        Is_PunchOut_Item = "No",
                        Is_Retroactive = "No",
                        Is_Subcontractor = "No",
                        Receipt_Based_Line = "No",
                        Spot_Buy_Marketplace_Seller = "No",
                        Order_Confirmation_Status_Header = "Confirmed",
                        Order_Confirmation_Status_Line = "Confirmed",
                        Service_Order = "No",
                        Requires_Service_Sheet = "No",
                        Number_Substituted_OC = "12",
                        Number_Confirmed_With_Changes = "12",
                        Number_BackOrdered_OC = "0",
                        Source_System = "PAD",
                        Source_System_Type = "ERP",
                        Originating_System = "PAD",
                        Originating_System_Reference_ID = "11",
                        Originating_System_Line_Number = 1,
                        PO_Line_Number = 1,
                        Line_Type = "Catalog-Item",
                        Contract_Id = "66465456",
                        Contract = "Purchase of carpets",
                        Closed_Order_Status = "Open",
                        Line_Closed_Status = "Open",
                        Description = "fhsldjflks",
                        buyerVatID = "54465435496",
                        Bill_To_Location_ID = "6454354",
                        Account_Assignment = "Cost",
                        Account_Type = "Cost",
                        Profit_Center_ID_Reporting = "",
                        Profit_Center = "",
                        Article_ID = "",
                        Asset_Id = "",
                        Asset = "",
                        Cost_Center_ID = "155",
                        Cost_Center = "Finance Department",
                        Item_Category = "Carpets",
                        Internal_Order_Id = "",
                        Budget_Internal_Order = "",
                        Budget_Account_Group = "",
                        Commodity_ID_L1 = "10",
                        Commodity_L1 = "Office",
                        Commodity_ID_L2 = "1020",
                        Commodity_L2 = "Office Ground",
                        Commodity_ID_L3 = "102010",
                        Commodity_L3 = "Office Carpets",
                        Commodity_ID = "10201020",
                        Commodity = "IKEA Office Carpet",
                        ERP_Commodity_ID = "458546",
                        ERP_Commodity = "adflkfa",
                        Price_Unit_of_Measure = "AED",
                        Original_Currency_Code = "AED",
                        Unit_Conversion = 1,
                        Price_Unit_Quantity = 34,
                        PO_Line_Amount_Range_Minimum = 50,
                        PO_Line_Amount_Range_Maximum = 0,
                        PO_Spend = 50,
                        PO_Spend_Original_Currency = 50,
                        Amount_Accepted = 0,
                        Amount_Accepted_Original_Currency = 0,
                        Amount_Invoiced = 0,
                        Amount_Invoiced_Original_Currency = 0,
                        Tax_Amount = 3,
                        Tax_Amount_Invoiced = 3,
                        Amount_Reconciled = 0,
                        Amount_Reconciled_Original_Currency = 0,
                        PO_Quantity = 1,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
