using PurchaseRequest.Data;
using PurchaseRequest.Models;

namespace PurchaseRequest.Contracts
{
    public interface IPurchaseRequestRepository : IGenericRepository<PurchasingRequest>
    {
        Task CreatePurchaseRequest(PurchasingRequestCreateVM model);
    }
}
