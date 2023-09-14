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
        public string? CUSTCLAS { get; set; }
        public string? ADDRESS1 { get; set; }
        public string? ADDRESS2 { get; set; }
        public string? ADDRESS3 { get; set; }
        public string? ZIP { get; set; }

    }
}
