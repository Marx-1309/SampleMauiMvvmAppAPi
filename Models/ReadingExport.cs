using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterBillingMobileAppAPi.Models
{
    [Table("BS_WaterReadingExport")]
    public class ReadingExport
    {
        [Key]
        [Column("WaterReadingExportID")]
        public int WaterReadingExportID { get; set; }
        public int MonthID { get; set; }
        public int Year { get; set; }
        public int? SALSTERR { get; set; }
        public bool LastReadings { get;set; }
        public List<Reading>? Readings { get; set; }

    }
}
