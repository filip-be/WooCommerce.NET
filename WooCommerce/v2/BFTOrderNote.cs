using System;
using System.Runtime.Serialization;
using WooCommerceNET.Base;

namespace WooCommerceNET.WooCommerce.v2
{
    [DataContract]
    public class BFTOrderNote : JsonObject
    {
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public WCDate date_created { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string content { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool? customer_note { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string added_by { get; set; }
    }
}
