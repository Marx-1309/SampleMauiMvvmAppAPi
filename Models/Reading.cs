using SQLite;
using SQLiteNetExtensions.Attributes;

namespace WaterBillingMobileAppAPi.Models
{
    public class Reading
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int WaterReadingExportID { get; set; }
        public int CUSTOMER_NUMBER { get; set; }
        public string? CUSTOMER_NAME { get; set; }
        public string? AREA { get; set; }
        public string? ERF_NUMBER { get; set; }
        public string? METER_NUMBER { get; set; }
        public decimal CURRENT_READING { get; set; }
        public decimal PREVIOUS_READING { get; set; }
        public int MonthID { get; set; }
        public int Year { get; set; }
        public string? CUSTOMER_ZONING { get; set; }
        public string? RouteNumber { get; set; }
        public string? Comment { get; set; }
        public int? WaterReadingTypeId { get; set; }
        public string? Meter_Reader { get; set; }
        public DateTime? READING_DATE { get; set; }
        public bool? ReadingTaken { get; set; }
        public bool? ReadingSync { get; set; }
    }
}
