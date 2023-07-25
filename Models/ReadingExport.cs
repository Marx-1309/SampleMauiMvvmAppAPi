using SQLite;
using SQLiteNetExtensions.Attributes;


namespace WaterBillingMobileAppAPi.Models
{
    public class ReadingExport
    {
        [PrimaryKey]
        public int Id { get; set; }

        [ForeignKey(typeof(Month), Name = "Id")]
        public int MonthID { get; set; }
        public int Year { get; set; }
        public int RM00303Id { get; set; }
        [OneToMany]
        public List<Reading>? Readings { get; set; }
    }
}
