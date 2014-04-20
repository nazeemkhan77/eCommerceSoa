using System;

namespace Domain.Common
{
    public class Phone
    {
        public String Type { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string Number { get; set; }
        public bool IsPrimary { get; set; }
    }
}