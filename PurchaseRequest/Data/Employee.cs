using Microsoft.AspNetCore.Identity;

namespace PurchaseRequest.Data
{
    public class Employee : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? TaxId { get; set; }
        

    }
}
