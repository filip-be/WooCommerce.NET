using System.Runtime.Serialization;
using WooCommerceNET.Base;

namespace WooCommerceNET.WooCommerce.v2
{
    [DataContract]
    public class BFTStatistic : JsonObject
    {
        public static string Endpoint { get { return "bft/statistics"; } }

        /// <summary>
        /// Event name
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Event { get; set; }
        /// <summary>
        /// Product name
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Product { get; set; }
        /// <summary>
        /// Already checked tickets count
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? CheckedTickets { get; set; }
        /// <summary>
        /// All tickets count
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? TicketsCount { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != typeof(BFTStatistic))
                return false;

            BFTStatistic stats = obj as BFTStatistic;
            if (stats.Event.Equals(Event))
                return false;
            if (stats.Product.Equals(Product))
                return false;
            if (stats.CheckedTickets.Equals(CheckedTickets))
                return false;
            if (stats.TicketsCount.Equals(TicketsCount))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
