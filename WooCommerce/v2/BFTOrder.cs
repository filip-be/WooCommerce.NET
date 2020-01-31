using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        /// <summary>
        /// Order billing name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string OrderBillingName { get; set; }
        /// <summary>
        /// Order billing email address
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string OrderBillingEmail { get; set; }
        /// <summary>
        /// Order billing phone
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string OrderBillingPhone { get; set; }
        /// <summary>
        /// Order customer note
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string OrderCustomerNote { get; set; }
        /// <summary>
        /// Order notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<BFTOrderNote> OrderNotes { get; set; }
        /// <summary>
        /// Order key
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string OrderKey { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null)
                return false;
            if(obj.GetType() != typeof(BFTOrder))
                return false;

            BFTOrder order = obj as BFTOrder;
            if (order.OrderId.Equals(OrderId))
                return false;
            if (order.Status.Equals(Status))
                return false;
            if (order.Type.Equals(Type))
                return false;
            if ((order.Tickets == null) != (Tickets == null))
                return false;
            if (Tickets != null && order.Tickets.Count() != Tickets.Count())
                return false;
            if (Tickets != null && Tickets.Where((t, index) => !t.Equals(order.Tickets[index])).Any())
                return false;
            if (order.OrderBillingName.Equals(OrderBillingName))
                return false;
            if (order.OrderBillingEmail.Equals(OrderBillingEmail))
                return false;
            if (order.OrderBillingPhone.Equals(OrderBillingPhone))
                return false;
            if (order.OrderCustomerNote.Equals(OrderCustomerNote))
                return false;
            if (order.OrderKey.Equals(OrderKey))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
