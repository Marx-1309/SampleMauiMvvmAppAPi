using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterBillingMobileAppAPi.Models
{
    [Table("BS_WaterReadingExport")]
    public class ReadingExport
    {
        [Key]
        [Column("WaterReadingExportID")]
        public System.Int64 WaterReadingExportID { get; set; }
        public System.Int64 MonthID { get; set; }
        public System.Int64 Year { get; set; }
        public string? SALSTERR { get; set; }
        //public bool LastReadings { get;set; }
        public List<Reading>? Readings { get; set; }

    }
}
