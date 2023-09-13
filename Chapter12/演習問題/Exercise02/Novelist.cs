using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    [DataContract]
    public class Novelist {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "birth")]
        public DateTime Birth { get; set; }
        [DataMember(Name = "masterpieces")]
        public string[] Masterpieces { get; set; }
    }
}
