using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SpeedyIntegration.Models
{
    [JsonObject]
    class MaxParcelDemensions
    {
        [JsonProperty(PropertyName = "width")]
        decimal width { get; set; }
  
        [JsonProperty(PropertyName = "height")]
        int height { get; set; }

        [JsonProperty(PropertyName = "depth")]
        int depth { get; set; }
    }
}
