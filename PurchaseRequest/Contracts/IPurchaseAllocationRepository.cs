using PurchaseRequest.Data;
using PurchaseRequest.Models;

namespace PurchaseRequest.Contracts
{
    public interface IPurchaseAllocationRepository : IGenericRepository<PurchaseAllocation>
    {
        Task PurchaseAllocation(int purchaseTypeId);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<PurchaseAllocationEditVM> GetEmployeeAllocation(int id);
        Task<bool> UpdateEmployeeAllocation(PurchaseAllocationEditVM model);


    }
}
