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
    public class BFTTicket : JsonObject
    {
        public static string Endpoint { get { return "bft/tickets"; } }

        /// <summary>
        /// Ticket ID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? Id { get; set; }
        /// <summary>
        /// Ticket event ID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? EventID { get; set; }
        /// <summary>
        /// Ticket product ID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? ProductID { get; set; }
        /// <summary>
        /// Ticket timestamp
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Timestamp { get; set; }
        /// <summary>
        /// Ticket status
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? Status { get; set; }
    }
}
