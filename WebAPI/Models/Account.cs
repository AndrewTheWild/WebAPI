using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class Account
    {
        [JsonProperty("name")]
        public string Name { get; private set; }
        [JsonProperty("telephone1")]
        public string Telephone { get; private set; }
        [JsonProperty("websiteurl")]
        public string WebSite { get; private set; }
        [JsonProperty("address1_line1")]
        public string Address1 { get; private set; }
        [JsonProperty("address1_line2")]
        public string Address2 { get; private set; }
        [JsonProperty("address1_city")]
        public string City { get; private set; }
        [JsonProperty("address1_postalcode")]
        public string PostalCode { get; private set; }
        [JsonProperty("address1_stateorprovince")]
        public string StateOrProvince{get;private set;}
        [JsonProperty("Contacts")]
        public List<Contact> Contacts { get; private set; }

    }
}
