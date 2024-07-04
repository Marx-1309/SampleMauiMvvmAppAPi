using System.ComponentModel.DataAnnotations.Schema;

namespace WaterBillingMobileAppAPi.Models
{
    [Table("Bs_BillingLocation")]
    public class BillingLocation
    {
        public long BillingLocationID { get; set; }
        public string? Location { get; set; }
        //public string? Township { get; set; }
    }
}
