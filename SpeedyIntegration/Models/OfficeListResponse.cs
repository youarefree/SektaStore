using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedyIntegration.Models.Response
{
    [JsonObject]
    public class OfficeListResponse 
    {
        [JsonProperty(PropertyName = "offices", DefaultValueHandling = DefaultValueHandling.Include)]
        public OfficeList offices { get; set; }
    }
}
