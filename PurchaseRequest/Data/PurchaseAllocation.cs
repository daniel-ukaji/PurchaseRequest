using System.ComponentModel.DataAnnotations.Schema;

namespace PurchaseRequest.Data
{
    public class PurchaseAllocation : BaseEntity
    {
        [ForeignKey("PurchaseTypeId")]
        public PurchaseType PurchaseType { get; set; }
        public int PurchaseTypeId { get; set; }

        public string EmployeeId { get; set; }

        public int Period { get; set; }
        
    }
}
