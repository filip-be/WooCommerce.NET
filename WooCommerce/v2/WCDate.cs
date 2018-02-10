using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WooCommerceNET.WooCommerce.v2
{
    [DataContract]
    public class WCDate
    {
        [DataMember(EmitDefaultValue = false)]
        public string date { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? timezone_type { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string timezone { get; set; }
    }
}
