using System.Collections.Generic;
using Newtonsoft.Json;

namespace App1.Models.Responses
{
    public class UserWithCarsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("cars")]
        public List<CarResponse> Cars { get; set; }
    }
}
