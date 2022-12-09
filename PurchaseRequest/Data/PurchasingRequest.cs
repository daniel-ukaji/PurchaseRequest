using System.ComponentModel.DataAnnotations.Schema;

namespace PurchaseRequest.Data
{
    public class PurchasingRequest : BaseEntity
    {
        public DateTime DateRequested { get; set; }
        public string? RequestComments { get; set; }


        [ForeignKey("PurchaseTypeId")]
        public PurchaseType PurchaseType { get; set; }
        public int PurchaseTypeId { get; set; }


        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

        public string? Items { get; set; }
        public string? Description { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public string? Rating { get; set; }
        public string? Power { get; set; }
        public string? Unit { get; set; }
        public int Quantity { get; set; }
        public string? VendorName { get; set; }
        public string? VendorAddress { get; set; }
        public int AmountProduction { get; set; }
        public int Prepayment { get; set; }
        public int BalancePayment { get; set; }
        public string? AdviceOnCost { get; set; }
        public DateTime DeliveryDate { get; set; }
        


        public string RequestingEmployeeId { get; set; }
    }
}
