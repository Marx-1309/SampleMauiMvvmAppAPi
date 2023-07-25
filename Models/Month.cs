using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterBillingMobileAppAPi.Models
{
    public class Month
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string? MonthName { get; set; }
        public int Year { get; set; }

        [NotMapped]
        public string TitleProp => $"{MonthName} {Year} ";
    }
}

