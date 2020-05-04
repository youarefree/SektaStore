using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SpeedyIntegration.Models
{
    [JsonObject]
    public class WorkingTime
    {
        public int id { get; set; }

        [JsonProperty(PropertyName ="date")]
        public string date { get; private set; }

        [JsonProperty(PropertyName = "workingTimeFrom")]
        public string WorkingTimeFrom { get; set; }

        [JsonProperty(PropertyName = "workingTimeTo")]
        public string WorkingTimeTo { get; set; }

        [JsonProperty(PropertyName = "standardSchedule")]
        public string StandardSchedule { get; set; }

    }
}
