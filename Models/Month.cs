﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterBillingMobileAppAPi.Models
{
    [Table("BS_Month")]
    public class Month
    {
        [Key]
        [Column("MonthID")]
        public System.Int64 MonthID { get; set; }
        public string? MonthName { get; set; }

        [NotMapped]
        public string TitleProp => $"{MonthName}";
    }
}

