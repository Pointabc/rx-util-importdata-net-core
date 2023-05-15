﻿namespace ImportData.IntegrationServicesClient.Models
{
    [EntityName("Валюта")]
    public class ICurrency
    {
        public string Name { get; set; }
        public string AlphaCode { get; set; }
        public string ShortName { get; set; }
        public string FractionName { get; set; }
        public bool IsDefault { get; set; }
        public string NumericCode { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
