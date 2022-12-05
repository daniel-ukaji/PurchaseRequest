using System.ComponentModel.DataAnnotations;

namespace PurchaseRequest.Models
{
    public class PurchaseAllocationVM
    {
        [Required]
        public int Id { get; set; }
        public int Period { get; set; }
        public PurchaseTypeVM? PurchaseType { get; set; }
    }
}