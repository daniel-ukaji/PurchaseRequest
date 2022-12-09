using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PurchaseRequest.Contracts;
using PurchaseRequest.Data;
using PurchaseRequest.Models;

namespace PurchaseRequest.Controllers
{
    [Authorize]
    public class PurchasingRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IPurchaseRequestRepository purchaseRequestRepository;

        public PurchasingRequestsController(ApplicationDbContext context, IPurchaseRequestRepository purchaseRequestRepository)
        {
            _context = context;
            this.purchaseRequestRepository = purchaseRequestRepository;
        }

        // GET: PurchasingRequests
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PurchasingRequests.Include(p => p.PurchaseType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PurchasingRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PurchasingRequests == null)
            {
                return NotFound();
            }

            var purchasingRequest = await _context.PurchasingRequests
                .Include(p => p.PurchaseType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purchasingRequest == null)
            {
                return NotFound();
            }

            return View(purchasingRequest);
        }

        // GET: PurchasingRequests/Create
        public IActionResult Create()
        {
            var model = new PurchasingRequestCreateVM
            {
                PurchaseTypes = new SelectList(_context.PurchaseTypes, "Id", "Name")
            };
            return View(model);
        }

        // POST: PurchasingRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PurchasingRequestCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await purchaseRequestRepository.CreatePurchaseRequest(model);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {

                ModelState.AddModelError(string.Empty, "An Error has Occurred. Please Try Again Later.");
            }
            
            model.PurchaseTypes = new SelectList(_context.PurchaseTypes, "Id", "Name", model.PurchaseTypeId);
            return View(model);
        }

        // GET: PurchasingRequests/Edit/5
        //E
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PurchasingRequests == null)
            {
                return NotFound();
            }

            var purchasingRequest = await _context.PurchasingRequests.FindAsync(id);
            if (purchasingRequest == null)
            {
                return NotFound();
            }
            ViewData["PurchaseTypeId"] = new SelectList(_context.PurchaseTypes, "Id", "Id", purchasingRequest.PurchaseTypeId);
            return View(purchasingRequest);
        }

        // POST: PurchasingRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PurchaseTypeId,DateRequested,RequestComments,Approved,Cancelled,Items,Description,Manufacturer,Model,Rating,Power,Unit,Quantity,VendorName,VendorAddress,AmountProduction,Prepayment,BalancePayment,AdviceOnCost,DeliveryDate,RequestingEmployeeId,Id,DateCreated,DateModified")] PurchasingRequest purchasingRequest)
        {
            if (id != purchasingRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchasingRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchasingRequestExists(purchasingRequest.Id))
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
            ViewData["PurchaseTypeId"] = new SelectList(_context.PurchaseTypes, "Id", "Id", purchasingRequest.PurchaseTypeId);
            return View(purchasingRequest);
        }

        // GET: PurchasingRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PurchasingRequests == null)
            {
                return NotFound();
            }

            var purchasingRequest = await _context.PurchasingRequests
                .Include(p => p.PurchaseType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purchasingRequest == null)
            {
                return NotFound();
            }

            return View(purchasingRequest);
        }

        // POST: PurchasingRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PurchasingRequests == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PurchasingRequests'  is null.");
            }
            var purchasingRequest = await _context.PurchasingRequests.FindAsync(id);
            if (purchasingRequest != null)
            {
                _context.PurchasingRequests.Remove(purchasingRequest);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchasingRequestExists(int id)
        {
          return _context.PurchasingRequests.Any(e => e.Id == id);
        }
    }
}
