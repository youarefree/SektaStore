using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedyIntegration.Models.Response
{
    [JsonObject]
    public class Office
    {
        [JsonProperty(PropertyName = "id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int id { get; set; }
        [JsonProperty(PropertyName = "name", DefaultValueHandling = DefaultValueHandling.Include)]
        string name { get; set; }
        [JsonProperty(PropertyName = "nameEn", DefaultValueHandling = DefaultValueHandling.Include)]
        string nameEn { get; set; }

        [JsonProperty(PropertyName = "siteId", DefaultValueHandling = DefaultValueHandling.Include)]
        long siteId { get; set; }

        [JsonProperty(PropertyName = "address", DefaultValueHandling = DefaultValueHandling.Include)]
        public Address address { get; private set; }

        [JsonProperty(PropertyName = "workingTimeFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        string WorkingTimeFrom { get; set; }

        [JsonProperty(PropertyName = "workingTimeTo", DefaultValueHandling = DefaultValueHandling.Include)]
        string workingTimeTo { get; set; }

        [JsonProperty(PropertyName = "workingTimeHalfFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        string workingTimeHalfFrom { get; set; }

        [JsonProperty(PropertyName = "workingTimeHalfTo", DefaultValueHandling = DefaultValueHandling.Include)]
        string workingTimeHalfTo{ get; set; }

        [JsonProperty(PropertyName = "workingTimeDayOffFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        string workingTimeDayOffFrom{ get; set; }

        [JsonProperty(PropertyName = "workingTimeDayOffTo", DefaultValueHandling = DefaultValueHandling.Include)]
        string workingTimeDayOffTo{ get; set; }

        [JsonProperty(PropertyName = "maxParcelDimensions")]
        MaxParcelDemensions maxParcelDimensions{ get; set; }

        [JsonProperty(PropertyName = "maxParcelWeight", DefaultValueHandling = DefaultValueHandling.Include)]
        double maxParcelWeight{ get; set; }
        [JsonProperty(PropertyName = "type", DefaultValueHandling = DefaultValueHandling.Include)]

        string type{ get; set; }
        [JsonProperty(PropertyName = "nearbyOfficeId", DefaultValueHandling = DefaultValueHandling.Include)]
        int nearbyOfficeId{ get; set; }

        [JsonProperty(PropertyName = "workingTimeSchedule", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkingTimeSchedule workingTimeSchedule { get; set; }

        [JsonProperty(PropertyName = "palletOffice", DefaultValueHandling = DefaultValueHandling.Include)]
        bool palletOffice{ get; set; }

        [JsonProperty(PropertyName = "cardPaymentAllowed", DefaultValueHandling = DefaultValueHandling.Include)]
        bool cardPaymentAllowed{ get; set; }

        [JsonProperty(PropertyName = "cashPaymentAllowed", DefaultValueHandling = DefaultValueHandling.Include)]
        bool cashPaymentAllowed{ get; set; }

        [JsonProperty(PropertyName = "validFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        DateTime validFrom{ get; set; }

        [JsonProperty(PropertyName = "validTo", DefaultValueHandling = DefaultValueHandling.Include)]
        DateTime validTo{ get; set; }

        [JsonProperty(PropertyName = "cargoTypesAllowed", DefaultValueHandling = DefaultValueHandling.Include)]
        CargoTypesAllowed cargoTypesAllowed { get; set; }




    }
}
