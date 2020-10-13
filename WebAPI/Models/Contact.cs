using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class Contact
    {
        [JsonProperty("fullname")]
        public string FullName { get; private set; }
        [JsonProperty("telephone1")]
        public string Telephone { get; private set; }
        [JsonProperty("mobilephone")]
        public string MobilePhone { get; private set; }
        [JsonProperty("address1_composite")]
        public string AddressComposite { get; private set; }
        [JsonProperty("emailaddress1")]
        public string Email { get; private set; }

    }
}
