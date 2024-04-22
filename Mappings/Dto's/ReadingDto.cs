﻿using SQLite;
using System.Text.Json.Serialization;

namespace WaterBillingMobileAppAPi.Mappings.Dto_s
{
    public class ReadingDto

    {
        [PrimaryKey, AutoIncrement]
        public int WaterReadingExportDataID { get; set; }
        public string CUSTOMER_NUMBER { get; set; }
        public string? METER_NUMBER { get; set; }
        public decimal CURRENT_READING { get; set; }
        public decimal PREVIOUS_READING { get; set; }
        public int MonthID { get; set; }
        public int Year { get; set; }
        public int WaterReadingExportID { get; set; }
        public byte[]? MeterImage { get; set; }

    }

    public class UpdateReadingDto

    {
        public int WaterReadingExportDataID { get; set; }
        public decimal CURRENT_READING { get; set; }
        public string? Comment { get; set; }
        public string? METER_READER { get; set; }
        public string? ReadingDate { get; set; }
    }

    public class ImageSyncDto
    {
        public byte[]? MeterImage { get; set; }
        public int WaterReadingExportDataId { get; set; }
    }
}
