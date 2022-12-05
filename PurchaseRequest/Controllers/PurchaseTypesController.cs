using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PurchaseRequest.Constants;
using PurchaseRequest.Contracts;
using PurchaseRequest.Data;
using PurchaseRequest.Models;

namespace PurchaseRequest.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class PurchaseTypesController : Controller
    {
        private readonly IPurchaseTypeRepository purchaseTypeRepository;
        private readonly IMapper mapper;
        private readonly IPurchaseAllocationRepository purchaseAllocationRepository;

        public PurchaseTypesController(IPurchaseTypeRepository purchaseTypeRepository,  
            IMapper mapper,
            IPurchaseAllocationRepository purchaseAllocationRepository)
        {
            this.purchaseTypeRepository = purchaseTypeRepository;
            this.mapper = mapper;
            this.purchaseAllocationRepository = purchaseAllocationRepository;
        }

        // GET: PurchaseTypes
        public async Task<IActionResult> Index()
        {
           // var purchaseTypes = await purchaseTypeRepository.GetAllAsync();
            var purchaseTypes = mapper.Map<List<PurchaseTypeVM>>(await purchaseTypeRepository.GetAllAsync());
            return View(purchaseTypes); 
        }

        // GET: PurchaseTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var purchaseType = await purchaseTypeRepository.GetAsync(id);
            if (purchaseType == null)
            {
                return NotFound();
            }

            var purchaseTypeVM = mapper.Map<PurchaseTypeVM>(purchaseType);
            return View(purchaseTypeVM);
        }

        // GET: PurchaseTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PurchaseTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PurchaseTypeVM purchaseTypeVM)
        {
            if (ModelState.IsValid)
            {
                var purchaseType = mapper.Map<PurchaseType>(purchaseTypeVM);
                await purchaseTypeRepository.AddAsync(purchaseType);
                return RedirectToAction(nameof(Index));
            }
            return View(purchaseTypeVM);
        }

        // GET: PurchaseTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            var purchaseType = await purchaseTypeRepository.GetAsync(id);
            if (purchaseType == null)
            {
                return NotFound();
            }

            var purchaseTypeVM = mapper.Map<PurchaseTypeVM>(purchaseType);
            return View(purchaseTypeVM);
        }

        // POST: PurchaseTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PurchaseTypeVM purchaseTypeVM)
        {
            if (id != purchaseTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var purchaseType = mapper.Map<PurchaseType>(purchaseTypeVM);
                    await purchaseTypeRepository.UpdateAsync(purchaseType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await purchaseTypeRepository.Exists(purchaseTypeVM.Id))
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
            return View(purchaseTypeVM);
        }


        // POST: PurchaseTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await purchaseTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AllocatePurchase(int id)
        {
            await purchaseAllocationRepository.PurchaseAllocation(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
