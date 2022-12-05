using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PurchaseRequest.Constants;
using PurchaseRequest.Contracts;
using PurchaseRequest.Data;
using PurchaseRequest.Models;

namespace PurchaseRequest.Repositories
{
    public class PurchaseAllocationRepository : GenericRepository<PurchaseAllocation>, IPurchaseAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly IPurchaseTypeRepository purchaseTypeRepository;
        private readonly IMapper mapper;

        public PurchaseAllocationRepository(ApplicationDbContext context, 
            UserManager<Employee> userManager, IPurchaseTypeRepository purchaseTypeRepository, IMapper mapper) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.purchaseTypeRepository = purchaseTypeRepository;
            this.mapper = mapper;
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations = await context.PurchaseAllocations
                .Include(q => q.PurchaseType)
                .Where(q => q.EmployeeId == employeeId)
                .ToListAsync();
            var employee = await userManager.FindByIdAsync(employeeId);


            var employeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationModel.PurchaseAllocations = mapper.Map<List<PurchaseAllocationVM>>(allocations);


            return employeeAllocationModel;
        }

        public async Task<PurchaseAllocationEditVM> GetEmployeeAllocation(int id)
        {
            var allocation = await context.PurchaseAllocations
                .Include(q => q.PurchaseType)
                .FirstOrDefaultAsync(q => q.Id == id);

            if(allocation == null)
            {
                return null;
            }

            var employee = await userManager.FindByIdAsync(allocation.EmployeeId);


            var model = mapper.Map<PurchaseAllocationEditVM>(allocation);
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(allocation.EmployeeId));


            return model;
        }

        public async Task PurchaseAllocation(int purchaseTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var purchaseType = await purchaseTypeRepository.GetAsync(purchaseTypeId);
            var allocations = new List<PurchaseAllocation>();
            foreach (var employee in employees)
            {
                allocations.Add(new PurchaseAllocation
                {
                    EmployeeId = employee.Id,
                    PurchaseTypeId = purchaseTypeId,
                    Period = period
                });
            }

            await AddRangeAsync(allocations);
        }

        public async Task<bool> UpdateEmployeeAllocation(PurchaseAllocationEditVM model)
        {
            var purchaseAllocation = await GetAsync(model.Id);
            if (purchaseAllocation == null)
            {
                return false;
            }
            purchaseAllocation.Period = model.Period;
            await UpdateAsync(purchaseAllocation);

            return true;
        }
    }
}
