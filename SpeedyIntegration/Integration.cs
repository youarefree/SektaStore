using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Globalization;
using SpeedyIntegration.Models;
using SpeedyIntegraion;
using Newtonsoft.Json.Linq;
using SpeedyIntegration.Models.Response;

namespace SpeedyIntegration
{
    public class Integration
    {
        public static OfficeList GetOfficeListByCity (string city,ref string errorMessage)
        {
            var client = new System.Net.WebClient();

            string GetOfficesURL = "https://api.speedy.bg/v1/location/office";
            errorMessage = string.Empty;
            string requestString;
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            client.Encoding = Encoding.UTF8;

            try
            {
                Request GetOfficeRequest = new Request()
                {
                    userName = "999211",
                    password = "9413552687",
                    //countryId = "100",
                    name = city
                };

                requestString = JsonConvert.SerializeObject(GetOfficeRequest, Formatting.Indented);
                var response = client.UploadString(GetOfficesURL, requestString);
                var OfficeList = JsonHelper.From<OfficeListResponse>(response);

                return (OfficeList)OfficeList.offices;
            }
            catch (Exception ex)
            { 
                errorMessage = ex.Message;
                return null;
            }
        }

    }
}
