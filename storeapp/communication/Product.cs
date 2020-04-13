using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace communication
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name{ get; set; }

        [DataMember]
        public string type { get; set; }
    }
}
