using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterBillingMobileAppAPi.Models
{
    public class Device
    {
        public Device()
        {
            this.Active = false;
            this.LastActive = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public int UserId { get; set; }
        public DateTime LastActive { get; set; }
        public bool Active { get; set; }

    }
}
