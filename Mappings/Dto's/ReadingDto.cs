﻿using SQLite;

namespace WaterBillingMobileAppAPi.Mappings.Dto_s
{
    public class ReadingDto

    {
        [PrimaryKey, AutoIncrement]
        public long WaterReadingExportDataID { get; set; }
        public string CUSTOMER_NUMBER { get; set; }
        public string? METER_NUMBER { get; set; }
        public decimal CURRENT_READING { get; set; }
        public decimal PREVIOUS_READING { get; set; }
        public long MonthID { get; set; }
        public long Year { get; set; }
        public long WaterReadingExportID { get; set; }

    }

    public class UpdateReadingDto

    {
        public long WaterReadingExportDataID { get; set; }
        public decimal CURRENT_READING { get; set; }
        public string Comment { get; set; }
        public string? METER_READER { get; set; }
        public DateTime? READING_DATE { get; set; }
    }
}