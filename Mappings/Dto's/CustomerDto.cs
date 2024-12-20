﻿using WaterBillingMobileAppAPi.Mappings.Dto_s;
using System.Text.Json.Serialization;


namespace WaterBillingMobileAppAPi.Mappings.Dto_s
{
    public class CustomerDto
    {
        public string CUSTMBR { get; set; }
        public string CUSTNAME { get; set; }
        public long? PHONE1 { get; set; } = 0;
        public string CUSTCLAS { get; set; }
        public string STATE { get; set; }
        public string ZIP { get; set; }
    }
}
