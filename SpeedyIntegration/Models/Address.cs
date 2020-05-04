using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedyIntegration.Models.Response
{
    public class Address
    {
        public int addressId { get; set; }
        public int countryId { get; set; }
        public int siteId { get; set; }
        public string siteType { get; set; }
        public string siteName { get; set; }
        public string postCode { get; set; }
        public int streetId { get; set; }
        public string streetType { get; set; }
        public string streetName { get; set; }
        public string streetNo { get; set; }
        public string addressNote { get; set; }
        public long x { get; set; }
        public long y { get; set; }
        public string fullAddressString { get; set; }
        public string siteAddressString { get; set; }
        public string localAddressString { get; set; }
    }
}
