using System.ComponentModel.DataAnnotations;

namespace PurchaseRequest.Models
{
    public class PurchaseTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Purchase Type Name")]
        [Required]
        public string Name { get; set; }
    }
}
