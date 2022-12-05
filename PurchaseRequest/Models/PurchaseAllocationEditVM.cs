namespace PurchaseRequest.Models
{
    public class PurchaseAllocationEditVM : PurchaseAllocationVM
    {
        public string EmployeeId { get; set; }
        public int PurchaseTypeId { get; set; }
        public EmployeeListVM? Employee { get; set; }
    }
}
