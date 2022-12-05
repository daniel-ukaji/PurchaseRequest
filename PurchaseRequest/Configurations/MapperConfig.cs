using AutoMapper;
using PurchaseRequest.Data;
using PurchaseRequest.Models;

namespace PurchaseRequest.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<PurchaseType, PurchaseTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();
            CreateMap<PurchaseAllocation, PurchaseAllocationVM>().ReverseMap();
            CreateMap<PurchaseAllocation, PurchaseAllocationEditVM>().ReverseMap();
            CreateMap<PurchasingRequest, PurchasingRequestCreateVM>().ReverseMap();
        }
    }
}
