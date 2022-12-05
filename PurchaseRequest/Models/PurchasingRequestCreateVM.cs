using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PurchaseRequest.Models
{
    public class PurchasingRequestCreateVM
    {
        [Display(Name = "Any Other Information")]
        public string? RequestComments { get; set; }

        [Display(Name = "Items Class")]
        public string Items { get; set; }


        public int PurchaseTypeId { get; set; }
        public SelectList? PurchaseTypes { get; set; }


        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Manufacturer")]
        public string Manufacturer { get; set; }

        [Display(Name = "Model/Type")]
        public string Model { get; set; }

        [Display(Name = "Rating/Size")]
        public string Rating { get; set; }

        [Display(Name = "Power/Capacity")]
        public string Power { get; set; }

        [Display(Name = "Unit of Measure")]
        public string Unit { get; set; }

        [Display(Name = "Quantity Required")]
        public int Quantity { get; set; }

        [Display(Name = "Vendor Name")]
        public string VendorName { get; set; }

        [Display(Name = "Vendor Address")]
        public string VendorAddress { get; set; }

        [Display(Name = "Amount of Production")]
        public int AmountProduction { get; set; }

        [Display(Name = "Prepayment")]
        public int Prepayment { get; set; }

        [Display(Name = "Balance Payment")]
        public int BalancePayment { get; set; }

        [Display(Name = "Advice on Cost")]
        public string AdviceOnCost { get; set; }

        [Display(Name = "Expected Delivery Date")]
        public DateTime DeliveryDate { get; set; }



    }
}
