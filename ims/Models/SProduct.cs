using System.ComponentModel.DataAnnotations;

namespace ims.Models
{
    public class SProduct
    {
        public int SProductId { get; set; }
        [Required]
        public string SProductName { get; set; }
        public string SProductCode { get; set; }
        public string SBarcode { get; set; }
        public string SProductImageUrl { get; set; }
        //[Display(Name = "UOM")]
        //public int UnitOfMeasureId { get; set; }
        public double SDefaultBuyingPrice { get; set; } = 0.0;
        //public double DefaultSellingPrice { get; set; } = 0.0;
        //[Display(Name = "Branch")]
        //public int BranchId { get; set; }
        //[Display(Name = "Currency")]
        //public int CurrencyId { get; set; }
    }
}
