using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using bsnsNiche.Data;
using bsnsNiche.Models;

namespace bsnsNiche.Controllers
{
    public class PurchaseOrdersController : Controller
    {

        /*
         * ASP.NET Core is built with dependency injection (DI). Services, such as the database context, are registered with DI in Program.cs.
         * These services are provided to components that require them via constructor parameters.
         * The constructor uses Dependency Injection to inject the bsnsNicheContext database context into the controller. The database context is
         * used in each of the CRUD methods in the controller.
         */

        /*
         * The constructor uses Dependency Injection to inject the database context (bsnsNicheContext) into the controller. The database context
         * is used in each of the CRUD methods in the controller.
         */
        private readonly bsnsNicheContext _context;

        public PurchaseOrdersController(bsnsNicheContext context)
        {
            _context = context;
        }

        // GET: PurchaseOrders

        /*
         * Notice how the code creates a List object when it calls the View method. The code passes this purchase order list from the Index action method
         * to the view:
         */
        public async Task<IActionResult> Index()
        {
              return _context.PurchaseOrder != null ? 
                          View(await _context.PurchaseOrder.ToListAsync()) :
                          Problem("Entity set 'bsnsNicheContext.PurchaseOrder'  is null.");
        }

        // GET: PurchaseOrders/Details/5

        /*
         * The id parameter is generally passed as route data. For example, https://localhost:5001/PurchaseOrders/details/1 sets:
         * The controller to the PurchaseOrders controller, the first URL segment.
         * The action to details, the second URL segment.
         * The id to 1, the last URL segment.
         * The id can be passed in with a query string, as in the following example:
         * https://localhost:5001/PurchaseOrders/details?id=1
         * The id parameter is defined as a nullable type (int?) in cases when the id value isn't provided.
         */
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PurchaseOrder == null)
            {
                return NotFound();
            }
            /* A lambda expression is passed in to the FirstOrDefaultAsync method to select movie entities that match the route data or query
             * string value.*/
            var purchaseOrder = await _context.PurchaseOrder
                .FirstOrDefaultAsync(m => m.Order_Id == id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }
            //If a movie is found, an instance of the Movie model is passed to the Details view:
            return View(purchaseOrder);
        }

        // GET: PurchaseOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PurchaseOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Order_Id,Version,Order_Type,Routing_Type,PO_Status,Receiving_Type,Ordered_Date,Load_Create_Time,Load_Update_Time,Need_By_Date,Retroactive_Effective_Date,ERP_Supplier_ID,ERP_Supplier,Supplier_VAT_Id,Ship_To_Location_ID,Payment_Terms,Is_PunchOut_Item,Is_Retroactive,Is_Subcontractor,Receipt_Based_Line,Spot_Buy_Marketplace_Seller,Order_Confirmation_Status_Header,Order_Confirmation_Status_Line,Service_Order,Requires_Service_Sheet,Number_Substituted_OC,Number_Confirmed_With_Changes,Number_BackOrdered_OC,Source_System,Source_System_Type,Originating_System,Originating_System_Reference_ID,Originating_System_Line_Number,PO_Line_Number,Line_Type,Contract_Id,Contract,Closed_Order_Status,Line_Closed_Status,Description,buyerVatID,Bill_To_Location_ID,Account_Assignment,Account_Type,Profit_Center_ID_Reporting,Profit_Center,Article_ID,Asset_Id,Asset,Cost_Center_ID,Cost_Center,Item_Category,Internal_Order_Id,Budget_Internal_Order,Budget_Account_Group,Commodity_ID_L1,Commodity_L1,Commodity_ID_L2,Commodity_L2,Commodity_ID_L3,Commodity_L3,Commodity_ID,Commodity,ERP_Commodity_ID,ERP_Commodity,Price_Unit_of_Measure,Original_Currency_Code,Unit_Conversion,Price_Unit_Quantity,PO_Line_Amount_Range_Minimum,PO_Line_Amount_Range_Maximum,PO_Spend,PO_Spend_Original_Currency,Amount_Accepted,Amount_Accepted_Original_Currency,Amount_Invoiced,Amount_Invoiced_Original_Currency,Tax_Amount,Tax_Amount_Invoiced,Amount_Reconciled,Amount_Reconciled_Original_Currency,PO_Quantity")] PurchaseOrder purchaseOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchaseOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(purchaseOrder);
        }

        // GET: PurchaseOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PurchaseOrder == null)
            {
                return NotFound();
            }

            var purchaseOrder = await _context.PurchaseOrder.FindAsync(id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }
            return View(purchaseOrder);
        }

        // POST: PurchaseOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Order_Id,Version,Order_Type,Routing_Type,PO_Status,Receiving_Type,Ordered_Date,Load_Create_Time,Load_Update_Time,Need_By_Date,Retroactive_Effective_Date,ERP_Supplier_ID,ERP_Supplier,Supplier_VAT_Id,Ship_To_Location_ID,Payment_Terms,Is_PunchOut_Item,Is_Retroactive,Is_Subcontractor,Receipt_Based_Line,Spot_Buy_Marketplace_Seller,Order_Confirmation_Status_Header,Order_Confirmation_Status_Line,Service_Order,Requires_Service_Sheet,Number_Substituted_OC,Number_Confirmed_With_Changes,Number_BackOrdered_OC,Source_System,Source_System_Type,Originating_System,Originating_System_Reference_ID,Originating_System_Line_Number,PO_Line_Number,Line_Type,Contract_Id,Contract,Closed_Order_Status,Line_Closed_Status,Description,buyerVatID,Bill_To_Location_ID,Account_Assignment,Account_Type,Profit_Center_ID_Reporting,Profit_Center,Article_ID,Asset_Id,Asset,Cost_Center_ID,Cost_Center,Item_Category,Internal_Order_Id,Budget_Internal_Order,Budget_Account_Group,Commodity_ID_L1,Commodity_L1,Commodity_ID_L2,Commodity_L2,Commodity_ID_L3,Commodity_L3,Commodity_ID,Commodity,ERP_Commodity_ID,ERP_Commodity,Price_Unit_of_Measure,Original_Currency_Code,Unit_Conversion,Price_Unit_Quantity,PO_Line_Amount_Range_Minimum,PO_Line_Amount_Range_Maximum,PO_Spend,PO_Spend_Original_Currency,Amount_Accepted,Amount_Accepted_Original_Currency,Amount_Invoiced,Amount_Invoiced_Original_Currency,Tax_Amount,Tax_Amount_Invoiced,Amount_Reconciled,Amount_Reconciled_Original_Currency,PO_Quantity")] PurchaseOrder purchaseOrder)
        {
            if (id != purchaseOrder.Order_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseOrderExists(purchaseOrder.Order_Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(purchaseOrder);
        }

        // GET: PurchaseOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PurchaseOrder == null)
            {
                return NotFound();
            }

            var purchaseOrder = await _context.PurchaseOrder
                .FirstOrDefaultAsync(m => m.Order_Id == id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return View(purchaseOrder);
        }

        // POST: PurchaseOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PurchaseOrder == null)
            {
                return Problem("Entity set 'bsnsNicheContext.PurchaseOrder'  is null.");
            }
            var purchaseOrder = await _context.PurchaseOrder.FindAsync(id);
            if (purchaseOrder != null)
            {
                _context.PurchaseOrder.Remove(purchaseOrder);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseOrderExists(int id)
        {
          return (_context.PurchaseOrder?.Any(e => e.Order_Id == id)).GetValueOrDefault();
        }
    }
}
