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
    public class BFTOrder : JsonObject
    {
        public static string Endpoint { get { return "bft/orders"; } }

        /// <summary>
        /// Order ID
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? OrderId { get; set; }
        /// <summary>
        /// Order type - FULL / PARTIAL
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Type { get; set; }
        /// <summary>
        /// Order status.
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Status { get; set; }
        /// <summary>
        /// Order tickets.
        /// read-write
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<BFTOrderTicket> Tickets { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null)
                return false;
            if(obj.GetType() != typeof(BFTOrder))
                return false;

            BFTOrder order = obj as BFTOrder;
            if (order.OrderId != OrderId)
                return false;
            if (order.Status != Status)
                return false;
            if (order.Type != Type)
                return false;
            if ((order.Tickets == null) != (Tickets == null))
                return false;
            if (Tickets != null && order.Tickets.Count() != Tickets.Count())
                return false;
            if (Tickets != null && Tickets.Where((t, index) => !t.Equals(order.Tickets[index])).Any())
                return false;

            return true;
        }
    }
}
