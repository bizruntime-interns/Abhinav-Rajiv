using System;
using System.Runtime.Serialization;

namespace contracts
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string type { get; set; }

    }
}
