using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterBillingMobileAppAPi.Models
{
    [Table("BS_WaterReadingExport")]
    public class ReadingExport
    {
        [Key]
        [Column("WaterReadingExportID")]
        public long WaterReadingExportID { get; set; }
        public long MonthID { get; set; }
        public long Year { get; set; }
        public string? SALSTERR { get; set; }
        public bool LastReadings { get;set; }
        public List<Reading>? Readings { get; set; }

    }
}
