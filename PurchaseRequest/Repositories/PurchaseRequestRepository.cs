using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PurchaseRequest.Contracts;
using PurchaseRequest.Data;
using PurchaseRequest.Models;

namespace PurchaseRequest.Repositories
{
    public class PurchaseRequestRepository : GenericRepository<PurchasingRequest>, IPurchaseRequestRepository
    {
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<Employee> userManager;

        public PurchaseRequestRepository(ApplicationDbContext context,
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor,
            UserManager<Employee> userManager) : base(context)
        {
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
        }

        public async Task CreatePurchaseRequest(PurchasingRequestCreateVM model)
        {
            var user = await userManager.GetUserAsync(httpContextAccessor.HttpContext?.User);
            
            var purchaseRequest = mapper.Map<PurchasingRequest>(model);
            purchaseRequest.DateRequested = DateTime.Now;
            purchaseRequest.RequestingEmployeeId = user.Id;

            await AddAsync(purchaseRequest);

        }
    }
}
