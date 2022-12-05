using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PurchaseRequest.Constants;
using PurchaseRequest.Contracts;
using PurchaseRequest.Data;
using PurchaseRequest.Models;

namespace PurchaseRequest.Controllers
{
    
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly IPurchaseAllocationRepository purchaseAllocationRepository;
        private readonly IPurchaseTypeRepository purchaseTypeRepository;

        public EmployeesController(UserManager<Employee> userManager, 
            IMapper mapper, 
            IPurchaseAllocationRepository purchaseAllocationRepository,
            IPurchaseTypeRepository purchaseTypeRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.purchaseAllocationRepository = purchaseAllocationRepository;
            this.purchaseTypeRepository = purchaseTypeRepository;
        }
        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var model = mapper.Map<List<EmployeeListVM>>(employees);
            return View(model);
        }

        // GET: EmployeesController/ViewAllocations/employeeId
        public async Task<ActionResult> ViewAllocations(string id)
        {
            var model = await purchaseAllocationRepository.GetEmployeeAllocations(id);
            return View(model);
        }

        // GET: EmployeesController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int id)
        {
            var model = await purchaseAllocationRepository.GetEmployeeAllocation(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: EmployeesController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, PurchaseAllocationEditVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    if(await purchaseAllocationRepository.UpdateEmployeeAllocation(model))
                    {
                        return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
                    }
                     
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An Error has Occurred. Please Try Again Later.");
                
            }
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(model.EmployeeId));
            model.PurchaseType = mapper.Map<PurchaseTypeVM>(await purchaseTypeRepository.GetAsync(model.PurchaseTypeId));
            return View(model);
        }
    }
}
