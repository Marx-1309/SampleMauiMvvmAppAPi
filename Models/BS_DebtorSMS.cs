using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using WaterBillingMobileAppAPi.Models;

namespace WaterBillingMobileAppAPi.Models
{
    public class BS_DebtorSMS
    {
        [Key]
        public System.Int64 DebtorSMSID { get; set; }
        public string CUSTNMBR { get; set; }
        public System.Int64? CellPhoneNumber1 { get; set; } = 0;
        public System.Int64? CellPhoneNumber2 { get; set; } = 0;

    }
}
