using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Evolent.Persistance
{
    [DataContract]
    public class Contact
    {
        [JsonProperty(PropertyName = "Id")]
        [DataMember]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "FirstName")]
        [DataMember]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "LastName")]
        [DataMember]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "Email")]
        [DataMember]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "PhoneNumber")]
        [DataMember]
        public string PhoneNumber { get; set; }

        [JsonProperty(PropertyName = "Status")]
        [DataMember]
        public bool Status { get; set; }
    }
}
