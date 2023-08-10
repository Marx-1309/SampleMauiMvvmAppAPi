using SQLite;
using SQLiteNetExtensions.Attributes;


namespace WaterBillingMobileAppAPi.Models
{
    public class ReadingExport
    {
        [PrimaryKey]
        public int Id { get; set; }
        public int MonthID { get; set; }
        public Month? Month { get; set; } // Navigational property for Month

        public int Year { get; set; }
        public int RM00303Id { get; set; }
        public RM00303? RM00303 { get; set; } // Navigational property for RM00303

        public List<Reading>? Readings { get; set; }

    }
}
