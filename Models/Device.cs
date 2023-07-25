using SQLite;
using SQLiteNetExtensions.Attributes;

namespace WaterBillingMobileAppAPi.Models
{
    public class Device
    {
        public Device()
        {
            this.Active = false;
            this.LastActive = DateTime.Now;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string SerialNumber { get; set; }

        [ForeignKey(typeof(User), Name = "Id")]
        public int UserId { get; set; }
        public DateTime LastActive { get; set; }
        public bool Active { get; set; }

    }
}
