using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterBillingMobileAppAPi.Models
{
    [Table("RM00101")]
    public class Customer
    {

        [Column("CUSTNMBR")]
        [Key]
        public string? CUSTNMBR { get; set; }
        public string? CUSTNAME { get; set; }
        [NotMapped]
        public System.Int64? PHONE1 { get; set; } = 0;
        public string? CUSTCLAS { get; set; }
        public string? STATE { get; set; }
        public string? ZIP { get; set; }

    }
}
