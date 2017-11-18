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
    public class BFTOrderTicket : JsonObject
    {
        [DataMember(EmitDefaultValue = false)]
        public int? ID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? TicketID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? OrderID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? OrderItemID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Hash { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Timestamp { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? Status { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != typeof(BFTOrderTicket))
                return false;

            BFTOrderTicket order = obj as BFTOrderTicket;
            if (order.ID != ID)
                return false;
            if (order.TicketID != TicketID)
                return false;
            if (order.OrderID != OrderID)
                return false;
            if (order.OrderItemID != OrderItemID)
                return false;
            if (order.Hash != Hash)
                return false;
            if (order.Timestamp != Timestamp)
                return false;
            if (order.Status != Status)
                return false;

            return true;
        }
    }
}
