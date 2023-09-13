using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WaterBillingMobileAppAPi.Models
{
    [Table("BS_WaterReadingExportData")]
    public class Reading
    {
        [Key]
        [Column("WaterReadingExportDataID")]
        public int? WaterReadingExportDataID { get; set; }
        public int? WaterReadingExportID { get; set; }
        public string? CUSTOMER_NUMBER { get; set; }
        public string? CUSTOMER_NAME { get; set; }
        public string? AREA { get; set; }
        public string? ERF_NUMBER { get; set; }
        public string? METER_NUMBER { get; set; }
        public decimal? CURRENT_READING { get; set; }
        public decimal? PREVIOUS_READING { get; set; }
        public int? MonthID { get; set; }
        public int? Year { get; set; }
        public string? CUSTOMER_ZONING { get; set; }
        public string? RouteNumber { get; set; }
        public string? METER_READER { get; set; }
        public string? Comment { get; set; }
        public int? WaterReadingTypeID { get; set; }
        
    }
}
