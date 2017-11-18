using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WooCommerceNET.Base;

namespace WooCommerceNET.WooCommerce.v2
{
    [DataContract]
    public class BFTEvent : JsonObject
    {
        public static string Endpoint { get { return "bft/events"; } }

        /// <summary>
        /// Event ID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? Id { get; set; }
        /// <summary>
        /// Event name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Event timestamp
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Timestamp { get; set; }
        /// <summary>
        /// Event status
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? Status { get; set; }
    }
}
