using PurchaseRequest.Contracts;
using PurchaseRequest.Data;

namespace PurchaseRequest.Repositories
{
    public class PurchaseTypeRepository : GenericRepository<PurchaseType>, IPurchaseTypeRepository
    {
        public PurchaseTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
